use HeartyHearthDB
go

create or alter proc dbo.RecipeUpdate (
	@RecipeId int output,
	@UsersId int,
	@CuisineId int,
	@RecipeName varchar (50),
	@Calories int ,
	@RecipeStatus varchar(9) = '' output ,
	@isVegan bit ,
	@DateDrafted datetime output,
	@DatePublished date output,
	@DateArchived date output,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0
	select @RecipeId = isnull(@RecipeId,0)

	if(@RecipeId = 0)
	begin
		insert Recipe (UsersId, CuisineId, RecipeName, Calories, DateDrafted, DatePublished, DateArchived, isVegan )
			values (@UsersId, @CuisineId, @RecipeName, @Calories, @DateDrafted, @DatePublished, @DateArchived, @isVegan)

	select @RecipeId = scope_Identity()

	end

	else
	begin
		update r 
		set 
			UsersId = @UsersId, 
			CuisineId = @CuisineId, 
			RecipeName = @RecipeName, 
			Calories = @Calories ,
			DateDrafted = @DateDrafted,
			DatePublished = @DatePublished,
			DateArchived = @DateArchived,
			isVegan = @isVegan	
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