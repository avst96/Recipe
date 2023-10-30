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
--fix from here
as
begin
	declare @return int = 0
	select @RecipeIngredientId = isnull(@RecipeIngredientId,0), @RecipeId = isnull(@RecipeId,0), @IngredientId = (@IngredientId,0), @me

	if(@RecipeId = 0)
	begin
		insert Recipe (UsersId, CuisineId, RecipeName, Calories )
			values (@UsersId, @CuisineId, @RecipeName, @Calories)

	select @RecipeId = scope_Identity()

	
	end

	else
	begin
	update r 
	set 
	UsersId = @UsersId, 
	CuisineId = @CuisineId, 
	RecipeName = @RecipeName, 
	Calories = @Calories 
	from recipe r
	where r.RecipeId = @RecipeId
	end


	select 
		@DateDrafted = r.DateDrafted,
		@DatePublished = r.DatePublished,
		@DateArchived = r.DateArchived,
		@RecipeStatus = r.RecipeStatus
	from Recipe r
	where r.RecipeID = @RecipeId


	return @return
end
go 