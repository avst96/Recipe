use HeartyHearthDB 
go


;with x as(
    select CuisineName = 'French', UsersName = '26@Forever', RecipeName = 'Test Butter Muffins', Calories = 19, DateDrafted = '2023-07-11', DatePublished = null
    union select 'American', 'McFarm', 'Test Cheese Bread', 21, '2023-07-11', null from Users where UserName = 'McFarm'
    union select 'American', 'McFarm', 'Test Apple Yogurt Smoothie', 22, '2023-07-11', '2023-07-11' from Users where UserName = 'McFarm'
)
insert Recipe (UsersID, CuisineID, RecipeName, Calories, DateDrafted, DatePublished)
    select u.UsersID, c.CuisineID, x.RecipeName, x.Calories, x.DateDrafted, x.DatePublished
    from Users u 
    join x
    on u.UserName = x.UsersName
    join Cuisine c 
    on c.CuisineName = x.CuisineName
go


;with x as (
    select 'Test Butter Muffins' as Recipe, 'Cup' as Unit, 'oil' as Ingredient, 2 as IngredientSeq, .5 as Amount
    union select 'Test Butter Muffins', 'Cup', 'sugar', 1, 1
     
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