use HeartyHearthDB
go


create or alter proc dbo.IngredientUpdate(
    @IngredientId int output,
    @IngredientName varchar(40),
    @Message varchar(500) = '' output
)
as
begin 
    declare @return int = 0 
    select @IngredientId = isnull(@IngredientId,0)

    if(@IngredientId = 0)
    begin
        insert Ingredient (IngredientName)
            values(@IngredientName)

    select @IngredientId = scope_identity()
    end

    else
    begin
        update i
        set i.IngredientName = @IngredientName
        from Ingredient i
        where i.IngredientID = @IngredientId
    end

    return @return
end
go


