use HeartyHearthDB
go


create or alter proc dbo.CookbookGet(
    @CookbookId int = 0,
    @All bit = 0,
    @Message varchar(500) = '' output
)
as
begin
    select @CookbookId = isnull(@CookbookId, 0), @All = isnull(@All, 0)

    declare @return int = 0
        select c.CookbookID, c.UsersID, c.BookName, c.Price, c.DateCreated, c.IsActive, c.SkillLevel
        from Cookbook c
        where c.CookbookID = @CookbookId
        or @All = 1

    return @return
end
go


