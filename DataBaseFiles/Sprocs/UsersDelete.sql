use HeartyHearthDB
go


create or alter proc dbo.UsersDelete(
    @UsersId int,
    @Message varchar(500) = '' output
)
as
begin
    declare @return int = 0
    
        begin try 
            begin tran 
                delete mcr
                from MealCourseRecipe mcr 
                join MealCourse mc on mcr.MealCourseID = mc.MealCourseID
                join Meal m on mc.MealID = m.MealID
                join Recipe r on mcr.RecipeID = r.RecipeID
                where m.UsersID = @UsersId or r.UsersID = @UsersId
                
                delete mc 
                from MealCourse mc
                join Meal m on mc.MealID = m.MealID
                where m.UsersID = @UsersId

                delete Meal where UsersID = @UsersId

                delete ri 
                from RecipeIngredient ri 
                join Recipe r on ri.RecipeID = r.RecipeID
                where r.UsersID = @UsersId

                delete d 
                from Directions d
                join Recipe r on d.RecipeID = r.RecipeID
                where r.UsersID = @UsersId

                delete cr 
                from CookbookRecipe cr 
                join Recipe r on cr.RecipeID = r.RecipeID
                join Cookbook c on cr.CookbookID = c.CookbookID
                where r.UsersID = @UsersId or c.UsersID = @UsersId

                delete Cookbook where UsersID = @UsersId

                delete Recipe where UsersID = @UsersId

                delete Users where UsersID = @UsersId
            commit 
        end try
        begin catch
            rollback; 
            throw
        end catch

    return @return
end 
go  



