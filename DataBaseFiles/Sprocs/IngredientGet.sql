use HeartyHearthDB 
go 

create or alter proc dbo.IngredientGet(
    @IncludeBlank bit = 0,
    @Message varchar(500) = '' output
)
as
begin
    declare @return int = 0

    select @IncludeBlank = isnull(@IncludeBlank,0)

    select i.IngredientID, i.IngredientName
    from Ingredient i 
    union select 0, ' '

    return @return
end 
go 


exec IngredientGet
