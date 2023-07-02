/*

Users
    UsersID PK,
    FirstName varchar(35) not null not blank,
    LastName varchar(35) not null not blank,
    UserName varchar(20) not null not blank unique


Cuisine 
    CuisineID PK,
    CuisineName varchar(20) not null not blank unique,
    

Course
    CourseID PK,
    CourseName varchar(20) not null not blank unique,
    CourseSeq int not null > 0 unique,
    


Ingredient
    IngredientID PK,
    IngredientName varchar(20) not null not blank unique
    IngredientPicture compute Tablename-IngredientName-.jpg
    

Recipe 
    RecipeID PK,
    RecipeName varchar(35) not null not blank unique,
    UsersID FK,
    CuisineID FK,
    Calories int not null > 0
    DateDrafted date not null default(getdate()),
    DatePublished date null not in the future,
    DateArchived date null not in the future,
    Status as when DatePublished and DateArchived null = Draft
        when DatePublished not null and DateArchived null = Published
        when (else) DateArchived not null = Archived
    RecipePic = compute tablename-recipename-.jpg
    
    
Directions
    DirectionsID PK,
    RecipeID FK,
    Steps varchar(50) not null not blank, 
    StepsSeq int not null > 0,
    constraint RecipeID, StepsSeq 
    

MeasuringUnit
    MeasuringUnitID PK,
    UnitName varchar(12) not null not blank unique


RecipeIngredient
    RecipeIngredientID PK,
    RecipeID FK,
    IngredientID FK,
    Amount decimal(4,2) not null not blank > 0,
    MeasuringUnitID FK,
    IngredientSequence int not null > 0
    constraint RecipeID and IngredientSequence unique


Meal 
    MealID PK,
    MealName varchar(30) not null not blank unique,
    DateCreated date not null default getdate()
    Active bit not null
    UsersID FK
    MealPic = compute tablename-mealname-.jpg


MealCourse
    MealCourseID PK,
    MealID FK,
    CourseID FK,
    constraint MealID, CourseID unique
    

MealCourseRecipe
    MealCourseRecipeID PK,
    MealCourseID FK,
    RecipeID FK,
    IsMain bit not null,
    constraint MealCourseID and RecipeID unique


Cookbook unique
    CookbookID PK,
    Name varchar(30) not null not blank unique
    Price decimal(5,2) not null > 0,
    UsersID FK,
    DateCreated date not null default getdate()
    Active bit not null,
    CookbookPicture compute Tablename-IngredientName-.jpg


CookbookRecipe
    CookbookRecipeID PK,
    CookbookID FK,
    RecipeID FK,
    RecipeSeq int not null > 0,
    constraint CookbookID, RecipeID unique,
    constraint CookbookID, RecipeSeq unique
