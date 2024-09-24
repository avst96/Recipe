-- SM Excellent! 100% See comments.
use HeartyHearthDB
go
--13 Tables total
drop table if exists CookbookRecipe
drop table if exists Cookbook
drop table if exists MealCourseRecipe
drop table if exists MealCourse
drop table if exists Meal
drop table if exists RecipeIngredient
drop table if exists MeasuringUnit
drop table if exists Directions
drop table if exists Recipe
drop table if exists Ingredient
drop table if exists Course
drop table if exists Cuisine
drop table if exists Users
go 

---
create table dbo.Users(
    UsersID int not null identity primary key,
    FirstName varchar(35) not null constraint ck_Users_FirstName_cannot_be_blank check(FirstName > ''),
    LastName varchar(35) not null constraint ck_Users_LastName_cannot_be_blank check(LastName > ''),
    UserName varchar(20) not null 
        constraint ck_Users_UserName_cannot_be_blank check(UserName > '') 
        constraint u_Users_UserName_must_be unique
)
---

create table dbo.Cuisine (
    CuisineID int not null identity primary key,
    CuisineName varchar(20) not null 
        constraint ck_Cuisine_CuisineName_cannot_be_blank check(CuisineName > '')
        constraint u_Cuisine_CuisineName_must_be unique
)   

 -----
create table dbo.Course(
    CourseID int not null identity primary key,
    CourseName varchar(20) not null 
        constraint ck_Course_CourseName_cannot_be_blank check(CourseName > '') 
        constraint u_Course_CourseName_must_be unique,
    CourseSeq int not null 
        constraint ck_Course_CourseSeq_must_be_greater_then_0 check(CourseSeq > 0)
        constraint u_Course_CourseSeq_must_be unique
)

--

create table dbo.Ingredient(
    IngredientID int not null identity primary key,
    IngredientName varchar(40) not null 
        constraint ck_Ingredient_IngredientName_cannot_be_blank check(IngredientName > '')
        constraint u_Ingredient_IngredientName_must_be unique,
    IngredientPicture as concat('Ingredient-',translate(IngredientName,' ','-') ,'.jpg') persisted
)   


create table dbo.Recipe(
    RecipeID int not null identity primary key,
    UsersID int not null constraint f_Users_Recipe foreign key references Users(UsersID),
    CuisineID int not null constraint f_Cuisine_Recipe foreign key references Cuisine(CuisineID),
    RecipeName varchar(50) not null 
        constraint ck_Recipe_RecipeName_cannot_be_blank check(RecipeName > '')
        constraint u_Recipe_RecipeName_must_be unique,
    Calories int not null constraint ck_Recipe_Calories_cannot_be_negative check (Calories >= 0), --Some candies are 0 calorie
    DateDrafted datetime not null default(getdate()) --I used datetime in order to get a accurate amount of hours in draft needed in the Maintenance Tasks email
        constraint ck_Recipe_DateDrafted_cannot_be_in_future check (DateDrafted  <=  dateadd(minute, 3, getdate())), -- to of exact number caused issues
    DatePublished date null,
    DateArchived date null,
    RecipeStatus as case 
        when DatePublished is null and DateArchived is null then 'Draft'
        when DateArchived is not null then 'Archived'
        else 'Published' end persisted,  
    RecipePic as (concat('Recipe-',translate(RecipeName,' ','-'),'.jpg')) persisted,
    constraint ck_Recipe_DatePublished_and_DateArchived_cannot_be_before_DateDrafted check(cast(DateDrafted as date) <= DatePublished and cast(DateDrafted as date) <= DateArchived),
    constraint ck_Recipe_DatePublished_must_be_before_DateArchived check (DatePublished <= DateArchived)
    --I had to cast to date in case I draft a order 7am and try to publish it the same day
)  
go
alter table Recipe add isVegan bit not null default 0

create table dbo.Directions(
    DirectionsID int not null identity primary key,
    RecipeID int not null constraint f_Recipe_Directions foreign key references Recipe(RecipeID),
    Steps varchar(100) not null constraint ck_Directions_Steps_cannot_be_blank check(Steps > ''), 
    StepsSeq int not null constraint ck_Directions_StepsSeq_must_be_greater_then_0 check(StepsSeq > 0),
    constraint u_Directions_RecipeID_StepsSeq unique(RecipeID,StepsSeq) 
)


create table dbo.MeasuringUnit(
    MeasuringUnitID int not null identity primary key,
    Unit varchar(12) not null 
        constraint ck_MeasuringUnit_Unit_cannot_be_blank check(Unit > '') 
        constraint u_MeasuringUnit_Unit unique
)

 
create table dbo.RecipeIngredient(
    RecipeIngredientID int not null identity primary key,
    RecipeID int not null constraint f_Recipe_RecipeIngredient foreign key references Recipe(RecipeID),
    IngredientID int not null constraint f_IngredientID_RecipeIngredient foreign key references Ingredient(IngredientID),
    MeasuringUnitID int null constraint f_MeasuringUnit_RecipeIngredient foreign key references MeasuringUnit(MeasuringUnitID),
    Amount decimal(4,2) not null constraint ck_RecipeIngredient_Amount_must_be_greater_then_0 check(Amount > 0),
    IngredientSeq int not null constraint ck_RecipeIngredient_IngredientSeq_must_be_greater_then_0 check(IngredientSeq > 0),
-- I was debating if it can have the same ingredeint twice, once for the main part and once for the sauce
-- SM In the begining I also thought that, but afterwards I realized that when looking on ingredients you'd have everything once, and in the directions it's split.
    constraint u_RecipeIngredient_RecipeID_and_IngredientID unique(RecipeID, IngredientID),
    constraint u_RecipeIngredient_RecipeID_and_IngredientSeq unique(RecipeID, IngredientSeq)
)


create table dbo.Meal(
    MealID int not null identity primary key,
    UsersID int not null constraint f_Users_Meal foreign key references Users(UsersID),
    MealName varchar(30) not null 
        constraint ck_Meal_MealName_cannot_be_blank check(MealName > '') 
        constraint u_Meal_MealName unique,
    DateCreated date not null default getdate()
        constraint ck_Meal_DateCreated_cannot_be_in_the_future check(DateCreated <= getdate()),
    IsActive bit not null default 1,
    MealPic as concat('Meal-',translate(MealName,' ','-'),'.jpg') persisted
)
go
alter table Meal add MealDesc varchar(50) not null default ' '
go 


create table dbo.MealCourse(
    MealCourseID int not null identity primary key,
    MealID int not null constraint f_Meal_MealCourse foreign key references Meal(MealID),
    CourseID int not null constraint f_Course_MealCourse foreign key references Course(CourseID),
    constraint u_MealID_and_CourseID unique(MealID,CourseID)
)    


create table dbo.MealCourseRecipe(
    MealCourseRecipeID int not null identity primary key,
    MealCourseID int not null constraint f_MealCourse_MealCourseRecipe foreign key references MealCourse(MealCourseID),
    RecipeID int not null constraint f_Recipe_MealCourseRecipe foreign key references Recipe(RecipeID),
    IsMain bit not null,
    constraint u_MealCourseID_and_RecipeID unique(MealCourseID,RecipeID)
)


create table dbo.Cookbook(
    CookbookID int not null identity primary key,
    UsersID int not null constraint f_Users_Cookbook foreign key references Users(UsersID),
    BookName varchar(30) not null 
        constraint ck_Cookbook_BookName_cannot_be_blank check(BookName > '')
        constraint u_Cookbook_BookName unique,
    Price decimal(5,2) not null constraint ck_Cookbook_Price_must_be_more_then_0 check(Price > 0),
    DateCreated date not null default getdate()
        constraint ck_Cookbook_DateCreated_cannot_be_in_future check(DateCreated <= getdate()),
    IsActive bit not null default 1,
    CookbookPic as concat('Cookbook-',translate(BookName,' ','-'),'.jpg') persisted
)
go
alter table Cookbook add Skill int constraint ck_Cookbook_Skill_can_only_be_1_to_3 check(Skill between 1 and 3) default 1
go
alter table Cookbook add SkillLevel as case Skill when 1 then 'Beginner' when 2 then 'Intermediate' else 'Advanced' end persisted
go 


create table dbo.CookbookRecipe(
    CookbookRecipeID int not null identity primary key,
    CookbookID int not null constraint f_Cookbook_CookbookRecipe foreign key references Cookbook(CookbookID),
    RecipeID int not null constraint f_Recipe_CookbookRecipe foreign key references Recipe(RecipeID),
    RecipeSeq int not null constraint ck_CookbookRecipe_RecipeSeq_must_be_greater_then_0 check(RecipeSeq > 0),
    constraint u_CookbookID_and_RecipeID unique (CookbookID,RecipeID),
    constraint u_CookbookID_and_RecipeSeq unique(CookbookID,RecipeSeq)
)
