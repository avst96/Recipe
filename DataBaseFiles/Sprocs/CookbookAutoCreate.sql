use HeartyHearthDB
go



create or alter proc dbo.CookbookAutoCreate(
    @UsersId int,
    @CookbookId int = 0 output,
    @Message varchar(500) = '' output
)
as
begin
    declare @return int = 0

        insert Cookbook(UsersID,BookName,Price,IsActive)
            select @UsersId, concat('Recipes by ',u.FirstName,' ',u.LastName), count(r.RecipeID) * 1.33, 1 
            from Users u 
            left join Recipe r on u.UsersID = r.UsersID 
            where u.UsersID = @UsersId
            group by u.FirstName, u.LastName

        select @CookbookId = scope_identity()

        insert CookbookRecipe (CookbookID, RecipeID , RecipeSeq)
            select @CookbookId, r.RecipeID, row_number() over (order by r.RecipeName)
            from Recipe r 
            where r.UsersID = @UsersId 


    return @return
end
go
--rule that cant add cookbook if no recipes




