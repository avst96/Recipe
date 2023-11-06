use HeartyHearthDB 
go

create or alter proc dbo.CookbookRecipeUpdate(
    @CookbookRecipeId int output,
    @CookbookId int, 
    @RecipeId int,
    @RecipeSeq int,
    @Message varchar(500) = '' output
)
as 
begin
    declare @return int = 0
    select @CookbookRecipeId = isnull(@CookbookRecipeId,0)

    if (@CookbookRecipeId = 0)
    begin 
        insert CookbookRecipe(CookbookID, RecipeID, RecipeSeq)
            values (@CookbookId, @RecipeId, @RecipeSeq)

        select @CookbookRecipeId = scope_identity()
    end

    else 
    begin
        update cr
        set RecipeID = @RecipeId,
            RecipeSeq = @RecipeSeq
        from CookbookRecipe cr 
        where cr.CookbookRecipeID = @CookbookRecipeId
    end

    return @return
end
go

