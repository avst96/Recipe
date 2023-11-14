use HeartyHearthDB
go



create or alter proc dbo.CookbookAutoCreate(
    @UsersId int,
    @CookbookId int = 0 output,
    @Message varchar(500) = '' output
)
as
begin
    declare @return int = 0, @numofrecipes int

        select @numofrecipes = count(*) 
            from Recipe r 
            where r.UsersID = @UsersId
        if(@numofrecipes = 0)
        begin 
            select @return = 1, @Message = 'This user has no receipes, cannot create cookbook'
            goto finished
        end
        

        insert Cookbook(UsersID,BookName,Price,IsActive)
            select @UsersId, concat('Recipes by ',u.FirstName,' ',u.LastName), @numofrecipes * 1.33, 1 
            from Users u 
            where u.UsersID = @UsersId
            group by u.FirstName, u.LastName

        select @CookbookId = scope_identity()

        insert CookbookRecipe (CookbookID, RecipeID , RecipeSeq)
            select @CookbookId, r.RecipeID, row_number() over (order by r.RecipeName)
            from Recipe r 
            where r.UsersID = @UsersId 


    finished:
    return @return
end
go




