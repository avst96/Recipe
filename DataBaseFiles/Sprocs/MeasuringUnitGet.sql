use HeartyHearthDB
go


create or alter proc dbo.MeasuringUnitGet(
    @IncludeBlank bit = 0,
    @Message varchar (500) = '' output
)
as
begin

    declare @return int = 0

    select @IncludeBlank = isnull(@IncludeBlank,0)

    select m.MeasuringUnitID, m.Unit
    from MeasuringUnit m 
    union select 0, ' '
    where @IncludeBlank = 1 
    order by m.Unit

end
go

exec MeasuringUnitGet @IncludeBlank = 1

