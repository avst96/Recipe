use HeartyHearthDB
go

create or alter proc dbo.RecipeIngredientGet(
    @RecipeId int,
    @Message varchar(500) = '' output
)
as 
begin
    declare @return int = 0
        select ri.RecipeIngredientID, ri.IngredientID, ri.MeasuringUnitID, ri.Amount, ri.IngredientSeq
        from RecipeIngredient ri 
        where ri.RecipeID = @RecipeId
        order by ri.IngredientSeq
    return @return
end
go

/*
declare @ID int
select top 1 @ID = r.RecipeID from Recipe r where r.DatePublished is not null


exec RecipeIngredientGet @RecipeId = @ID
*/

