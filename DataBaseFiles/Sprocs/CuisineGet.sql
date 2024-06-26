use HeartyHearthDB
go

create or alter procedure dbo.CuisineGet
	(
		@CuisineId int = 0, 
		@CuisineName varchar(20) = '', 
		@All bit = 0,
		@IncludeBlank bit = 0,
		@Message varchar(500) = '' output
)
as 
begin
	declare @return int= 0
	select @CuisineId = isnull(@CuisineId,0), @CuisineName = isnull(@CuisineName, '')

	select c.CuisineId, c.CuisineName, 1 as OrderBy
	from Cuisine c 
	where c.CuisineId = @CuisineId
	or (c.CuisineName like '%' + @CuisineName + '%' and @CuisineName <> '')
	or @All = 1 

	union select 0,' ', 0
	where @IncludeBlank = 1
	order by OrderBy, c.CuisineName

	return @return
end
go


/*
exec CuisineGet

exec CuisineGet @All = 1 

exec CuisineGet @CuisineName = 'c'

exec CuisineGet @CuisineName = null


declare @ID int 
select top 1 @ID = cuisineid from Cuisine
exec CuisineGet @CuisineId = @ID
*/

