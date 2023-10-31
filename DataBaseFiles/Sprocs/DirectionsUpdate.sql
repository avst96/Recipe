use HeartyHearthDB
go

create or alter proc dbo.DirectionsUpdate(
    @DirectionsId int output,
    @RecipeId int,
    @Steps varchar (100),
    @StepsSeq int,
    @Message varchar(500) = '' output
)
as 
begin
    declare @return int = 0

    select @DirectionsId = isnull(@DirectionsId,0)

    if(@DirectionsId = 0)
        begin
            insert Directions (RecipeID, Steps, StepsSeq)
                values (@RecipeId, @Steps, @StepsSeq)
        
        select @DirectionsId = scope_identity()
        end
    
    else
        begin

            update Directions   
                set Steps = @Steps,
                    StepsSeq = @StepsSeq
                where DirectionsID = @DirectionsId
        end

    return @return              
end
go

