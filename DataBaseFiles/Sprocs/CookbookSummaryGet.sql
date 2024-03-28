use HeartyHearthDB
go 


create or alter proc dbo.CookbookSummaryGet(
    @All bit = 0,
    @CookbookSummaryId int = 0,
    @Message varchar (500) = '' output
)

as
begin
    select @CookbookSummaryId = isnull(@CookbookSummaryId, 0), @All = isnull(@All, 0)
    declare @return int = 0

    select c.CookbookID, c.BookName as Cookbook_Name, concat(u.FirstName, ' ', u.LastName) as Author, count(cr.RecipeID)as Num_Recipes, c.Price, c.SkillLevel
    from Cookbook c 
    join Users u
    on c.UsersID = u.UsersID
    left join CookbookRecipe cr 
    on c.CookbookID = cr.CookbookID
    where c.CookbookID = @CookbookSummaryId or @All = 1
    group by c.CookbookID, c.BookName, u.FirstName, u.LastName, c.Price, c.SkillLevel
    order by c.BookName


    return @return
end
go





