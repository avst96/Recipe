use HeartyHearthDB
go

create or alter procedure dbo.UsersGet (
	@UsersId int = 0, 
	@UsersName varchar(20) = '',
	@All bit = 0,
	@IncludeBlank bit = 0,
	@Message varchar(500) = '' output
	) 
as 
begin
	select u.UsersID, u.FirstName, u.LastName, u.UserName
	from Users u
	where u.UsersId = @UsersId
	or (u.UserName like '%' + @UsersName + '%' and @UsersName <> '')
	or @All = 1
	union select 0, ' ',' ', ' '
	where @IncludeBlank = 1
	order by u.UserName
end
go
 


exec UsersGet

exec UsersGet @All = 1, @IncludeBlank = 1

exec UsersGet @UsersName = 'f'
/*
declare @ID int
select top 1 @ID = UsersId from Users
exec UsersGet @UsersId = @ID
*/

