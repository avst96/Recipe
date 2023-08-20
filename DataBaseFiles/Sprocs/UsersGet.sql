use HeartyHearthDB
go

create or alter procedure dbo.UsersGet (@UsersID int = 0, @UsersName varchar(20) = '', @All bit = 0) 
as 
begin
	select u.UsersID, u.FirstName, u.LastName, u.UserName 
	from Users u
	where u.UsersID = @UsersID
	or (u.UserName like '%' + @UsersName + '%' and @UsersName <> '')
	or @All = 1
end
go
 

/*
exec UsersGet

exec UsersGet @All = 1

exec UsersGet @UsersName = 'f'

declare @ID int
select top 1 @ID = usersid from Users
exec UsersGet @UsersID = @ID
*/