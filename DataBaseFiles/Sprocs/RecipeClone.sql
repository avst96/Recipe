use HeartyHearthDB
go


create or alter proc dbo.RecipeClone(
    @RecipeId int output,
    @Message varchar(500) = '' output
)
as 
begin
    declare @return int = 0, @clonedrecipe int 


    begin try
        begin tran
            insert Recipe (UsersID,CuisineID,RecipeName,Calories)
                select r.UsersID, r.CuisineID, r.RecipeName + ' - clone', r.Calories 
                from Recipe r 
                where r.RecipeID = @RecipeId


            select @clonedrecipe = scope_identity()


            insert Directions (RecipeID,Steps,StepsSeq)
                select @clonedrecipe, d.Steps, d.StepsSeq
                from Directions d 
                where d.RecipeID = @RecipeId
                    

            insert RecipeIngredient (RecipeID,IngredientID,MeasuringUnitID,IngredientSeq,Amount)
                select @clonedrecipe,ri.IngredientID,ri.MeasuringUnitID,ri.IngredientSeq,ri.Amount
                from RecipeIngredient ri 
                where ri.RecipeID = @RecipeId

                select @RecipeId = @clonedrecipe
        commit
    end try
    begin catch
        rollback;
        throw
    end catch


    return @return
end
go


