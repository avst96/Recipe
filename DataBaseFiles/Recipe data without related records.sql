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


