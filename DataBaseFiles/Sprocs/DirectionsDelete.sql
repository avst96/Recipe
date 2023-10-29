use HeartyHearthDB
go

create or alter proc dbo.DirectionsDelete(
    @DirectionsId int,
    @Message varchar(500) = '' output
)
as 
begin
    declare @return int = 0

    select @DirectionsId = isnull(@DirectionsId, 0)

    delete Directions where DirectionsID = @DirectionsId 

    return @return

end
go

