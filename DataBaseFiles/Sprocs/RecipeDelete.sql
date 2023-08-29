use HeartyHearthDB
go

create or alter procedure dbo.RecipeDelete (@RecipeId int)
as
begin
	begin try
		begin tran
			delete RecipeIngredient where RecipeID = @RecipeId
			delete Directions where RecipeID = @RecipeId
			delete Recipe where RecipeID = @recipeid
			commit
		end try
		begin catch
			rollback;
			throw
		end catch
end
go