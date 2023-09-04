use HeartyHearthDB
go

create or alter proc dbo.RecipeUpdate (
	@RecipeId int output,
	@UsersId int,
	@CuisineId int,
	@RecipeName varchar (50),
	@Calories int,
	--@Message varchar(500) = '' output
	)
as
begin
	--declare @return = int 0
	select @RecipeId = isnull(@RecipeId,0)

	if(@RecipeId = 0)
	begin
		insert UsersId, CuisineId, RecipeName, Calories
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
	Calories = @Calories, 
	from recipe r
	where r.RecipeId = @RecipeId
end
go 