use HeartyHearthDB
go



create or alter proc dbo.CourseDelete(
    @CourseId int,
    @Message varchar(500)='' output
)
as 
begin 
    declare @return int = 0
    
        begin try
            begin tran

                delete mcr
                from MealCourseRecipe mcr 
                join MealCourse mc on mcr.MealCourseID = mc.MealCourseID
                where mc.CourseID = @CourseId

                delete MealCourse where CourseID = @CourseId
                delete Course where CourseID = @CourseId

            commit 
        end try
        begin catch
            rollback;
            throw
        end catch

    return @return
end
go
