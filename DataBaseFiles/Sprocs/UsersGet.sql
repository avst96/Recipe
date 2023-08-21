use HeartyHearthDB
go

create or alter procedure dbo.UsersGet (@UsersId int = 0, @UsersName varchar(20) = '', @All bit = 0) 
as 
begin
	select u.UsersId, u.FirstName, u.LastName, u.UserName 
	from Users u
	where u.UsersId = @UsersId
	or (u.UserName like '%' + @UsersName + '%' and @UsersName <> '')
	or @All = 1
end
go
 

/*
exec UsersGet

exec UsersGet @All = 1

exec UsersGet @UsersName = 'f'

declare @ID int
select top 1 @ID = UsersId from Users
exec UsersGet @UsersId = @ID
*/