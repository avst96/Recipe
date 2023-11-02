use HeartyHearthDB
go 


create or alter proc dbo.CookbookSummaryGet(
    @Message varchar (500) = '' output
)

as
begin
    declare @return int = 0

    select c.BookName as Cookbook_Name, concat(u.FirstName, ' ', u.LastName) as Author, count(cr.RecipeID)as Num_Recipes, c.Price
    from Cookbook c 
    join Users u
    on c.UsersID = u.UsersID
    left join CookbookRecipe cr 
    on c.CookbookID = cr.CookbookID
    group by c.BookName, u.FirstName, u.LastName, c.Price
    order by c.BookName


    return @return
end
go



exec CookbookSummaryGet

