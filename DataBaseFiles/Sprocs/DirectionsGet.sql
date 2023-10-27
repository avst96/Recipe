use HeartyHearthDB
go

create or alter proc dbo.DirectionsGet(
    @RecipeId int = 0,
    @All bit = 0,
    @Message varchar(500) = '' output
)
as 
begin
    declare @return int = 0

    select @RecipeId = isnull(@RecipeId,0), @All = isnull(@All,0)

    select d.DirectionsID, d.Steps, d.StepsSeq
    from Directions d 
    where d.RecipeID = @RecipeId
    or @All = 1
    order by d.StepsSeq    


    return @return
end
go

exec DirectionsGet
