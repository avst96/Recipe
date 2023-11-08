use HeartyHearthDB
go


create or alter proc dbo.MeasuringUnitUpdate(
    @MeasuringUnitId int output,
    @Unit varchar(12),
    @Message varchar(500) = '' output
)
as
begin 
    declare @return int = 0 
    select @MeasuringUnitId = isnull(@MeasuringUnitId,0)

    if(@MeasuringUnitId = 0)
    begin
        insert MeasuringUnit (Unit)
            values(@Unit)

    select @MeasuringUnitId = scope_identity()
    end

    else
    begin
        update mu
        set mu.Unit = @Unit
        from MeasuringUnit mu
        where mu.MeasuringUnitID = @MeasuringUnitId
    end

    return @return
end
go



