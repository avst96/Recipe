use HeartyHearthDB
go

create or alter proc dbo.RecipeIngredientDelete(
    @RecipeIngredientId int,
    @Message varchar(500) = '' output
)
as
begin

    declare @return int = 0

    select @RecipeIngredientId = isnull(@RecipeIngredientId,0)

    delete RecipeIngredient
    where RecipeIngredientID = @RecipeIngredientId

    return @return
end
go


