use HeartyHearthDB
go


create or alter proc dbo.CourseGet(
    @IncludeBlank bit = 0,
    @Message varchar (500) = '' output
)
as
begin

    declare @return int = 0

    select @IncludeBlank = isnull(@IncludeBlank,0)

    select c.CourseID,c.CourseSeq,c.CourseName
    from Course c 
    union select 0, 0, ' '
    where @IncludeBlank = 1 
    order by c.CourseSeq

end
go

exec CourseGet @IncludeBlank = 1