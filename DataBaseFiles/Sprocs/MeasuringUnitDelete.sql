use HeartyHearthDB
go



create or alter proc dbo.MeasuringUnitDelete(
    @MeasuringUnitId int,
    @Message varchar(500)='' output
)
as 
begin 
    declare @return int = 0
    
        begin try
            begin tran

                delete RecipeIngredient where MeasuringUnitID = @MeasuringUnitId
                delete MeasuringUnit where MeasuringUnitID = @MeasuringUnitId

            commit 
        end try
        begin catch
            rollback;
            throw
        end catch

    return @return
end
go
