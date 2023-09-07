use HeartyHearthDB
go

create or alter function dbo.CaloriesPerMeal (@MealId int)
returns int 
as begin
	declare @calories int
	select @calories = sum(r.Calories)
	from Meal m
	join MealCourse mc 
	on m.MealID = mc.MealID
	join MealCourseRecipe mcr 
	on mc.MealCourseID = mcr.MealCourseID
	join Recipe r
	on mcr.RecipeID = r.RecipeID
	where m.MealID = @MealId

	return @calories
end
go

/*
select dbo.CaloriesPerMeal(m.MealID) as TotalCalories, m.MealName 
from Meal m 
*/