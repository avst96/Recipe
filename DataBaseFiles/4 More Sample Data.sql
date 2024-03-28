use HeartyHearthDB
go
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

