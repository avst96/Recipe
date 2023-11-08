use HeartyHearthDB
go


create or alter proc dbo.CourseUpdate(
    @CourseId int output,
    @CourseName varchar(20),
    @CourseSeq int,
    @Message varchar(500) = '' output
)
as
begin 
    declare @return int = 0 
    select @CourseId = isnull(@CourseId,0)

    if(@CourseId = 0)
    begin
        insert Course (CourseName, CourseSeq)
            values(@CourseName, @CourseSeq)

    select @CourseId = scope_identity()
    end

    else
    begin
        update c
        set c.CourseName = @CourseName,
            c.CourseSeq = @CourseSeq
        from Course c
        where c.CourseID = @CourseId
    end

    return @return
end
go


