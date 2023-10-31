use HeartyHearthDB
go

create or alter proc dbo.RecipeIngredientUpdate (
	@RecipeIngredientId int output,
	@RecipeId int,
	@IngredientId int,
	@MeasuringUnitId int ,
	@Amount decimal (4,2),
	@IngredientSeq int,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0
	select @RecipeIngredientId = isnull(@RecipeIngredientId,0), @MeasuringUnitId = nullif(@MeasuringUnitId,0)

	if(@RecipeIngredientId = 0)
		begin
			insert RecipeIngredient (RecipeID,IngredientID,MeasuringUnitID,Amount,IngredientSeq)
				values (@RecipeId, @IngredientId, @MeasuringUnitId, @Amount, @IngredientSeq)

		select @RecipeIngredientId = scope_Identity()

	end

	else 
		begin
		update ri 
		set 
		IngredientID = @IngredientId, 
		MeasuringUnitID = @MeasuringUnitId, 
		Amount = @Amount,
		IngredientSeq = @IngredientSeq
		from RecipeIngredient ri
		where ri.RecipeIngredientID = @RecipeIngredientId
	end


	return @return
end
go 


