use HeartyHearthDB
go

create or alter procedure dbo.RecipeGet (
	@RecipeId int = 0,
	@RecipeName varchar(50) = '', 
	@All bit = 0,
	@IncludeBlank bit = 0,
	@Message varchar(500) = '' output
)
as 
begin
	select @RecipeName = nullif (@RecipeName, '')
	
	select r.RecipeID, r.UsersID, r.CuisineID, r.RecipeName, r.Calories, r.DateDrafted, r.DatePublished, r.DateArchived, r.RecipeStatus, r.RecipePic, r.isVegan, 1 as Orderby
	from Recipe r
	where r.RecipeID = @RecipeId
	or r.RecipeName like '%' + @RecipeName + '%'
	or @All = 1

	
	union select 0,0,0, ' ',0, null, null, null, null, null,0,0
	where @IncludeBlank = 1 
	order by Orderby, r.RecipeName
end
go


/*
exec RecipeGet @All = 1, @IncludeBlank = 1

exec RecipeGet --Returns empty result set

declare @ID int 
select top 1 @ID = RecipeID from Recipe order by RecipeID
exec RecipeGet @RecipeId = @ID

exec RecipeGet @RecipeName = ''

exec RecipeGet @RecipeName = 'mu'

exec RecipeGet @RecipeName = null
*/

