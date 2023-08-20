use HeartyHearthDB
go

create or alter procedure dbo.CuisineGet (@CuisineID int = 0, @CuisineName varchar(20) = '', @All bit = 0)
as 
begin
	select c.CuisineID, c.CuisineName
	from Cuisine c 
	where c.CuisineID = @CuisineID
	or (c.CuisineName like '%' + @CuisineName + '%' and @CuisineName <> '')
	or @All = 1 
end
go


/*
exec CuisineGet

exec CuisineGet @All = 1 

exec CuisineGet @CuisineName = 'c'

exec CuisineGet @CuisineName = null


declare @ID int 
select top 1 @ID = cuisineid from Cuisine
exec CuisineGet @CuisineID = @ID
*/