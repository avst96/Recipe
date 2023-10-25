use HeartyHearthDB
go

create or alter proc dbo.DashboardGet(
	@Message varchar(500) = '' output
)
as
begin 
	declare @return int = 0

	select DashboardType = 'Recipes', DashboardText = count(*)  
	from Recipe r 
	union select DashboardType = 'Meals', DashboardText = count(*) 
	from Meal m 
    union select 'Cookbooks', count(*)
    from Cookbook c 

	return @return
end
go


--exec DashboardGet