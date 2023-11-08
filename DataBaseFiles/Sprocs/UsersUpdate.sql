use HeartyHearthDB
go


create or alter proc dbo.UsersUpdate(
    @UsersId int output,
    @FirstName varchar(35),
    @LastName varchar(35),
    @UserName varchar(20),
    @Message varchar(500) = '' output
)
as
begin 
    declare @return int = 0 
    select @UsersId = isnull(@UsersId,0)

    if(@UsersId = 0)
    begin
        insert Users (FirstName, LastName, UserName)
            values(@FirstName, @LastName, @UserName)

    select @UsersId = scope_identity()
    end

    else
    begin
        update u 
        set u.FirstName = @FirstName,
            u.LastName = @LastName,
            u.UserName = @UserName
        from Users u 
        where u.UsersID = @UsersId
    end

    return @return
end
go



