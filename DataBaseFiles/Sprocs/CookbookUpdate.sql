use HeartyHearthDB 
go 

create or alter proc dbo.CookbookUpdate(
    @CookbookId int output,
    @UsersId int,
    @BookName varchar(30),
    @Price decimal(5,2),
    @IsActive bit,
    @DateCreated date = null output,
    @Message varchar(500) = '' output
)
as
begin
    declare @return int = 0

    select @CookbookId = isnull(@CookbookId,0), @Price = isnull(@Price,0), @IsActive = isnull(@IsActive, 0)

    if(@CookbookId = 0)
        begin
            insert Cookbook (UsersID,BookName,Price,DateCreated,IsActive)
                values (@UsersId, @BookName, @Price, getdate(), @IsActive)

                select @CookbookId = scope_identity()
                select @DateCreated = c.DateCreated 
                from Cookbook c 
                where c.CookbookID = @CookbookId
        end

    else
        begin
            update Cookbook
            set UsersID = @UsersId,
                BookName = @BookName,
                Price = @Price,
                IsActive = @IsActive
            from Cookbook c 
            where c.CookbookID = @CookbookId


        end
    return @return
end
go

/*
declare @ouput int = 4
exec CookbookUpdate @ouput output , 2, 'My sql', 10.25, 1 


select * from Cookbook c where c.CookbookID = @ouput
*/