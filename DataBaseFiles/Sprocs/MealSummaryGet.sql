use HeartyHearthDB
go


create or alter proc dbo.MealSummaryGet(
    @Message varchar(500) = '' output
)
as 
begin
    declare @return int = 0

        select m.MealName, u.UserName, sum(r.Calories) as Num_Calories, count(mc.CourseID) as Num_Courses, count(mcr.RecipeID) as Num_Recipes
        from Meal m 
        join Users u 
        on m.UsersID = u.UsersID
        left join MealCourse mc 
        on m.MealID = mc.MealID
        left join MealCourseRecipe mcr 
        on mc.MealCourseID = mcr.MealCourseID
        left join Recipe r 
        on mcr.RecipeID = r.RecipeID
        group by m.MealName, u.UserName
        order by m.MealName

    return @return
end
go


exec MealSummaryGet

