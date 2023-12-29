use HeartyHearthDB 
go 

create or alter proc dbo.IngredientGet(
    @IngredientName varchar(40) = '',
    @All bit = 0,
    @IncludeBlank bit = 0,
    @Message varchar(500) = '' output
)
as
begin
    declare @return int = 0

    select @IncludeBlank = isnull(@IncludeBlank,0), @IngredientName = nullif(@IngredientName, '')

    select i.IngredientID, i.IngredientName, i.IngredientPicture
    from Ingredient i 
    where @All = 1 or i.IngredientName like '%' + @IngredientName + '%'
    union select 0, ' ', ''
    where @IncludeBlank = 1
    order by i.IngredientName

    return @return
end 
go 


exec IngredientGet @IncludeBlank = 1
