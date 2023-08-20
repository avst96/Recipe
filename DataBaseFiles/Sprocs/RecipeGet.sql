use HeartyHearthDB
go

create or alter procedure dbo.RecipeGet (@RecipeId int = 0, @RecipeName varchar(50) = '', @All bit = 0)
as 
begin
	select @RecipeName = nullif (@RecipeName, '')
	
	select r.RecipeID, r.UsersID, r.CuisineID, r.RecipeName, r.Calories, r.DateDrafted, r.DatePublished, r.DateArchived, r.RecipeStatus, r.RecipePic
	from Recipe r
	where r.RecipeID = @RecipeId
	or r.RecipeName like '%' + @RecipeName + '%'
	or @All = 1
end
go

/*
exec RecipeGet --Returns empty result set

exec RecipeGet @All = 1

declare @ID int 
select top 1 @ID = RecipeID from Recipe order by RecipeID
exec RecipeGet @RecipeId = @ID

exec RecipeGet @RecipeName = ''

exec RecipeGet @RecipeName = 'mu'

exec RecipeGet @RecipeName = null
*/

