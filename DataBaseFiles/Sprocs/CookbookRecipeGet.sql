use HeartyHearthDB 
go

create or alter proc dbo.CookbookRecipeGet(
    @CookbookId int,
    @Message varchar(500) = '' output
)
as 
begin
    declare @return int = 0

    select @CookbookId = isnull(@CookbookId,0)

    select cr.RecipeID, cr.RecipeSeq
    from CookbookRecipe cr 
    where cr.CookbookId = @CookbookId
    order by cr.RecipeSeq

    return @return
end

exec CookbookRecipeGet 2


