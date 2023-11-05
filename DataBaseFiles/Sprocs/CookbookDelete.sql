use HeartyHearthDB
go

create or alter proc dbo.CookbookDelete (
    @CookbookId int,
    @Message varchar(500) = '' output
)
as 
begin
    declare @return int = 0 

    	begin try
			begin tran
				delete CookbookRecipe where CookbookID = @CookbookId
				delete Cookbook where CookbookID = @CookbookId
			commit
		end try
		begin catch
			rollback;
			throw
		end catch
    return @return
end
go




