use HeartyHearthDB
go


create or alter proc dbo.CookbookRecipeDelete(
    @CookbookRecipeId int,
    @Message varchar(500) = '' output
)
as
begin
    declare @return int = 0
    select @CookbookRecipeId = isnull(@CookbookRecipeId,0)

    delete CookbookRecipe 
    where CookbookRecipeID = @CookbookRecipeId

    return @return
end
go

