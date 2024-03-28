-- SM 100%
use HeartyHearthDB 
go
delete CookbookRecipe
delete Cookbook
delete MealCourseRecipe
delete MealCourse
delete Meal
delete RecipeIngredient
delete MeasuringUnit
delete Directions
delete Recipe
delete Ingredient
delete Course
delete Cuisine
delete Users
go


insert Users(FirstName,LastName,UserName)
    select 'Abe','Catomand','Acat'
    union select 'Bertha','McDonald','McFarm'
    union select 'Boruch','Klein', '26@Forever'


insert Cuisine(CuisineName)
    select 'American'
    union select 'French'
    union select 'English'


insert Course(CourseName,CourseSeq)
    select 'Hors-d''oeuvres',1
    union select 'Amuse-bouche',2
    union select 'Appetizer',3
    union select 'Main course',4
    union select 'Palate cleaner',5
    union select 'Dessert',6
    union select 'Mignardise',7


insert Ingredient (IngredientName)
    select 'Sugar'
    union select 'Oil'
    union select 'Egg'
    union select 'Flour'
    union select 'Vanilla Sugar'
    union select 'Baking Powder'
    union select 'Baking Soda'
    union select 'Chocolate Chips'
    union select 'Granny Smith Apple'
    union select 'Vanilla Yogurt'
    union select 'Orange Juice'
    union select 'Honey'
    union select 'Ice Cube'
    union select 'Club Bread'
    union select 'Butter'
    union select 'Shredded Cheese'
    union select 'Garlic (crushed)'
    union select 'Black Pepper'
    union select 'Salt'
    union select 'Vanilla Pudding'
    union select 'Whipped Cream Cheese'
    union select 'Sour Cream'
    


;with x as (
    select 'Acat' as UserName, 'American' as Cuisine, 'Chocolate Chip Cookies' as Recipe, 35 as Calories, null as Published, '2023-3-22' as Archived
    union select 'McFarm', 'French','Apple Yogurt Smoothie', 22, null,null 
    union select '26@forever', 'English', 'Cheese Bread', 29, '2023-3-22', null 
    union select '26@forever', 'American', 'Butter Muffins', 41, '2023-3-22', null 
    
)
    insert Recipe(UsersID,CuisineID,RecipeName,Calories,DateDrafted,DatePublished,DateArchived)
        select u.UsersID, c.CuisineID, x.Recipe, x.Calories,'2023-01-15', x.Published, x.Archived
        from x 
        join Users u 
        on x.UserName = u.UserName
        join Cuisine c 
        on x.Cuisine = c.CuisineName 
    

;with x as (
    select 'Chocolate Chip Cookies' as Recipe, 'First combine sugar, oil and eggs in a bowl' as Steps, 1 as StepsSeq
    union select 'Chocolate Chip Cookies', 'Mix well', 2
    union select 'Chocolate Chip Cookies', 'Add flour, vanilla sugar, baking powder and baking soda', 3
    union select 'Chocolate Chip Cookies', 'Beat for 5 minutes', 4
    union select 'Chocolate Chip Cookies', 'Add chocolate chips',5
    union select 'Chocolate Chip Cookies', 'Freeze for 1-2 hours', 6
    union select 'Chocolate Chip Cookies', 'Roll into balls and place spread out on a cookie sheet', 7
    union select 'Chocolate Chip Cookies', 'Bake on 350 for 10 min', 8
    union select 'Apple Yogurt Smoothie',  'Peel the apples and dice', 1
    union select 'Apple Yogurt Smoothie',  'Combine all ingredients in bowl except for apples and ice cubes',2
    union select 'Apple Yogurt Smoothie',  'Mix until smooth',3
    union select 'Apple Yogurt Smoothie',  'Add apples and ice cubes',4
    union select 'Apple Yogurt Smoothie',  'Pour into glasses',5
    union select 'Cheese Bread', 'Slit bread every 3/4 inch', 1
    union select 'Cheese Bread', 'Combine all ingredients in bowl', 2
    union select 'Cheese Bread', 'Fill slits with cheese mixture', 3
    union select 'Cheese Bread', 'Wrap bread into a foil and bake for 30 minutes', 4
    union select 'Butter Muffins', 'Cream butter with sugars', 1
    union select 'Butter Muffins', 'Add eggs and mix well', 2
    union select 'Butter Muffins', 'Slowly add rest of ingredients and mix well', 3
    union select 'Butter Muffins', 'Fill muffin pans 3/4 full and bake for 30 minutes', 4
)
insert Directions(RecipeID,Steps,StepsSeq)
    select r.RecipeID, x.Steps, x.StepsSeq
    from x
    join Recipe r 
    on x.Recipe = r.RecipeName


insert MeasuringUnit(Unit)
    select 'Cup'
    union select 'Tsp'
    union select 'Tbsp'
    union select 'Oz'
    union select 'Pinch'
    union select 'Stick'
    union select 'Clove'


;with x as (
    select 'Chocolate Chip Cookies' as Recipe, 'Cup' as Unit, 'oil' as Ingredient, 2 as IngredientSeq, .5 as Amount
    union select 'Chocolate Chip Cookies', 'Cup', 'sugar', 1, 1
    union select 'Chocolate Chip Cookies', null, 'Egg', 3, 3
    union select 'Chocolate Chip Cookies', 'Cup', 'Flour', 4, 2
    union select 'Chocolate Chip Cookies', 'tsp', 'vanilla sugar', 5, 1
    union select 'Chocolate Chip Cookies', 'tsp', 'baking powder', 6, 2
    union select 'Chocolate Chip Cookies', 'tsp', 'baking soda', 7, .5
    union select 'Chocolate Chip Cookies', 'cup', 'chocolate chips', 8, 1 
    union select 'Apple Yogurt Smoothie', null, 'granny smith apple', 1, 3
    union select 'Apple Yogurt Smoothie', 'cup', 'vanilla yogurt', 2, 2 
    union select 'Apple Yogurt Smoothie', 'tsp', 'sugar', 3, 2 
    union select 'Apple Yogurt Smoothie', 'cup', 'orange juice', 4, .5
    union select 'Apple Yogurt Smoothie', 'tbsp', 'honey', 5, 2
    union select 'Apple Yogurt Smoothie', null, 'ice cube', 6, 5
    union select 'cheese bread', null, 'club bread', 1, 1
    union select 'cheese bread', 'oz', 'butter', 2, 4
    union select 'cheese bread', 'oz', 'shredded cheese', 3, 8
    union select 'cheese bread', 'Clove', 'Garlic (crushed)', 4, 2
    union select 'cheese bread', 'tsp', 'black pepper', 5, .25
    union select 'cheese bread', 'pinch', 'salt', 6, 1    
    union select 'Butter Muffins', 'stick', 'butter', 1, 1    
    union select 'Butter Muffins', 'cup', 'sugar', 2, 3
    union select 'Butter Muffins', 'tbsp', 'vanilla pudding', 3, 2
    union select 'Butter Muffins', null, 'egg', 4, 4
    union select 'Butter Muffins', 'oz', 'whipped cream cheese', 5, 8
    union select 'Butter Muffins', 'oz', 'sour cream', 6, 8
    union select 'Butter Muffins', 'cup', 'flour', 7, 1
    union select 'Butter Muffins', 'tsp', 'baking powder', 8, 2    
)    
    insert RecipeIngredient(RecipeID,MeasuringUnitID,IngredientID,IngredientSeq,Amount)
        select r.RecipeID, mu.MeasuringUnitID, i.IngredientID, x.IngredientSeq, x.Amount
        from x 
        join Recipe r
        on x.Recipe = r.RecipeName
        left join MeasuringUnit mu 
        on x.Unit = mu.Unit
        join Ingredient i 
        on x.Ingredient = i.IngredientName
        order by r.RecipeID, x.IngredientSeq


;with x as (
    select 'acat' as Users, 'Breakfast bash' as MealName, 1 as Active
    union select 'mcfarm', 'Luncheon', 1
    union select 'mcfarm', 'Super supper', 0
)
    insert Meal (UsersID,MealName,IsActive)
        select u.UsersID, x.MealName, x.Active
        from x 
        join Users u 
        on x.Users = u.UserName


;with x as (
    select 'breakfast bash' as Meal, 'Appetizer' as Course
    union select 'breakfast bash', 'Main course'
    union select 'luncheon', 'Hors-d''oeuvres'
    union select 'luncheon', 'Appetizer'
    union select 'luncheon', 'Main course'
    union select 'Super supper', 'Amuse-bouche'
    union select 'Super supper', 'Main course'
    union select 'Super supper', 'Mignardise'        
)
    insert MealCourse(MealID,CourseID)
        select m.MealID, c.CourseID
        from x 
        join Meal m
        on x.Meal = m.MealName
        join Course c 
        on x.Course = c.CourseName


;with x as (         
    select 'breakfast bash' as Meal, 'Appetizer' as Course, 'Chocolate chip cookies' as recipe, 1 as Main 
    union select 'breakfast bash', 'Main course', 'cheese bread' , 1
    union select 'breakfast bash', 'Main course', 'butter muffins', 0
    union select 'luncheon', 'Hors-d''oeuvres', 'Chocolate chip cookies', 1
    union select 'luncheon', 'Appetizer', 'apple yogurt smoothie', 0
    union select 'luncheon', 'Appetizer', 'butter muffins', 1
    union select 'luncheon', 'Main course', 'cheese bread', 1
    union select 'Super supper', 'Amuse-bouche', 'chocolate chip cookies', 1
    union select 'Super supper', 'Main course', 'butter muffins', 1
    union select 'Super supper', 'Amuse-bouche', 'apple yogurt smoothie', 0     
)
    insert MealCourseRecipe(MealCourseID,RecipeID,IsMain)
        select mc.MealCourseID, r.RecipeID, x.Main
        from x 
        join Meal m 
        on x.Meal = m.MealName
        join Course c 
        on x.Course = c.CourseName
        join MealCourse mc 
        on m.MealID = mc.MealID
            and c.CourseID = mc.CourseID
        join Recipe r 
        on x.recipe = r.RecipeName


;with x as (
    select 'Acat' as Users, 'Treats for two' as bookname, 30 as Price, 1 as active
    union select '26@forever', 'The easy way', 28, 1 
    union select 'Acat', 'Impress', 35, 0
)
    insert Cookbook(UsersID,BookName,Price,IsActive)
        select UsersID , x.bookname, x.Price, x.active
        from x 
        join Users u 
        on x.Users = u.UserName


;with x as (
    select 'Treats for two' as cookbook, 'Chocolate Chip Cookies' as recipe, 1 as Seq 
    union select 'Treats for two', 'Apple Yogurt Smoothie', 2
    union select 'Treats for two', 'Cheese Bread', 3
    union select 'Treats for two', 'Butter Muffins', 4
    union select 'The easy way', 'Butter Muffins', 1
    union select 'The easy way', 'Cheese Bread', 2
    union select 'Impress', 'Apple Yogurt Smoothie', 1
    union select 'Impress', 'Chocolate Chip Cookies', 2
)
    insert CookbookRecipe(CookbookID,RecipeID,RecipeSeq)
        select c.CookbookID, r.RecipeID, x.Seq
        from x 
        join Cookbook c 
        on x.cookbook = c.BookName
        join Recipe r 
        on x.recipe = r.RecipeName


--------------------Added info for new columns-------------------------------------
        
insert Ingredient (IngredientName)
select 'Nuts'

;with x as (
    select 'Acat' as UserName, 'French' as Cuisine, 'Nutty Nuts' as Recipe, 41 as Calories, null as Published, '2023-3-22' as Archived, 1 as isVegan
       
)
    insert Recipe(UsersID,CuisineID,RecipeName,Calories,DateDrafted,DatePublished,DateArchived, isVegan)
        select u.UsersID, c.CuisineID, x.Recipe, x.Calories,'2023-01-15', x.Published, x.Archived, x.isVegan
        from x 
        join Users u 
        on x.UserName = u.UserName
        join Cuisine c 
        on x.Cuisine = c.CuisineName 
    
    ;with x as (
    select 'Nutty Nuts' as Recipe, 'Melt sugar over low flame' as Steps, 1 as StepsSeq
    union select 'Nutty Nuts' as Recipe, 'Mix in nuts' as Steps, 2 as StepsSeq
    union select 'Nutty Nuts' as Recipe, 'Cool, and enjoy' as Steps, 3 as StepsSeq
    
)
insert Directions(RecipeID,Steps,StepsSeq)
    select r.RecipeID, x.Steps, x.StepsSeq
    from x
    join Recipe r 
    on x.Recipe = r.RecipeName

    ;with x as (
    select 'Nutty Nuts' as Recipe, 'Cup' as Unit, 'Sugar' as Ingredient, 2 as IngredientSeq, 2 as Amount
    union select 'Nutty Nuts', 'Cup', 'Nuts', 1, 2
)    
    insert RecipeIngredient(RecipeID,MeasuringUnitID,IngredientID,IngredientSeq,Amount)
        select r.RecipeID, mu.MeasuringUnitID, i.IngredientID, x.IngredientSeq, x.Amount
        from x 
        join Recipe r
        on x.Recipe = r.RecipeName
        left join MeasuringUnit mu 
        on x.Unit = mu.Unit
        join Ingredient i 
        on x.Ingredient = i.IngredientName
        order by r.RecipeID, x.IngredientSeq

;with x as (
    select  'Breakfast bash' as MealName, 'Morning meal is the most important of the day!' as MealDesc
    union select  'Luncheon', 'Keep it to one healthy meal.'
    union select  'Super supper', 'The main meal for the western wolrd.'
)
update m
set m.MealDesc = x.MealDesc
from Meal m 
join x
on x.MealName = m.MealName


;with x as (
   select 'Treats for two' as bookname, 2 as Skill
)
update c
set c.Skill = x.Skill
from Cookbook c 
join x on c.BookName = x.bookname
