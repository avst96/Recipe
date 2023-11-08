use HeartyHearthDB
go



create or alter proc dbo.CuisineDelete(
    @CuisineId int,
    @Message varchar(500)='' output
)
as 
begin 
    declare @return int = 0
    
        begin try
            begin tran

                delete mcr 
                from MealCourseRecipe mcr 
                join Recipe r on mcr.RecipeID = r.RecipeID
                where r.CuisineID = @CuisineId

                delete cr 
                from CookbookRecipe cr 
                join Recipe r on cr.RecipeID = r.RecipeID
                where r.CuisineID = @CuisineId

                delete d 
                from Directions d 
                join Recipe r on d.RecipeID = r.RecipeID
                where r.CuisineID = @CuisineId

                delete ri 
                from RecipeIngredient ri 
                join Recipe r on ri.RecipeID = r.RecipeID
                where r.CuisineID = @CuisineId

                delete Recipe where CuisineID = @CuisineId
                delete Cuisine where CuisineID = @CuisineId

            commit 
        end try
        begin catch
            rollback;
            throw
        end catch

    return @return
end
go
