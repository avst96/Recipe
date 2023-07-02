-- SM Excellent! 100%
use HeartyHearthDB
go
--Note: some of these scripts are needed for specific items, when the instructions say "specific" pick one item in your data and specify it in the where clause using a unique value that identifies it, do not use the primary key.

--1) Sometimes when a staff member is fired. We need to eradicate everything from that user in our system. Write the SQL to delete a specific user and all the user's related records.
delete mcr
--select *
from Users u  
join Meal m 
on u.UsersID = m.UsersID
join MealCourse mc 
on m.MealID = mc.MealID
join MealCourseRecipe mcr 
on mc.MealCourseID = mcr.MealCourseID
where u.UserName = 'acat'

delete mc
--select *
from Users u  
join Meal m 
on u.UsersID = m.UsersID
join MealCourse mc 
on m.MealID = mc.MealID
where u.UserName = 'acat'

delete m
--select *
from Users u  
join Meal m 
on u.UsersID = m.UsersID
where u.UserName = 'acat'

delete d
--select *
from Users u 
join Recipe r 
on u.UsersID = r.UsersID
join Directions d 
on r.RecipeID = d.RecipeID
where u.UserName = 'acat'

delete ri
--select *
from Users u 
join Recipe r 
on u.UsersID = r.UsersID
join RecipeIngredient ri 
on r.RecipeID = ri.RecipeID
where u.UserName = 'acat'

delete mcr 
--select *
from Users u 
join Recipe r 
on u.UsersID = r.UsersID
join MealCourseRecipe mcr 
on r.RecipeID = mcr.RecipeID
where u.UserName = 'acat'

delete cr 
--select *
from Users u 
join Recipe r 
on u.UsersID = r.UsersID
join CookbookRecipe cr 
on r.RecipeID = cr.RecipeID
where u.UserName = 'acat'

delete r 
--select *
from Users u 
join Recipe r 
on u.UsersID = r.UsersID
where u.UserName = 'acat'

delete cr
--select *
from Users u
join Cookbook c 
on u.UsersID = c.UsersID 
join CookbookRecipe cr 
on c.CookbookID = cr.CookbookID 
where u.UserName = 'acat'

delete c
--select *
from Users u
join Cookbook c 
on u.UsersID = c.UsersID  
where u.UserName = 'acat'

delete u
--select *
from Users u  
where u.UserName = 'acat'

--2) Sometimes we want to clone a recipe as a starting point and then edit it. For example we have a complex recipe (steps and ingredients) and want to make a modified version. Write the SQL that clones a specific recipe, add " - clone" to its name.
insert Recipe (UsersID,CuisineID,RecipeName,Calories)
    select r.UsersID, r.CuisineID, r.RecipeName + ' - clone', r.Calories 
    from Recipe r 
    where r.RecipeName = 'butter muffins'

;with x as (
    select r.RecipeID
    from Recipe r 
    where r.RecipeName = 'butter muffins - clone'
)
    insert Directions (RecipeID,Steps,StepsSeq)
        select x.RecipeID, d.Steps, d.StepsSeq
        from Directions d 
        join Recipe r 
        on d.RecipeID = r.RecipeID
        cross join x 
        where r.RecipeName = 'butter muffins'
        

;with x as (
    select r.RecipeID
    from Recipe r 
    where r.RecipeName = 'butter muffins - clone'
)
    insert RecipeIngredient (RecipeID,IngredientID,MeasuringUnitID,IngredientSeq,Amount)
        select x.RecipeID,ri.IngredientID,ri.MeasuringUnitID,ri.IngredientSeq,ri.Amount
        from RecipeIngredient ri 
        join Recipe r 
        on ri.RecipeID = r.RecipeID
        cross join x
        where r.RecipeName = 'butter muffins'
        

/*
3) We offer users an option to auto-create a recipe book containing all of their recipes. 
Write a SQL script that creates the book for a specific user and fills it with their recipes.
The name of the book should be Recipes by Firstname Lastname. 
The price should be the number of recipes multiplied by $1.33
Sequence the book by recipe name.

Tip: To get a unique sequential number for each row in the result set use the ROW_NUMBER() function. See Microsoft Docs.
	 The following can be a column in your select statement: Sequence = ROW_NUMBER() over (order by colum name) , replace column name with the name of the column that the row number should be sorted
*/
insert Cookbook(BookName,IsActive,Price,UsersID)
    select concat('Recipes by ',u.FirstName,' ',u.LastName),1,count(r.RecipeID) * 1.33, u.UsersID
    from Users u 
    join Recipe r 
    on u.UsersID = r.UsersID
    where u.UserName = '26@forever'
    group by u.FirstName, u.LastName,  u.UsersID

insert CookbookRecipe(CookbookID,RecipeID,RecipeSeq)
    select c.CookbookID, r.RecipeID, row_number() over (order by r.RecipeName)
    from Users u 
    join Cookbook c 
    on u.UsersID = c.UsersID
    join Recipe r 
    on u.UsersID = r.UsersID
    where u.UserName = '26@forever'
        and c.BookName = 'Recipes by Boruch Klein'

/*
4) Sometimes the calorie count of of an ingredient changes and we need to change the calorie total for all recipes that use that ingredient.
Our staff nutritionist will specify the amount to change per measurement type, and of course multiply the amount by the quantity of the ingredient.
For example, the calorie count for butter went down by 2 per ounce, and 10 per stick of butter. 
Write an update statement that changes the number of calories of a recipe for a specific ingredient. 
The statement should include at least two measurement types, like the example above. 
*/
update r 
set r.Calories = case mu.Unit 
    when 'stick' then r.Calories - (10 * ri.Amount)
    when 'oz' then r.Calories - (2 * ri.Amount)
    else r.Calories
    end
--select r.Calories, r.RecipeName
from Recipe r 
join RecipeIngredient ri 
on r.RecipeID = ri.RecipeID
join Ingredient i 
on ri.IngredientID = i.IngredientID
join MeasuringUnit mu 
on ri.MeasuringUnitID = mu.MeasuringUnitID
where i.IngredientName = 'butter'

/*
5) We need to send out alerts to users that have recipes sitting in draft longer the average amount of time that recipes have taken to be published.
Produce a result set that has 4 columns (Data values in brackets should be replaced with actual data)
	User First Name, 
	User Last Name, 
	email address (first initial + lastname@heartyhearth.com),
	Alert: 
		Your recipe [recipe name] is sitting in draft for [X] hours.
		That is [Z] hours more than the average [Y] hours all other recipes took to be published.
*/
;with x as (
    select avg(datediff(hour,r.DateDrafted,r.DatePublished)) as AvgHoursPublished
    from Recipe r 
)
    select u.FirstName, 
        u.LastName, 
        concat(left(u.FirstName,1),u.LastName,'@heartyhealth.com') as Email, 
        concat('Your recipe ',r.RecipeName,' is sitting in draft for ', datediff(hour,r.DateDrafted,getdate()),' hours. That is ',datediff(hour,r.DateDrafted,getdate()) - x.AvgHoursPublished,' hours more than the average ',x.AvgHoursPublished,' hours all other recipes took to be published') as Alert
    from Users u 
    join Recipe r 
    on u.UsersID = r.UsersID
    cross join x 
    where datediff(hour,r.DateDrafted,getdate()) > x.AvgHoursPublished
        and r.RecipeStatus = 'draft'


/*
6) We want to send out marketing emails for books. Produce a result set with one row and one column "Email Body" as specified below.
The email should have a unique guid link to follow, which should be shown in the format specified. 

Email Body:
Order cookbooks from HeartyHearth.com! We have [X] books for sale, average price is [Y]. You can order them all and recieve a 25% discount, for a total of [Z].
Click <a href = "www.heartyhearth.com/order/[GUID]">here</a> to order.
*/
select concat('Order cookbooks from HeartyHealth.com! We have ',count(c.CookbookID),' books for sale, average price is ', format(avg(c.Price),'c','en-us'),
    '. You can order them all and recieve a 25% discount, for a total of ', format(avg(c.Price) * .75,'c','en-us'),'. Click <a href = "www.heartyhealth.com/order/',newid(),
    '">here</a> to order.') as MarketingEmail
from Cookbook c 