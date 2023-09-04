use HeartyHearthDB
go 

declare @tablename varchar(50) = 'recipe'

select 
	concat('@',c.COLUMN_NAME,' ', c.DATA_TYPE, 
	case when c.CHARACTER_MAXIMUM_LENGTH is null then '' else concat(' (',c.CHARACTER_MAXIMUM_LENGTH,')') end, 
	case when c.TABLE_NAME + 'id' = c.COLUMN_NAME then ' output' else '' end,
	','	)
from INFORMATION_SCHEMA.COLUMNS c
where c.TABLE_NAME = @tablename


declare @insertlist varchar(5000) = ''

select @insertlist = @insertlist + concat(c.COLUMN_NAME,', ')
from INFORMATION_SCHEMA.COLUMNS c
where c.TABLE_NAME = @tablename
and c.COLUMN_NAME <> c.TABLE_NAME + 'Id'

select @insertlist

select @insertlist = ''

select @insertlist = @insertlist + concat('@',c.COLUMN_NAME,', ')
from INFORMATION_SCHEMA.COLUMNS c
where c.TABLE_NAME = @tablename
and c.COLUMN_NAME <> c.TABLE_NAME + 'Id'

select @insertlist

select @insertlist = ''

select concat(c.COLUMN_NAME,' = @',c.COLUMN_NAME,', ')
from INFORMATION_SCHEMA.COLUMNS c
where c.TABLE_NAME = @tablename
and c.COLUMN_NAME <> c.TABLE_NAME + 'Id'

