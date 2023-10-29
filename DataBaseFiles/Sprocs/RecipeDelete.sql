use HeartyHearthDB
go

create or alter procedure dbo.RecipeDelete (@RecipeId int, @Message varchar(500) = '' output)
as
begin
	declare @return int = 0

	if exists (select * from Recipe r
		where r.RecipeID = @RecipeId 
		and r.RecipeStatus <> 'Draft'
		and datediff(day,isnull(r.DateArchived,getdate()), getdate()) <= 30)
		begin 
		select @return = 1, @Message = 'Can only delete recipe that is still in draft or is already archived for more then 30 days'
		goto finished
		end

		begin try
			begin tran
				delete CookbookRecipe where RecipeID = @RecipeId
				delete MealCourseRecipe where RecipeID = @RecipeId
				delete RecipeIngredient where RecipeID = @RecipeId
				delete Directions where RecipeID = @RecipeId
				delete Recipe where RecipeID = @recipeid
			commit
		end try
		begin catch
			rollback;
			throw
		end catch

		finished:
		return @return
end
go