-- SM Excellent! WOW! 100% 


use HeartyHearthDB 
go 

-- Home Page One resultset with number of recipes, meals, and cookbooks

select count(distinct r.RecipeID) as Recipies, count(distinct m.MealID) as Meals, count(distinct c.CookbookID) as Cookbooks
from Recipe r 
cross join Meal m 
cross join Cookbook c


/*
Recipe list page:
    List of all Recipes that are either published or archived, published recipes should appear at the top. 
    In the resultset show the Recipe name with its status, dates it was published and archived (blank if not archived), user, number of calories and number of ingredients.
	The recipe names of archived recipes should be displayed in gray on the website. In order to do that, the recipe names of archived recipes should be prefixed with <span style="color:gray"> and followed with </span>
	Ex: Recipe name of archived Chocolate Chip Cookies should be <span style="color:gray">Chocolate Chip Cookies</span>
*/
select case r.RecipeStatus
    when 'archived' then concat('<span style="color:gray">',r.RecipeName,'</span>')
    else r.RecipeName
    end as RecipeName, 
    r.RecipeStatus, 
    isnull(convert(varchar,r.DatePublished),'') as DatePublished, 
    isnull(convert(varchar,r.DateArchived), '') as DateArchived,
    u.UserName,
    r.Calories,
    count(*) as NumOfIngredient, 
    r.RecipePic
from Recipe r 
join Users u 
on r.UsersID = u.UsersID
join RecipeIngredient ri 
on r.RecipeID = ri.RecipeID
where r.RecipeStatus in ('published','archived')
group by r.RecipeName, r.RecipeStatus, u.UserName, r.Calories, DatePublished, DateArchived, r.RecipePic
order by r.RecipeStatus desc


--Recipe details page:
--a) Recipe header: recipe name, number of calories, number of ingredients and number of steps.
select r.RecipeName, r.Calories, count(distinct ri.IngredientID) as NumOfIngredient, count(distinct d.DirectionsID) as NumOfSteps, r.RecipePic
from Recipe r 
join RecipeIngredient ri 
on r.RecipeID = ri.RecipeID
join Directions d 
on r.RecipeID = d.RecipeID
where r.RecipeName = 'Chocolate chip cookies'
group by r.RecipeName, r.Calories, r.RecipePic

--b) List of ingredients: show the measurement type and ingredient in one column, sorted by sequence. Ex. 1 Teaspoon Salt  
select concat(ri.Amount,' ',isnull(mu.Unit + ' ',''),i.IngredientName) as ListOfIngredients, i.IngredientPicture
from Recipe r 
join RecipeIngredient ri 
on r.RecipeID = ri.RecipeID
join Ingredient i 
on ri.IngredientID = i.IngredientID 
left join MeasuringUnit mu 
on ri.MeasuringUnitID = mu.MeasuringUnitID
where r.RecipeName = 'Chocolate chip cookies'
order by ri.IngredientSeq

--c) List of prep steps sorted by sequence.
select d.Steps
from Recipe r 
join Directions d 
on r.RecipeID = d.RecipeID
where r.RecipeName = 'Chocolate chip cookies'
order by d.StepsSeq


--Meal list page:
  --  All active meals, meal name, user that created meal, number of calories for the meal, number of courses, and number of recipes per each meal, sorted by name of meal
select m.MealName, u.UserName, sum(r.calories) as TotalCalories, count(distinct mc.CourseID) as NumOfCourses, count(mcr.RecipeID) as NumOfRecipes, m.MealPic
from Meal m 
join Users u 
on m.UsersID = u.UsersID
join MealCourse mc 
on m.MealID = mc.MealID
join MealCourseRecipe mcr 
on mc.MealCourseID = mcr.MealCourseID
join Recipe r 
on mcr.RecipeID = r.RecipeID
where m.IsActive = 1
group by m.MealName, u.UserName, m.MealPic
order by m.MealName


-- Meal details page:
    -- Show for a specific meal:
    -- a) Meal header: meal name, user, date created.
select m.MealName, u.UserName, m.DateCreated, m.MealPic
from Meal m
join Users u 
on m.UsersID = u.UsersID
where m.MealName = 'breakfast bash'


/*
b) List of all recipes. 
    Display in one column the course type, recipe, and for the main course show which dish is the main and which are side. 
	In this format "Course Type: Main\Side dish - Recipe Name. Then main dishes should be bold, using the bold tags as shown below
    ex: 
    Appetizer: Mixed Greens
    <b>Main: Main dish - Onion Pastrami Chicken</b>
	Main: Side dish - Roasted cucumbers with mustard
*/
select case 
    when c.CourseName = 'Main course' and mcr.IsMain = 1 then concat('<b>',c.CourseName,': Main dish - ',r.RecipeName,'</b>')
    when c.CourseName = 'Main course' and mcr.IsMain = 0 then concat(c.CourseName,': Side dish - ',r.RecipeName)    
    else concat(c.CourseName,': ', r.RecipeName) 
    end as RecipesInTheMeal, 
    r.RecipePic
from MealCourseRecipe mcr
join Recipe r
on mcr.RecipeID = r.RecipeID
join MealCourse mc 
on mcr.MealCourseID =mc.MealCourseID
join Course c 
on mc.CourseID = c.CourseID
join Meal m
on mc.MealID = m.MealID
where m.MealName = 'breakfast bash'


--Cookbook list page:
--    Show all active cookbooks with author and number of recipes per book. Sorted by book name.
select c.BookName, concat(u.FirstName,' ',u.LastName) as Author, count(*) as NumOfRecipes, c.CookbookPic
from CookbookRecipe cr 
join Cookbook c 
on cr.CookbookID = c.CookbookID
join Users u 
on c.UsersID = u.UsersID
where c.IsActive = 1
group by c.BookName, concat(u.FirstName,' ',u.LastName), c.CookbookPic
order by c.BookName


--Cookbook details page:
--    Show for specific cookbook:
--    a) Cookbook header: cookbook name, user, date created, price, number of recipes.
select c.BookName, u.UserName, c.DateCreated, c.Price, count(*) as NumOfRecipes, c.CookbookPic 
from Cookbook c 
join Users u 
on c.UsersID = u.UsersID
join CookbookRecipe cr 
on c.CookbookID = cr.CookbookID 
where c.BookName = 'the easy way'
group by c.BookName, u.UserName, c.DateCreated, c.Price, c.CookbookPic

--    b) List of all recipes in the correct order. Include recipe name, cuisine and number of ingredients and steps.  Note: User will click on recipe to see all ingredients and steps.
select r.RecipeName, cu.CuisineName, count(distinct ri.IngredientID) as NumOfIngredients, count(distinct d.Steps) as NumOfSteps, r.RecipePic
from CookbookRecipe cr 
join Cookbook c 
on cr.CookbookID = c.CookbookID
join Recipe r 
on cr.RecipeID = r.RecipeID
join Cuisine cu
on r.CuisineID = cu.CuisineID
join RecipeIngredient ri 
on r.RecipeID = ri.RecipeID
join Directions d 
on r.RecipeID = d.RecipeID
where c.BookName = 'The easy way'
group by r.RecipeName, cu.CuisineName, cr.RecipeSeq, r.RecipePic
order by cr.RecipeSeq


--April Fools Page:
--On April 1st we have a page with a joke cookbook. For that page provide the following.
--a) A list of all the recipes that are in all cookbooks. The recipe name should be the reverse of the real name proper cased. There are matching pictures for those names, include the reversed picture names so that we can show the joke pictures.
select distinct concat(
    upper(left(reverse(r.RecipeName),1)),
    substring(lower(reverse(r.RecipeName)),2,len(r.RecipeName)))
    as AprilFoolRecipe, 
    translate(concat(
        upper(left(reverse(r.RecipeName),1)),--I used the name since it will always match the picture and will save me from having to remove the .jpg at this step 
        lower(substring(reverse(r.RecipeName),2,len(r.RecipeName))),'.jpg'),' ','-') 
    as AprilFoolPicture
from CookbookRecipe cr 
join Recipe r 
on cr.RecipeID = r.RecipeID 

--b) When the user clicks on a specific recipe they should see a list of the first ingredient of each recipe in the system, and a list of the last step in each recipe in the system
;with x as (
    select max(StepsSeq) as LastStep, d.RecipeID
    from Directions d 
    group by d.RecipeID
    )
select distinct i.IngredientName, d.Steps
from RecipeIngredient ri 
join x 
on ri.RecipeID = x.RecipeID
join Directions d 
on x.LastStep = d.StepsSeq
    and ri.RecipeID = d.RecipeID
join Ingredient i 
on ri.IngredientID = i.IngredientID
where ri.IngredientSeq = 1
    

-- For site administration page:
--5 seperate reports
    -- a) List of how many recipes each user created per status. Show 0 if none
select u.UserName, isnull(r.RecipeStatus,'') as RecipeStatus , count(r.RecipeID) as NumberOfRecipes -- is null in case user has no recipes
from Users u 
left join Recipe r 
on u.UsersID = r.UsersID
group by u.UserName, r.RecipeStatus

	-- b) List of how many recipes each user created and average amount of days that it took for the user's recipes to be published.
select u.UserName, count(*) as RecipesCreated, isnull(convert(varchar,avg(datediff(day,r.DateDrafted,r.DatePublished))),'No published recipes') as AvgDaysToPublish 
from Users u 
join Recipe r 
on r.UsersID = u.UsersID 
group by u.UserName

    -- c) List of how many meals each user created and whether they're active or inactive. Show 0 if none
select u.UserName, 
    case m.IsActive
    when 1 then 'Active'
    when 0 then 'Inactive' 
    else 'N/A'
    end as Active
    , count(m.MealID) as NumOfMeals
from Users u 
left join Meal m 
on u.UsersID = m.UsersID
group by u.UserName, m.IsActive

    -- d) List of how many cookbooks each user created and whether they're active or inactive. Show 0 if none
select u.UserName,
    case c.IsActive
    when 1 then 'Active'
    when 0 then 'Inactive' 
    else 'N/A'
    end as Active,
    count(c.CookbookID) as CookbooksAuthored
from Users u 
left join Cookbook c 
on u.UsersID = c.UsersID
group by u.UserName, c.IsActive

    -- e) List of archived recipes that were never published, and how long it took for them to be archived.
select r.RecipeName, datediff(day,r.DateDrafted,r.DateArchived) as DaysCountToArchived, r.RecipePic
from Recipe r 
where r.DatePublished is null
    and r.DateArchived is not null 

 
-- For user dashboard page:
    -- a) Show number of the user's recipes, meals and cookbooks. 
select u.UserName, count(distinct r.RecipeID) as NumOfRecipes, count(distinct m.MealID) as NumOfMeals, count(distinct c.CookbookID) as NumOfCookbooks
from Users u 
left join Recipe r 
on u.UsersID = r.UsersID
left join Meal m
on u.UsersID = m.UsersID
left join Cookbook c 
on u.UsersID = c.UsersID
where u.UserName = '26@forever'
group by u.UserName

    -- b) List of their recipes, display the status and the number of hours between the status it's in and the one before that. Show null if recipe has the status drafted.
select u.UserName, r.RecipeName, 
    r.RecipeStatus, 
    datediff(hour,
    case
    when r.RecipeStatus = 'published' or (r.RecipeStatus = 'archived' and r.DatePublished is null) then r.DateDrafted
    else r.DatePublished
    end, 
    case
    when r.RecipeStatus = 'published' then r.DatePublished
    else r.DateArchived
    end
    ) as HoursInPreviousStatus
from Users u 
join Recipe r 
on u.UsersID = r.UsersID
where u.UserName = '26@forever'

    -- c) Count of their recipes per cuisine. Show 0 for none.
select u.UserName, isnull(c.CuisineName,'') as CuisineName, count(r.RecipeID) as NumOfRecipes
from Users u 
left join Recipe r 
on u.UsersID = r.UsersID 
left join Cuisine c 
on r.CuisineID = c.CuisineID
where u.UserName = '26@forever'
group by u.UserName, c.CuisineName
