script to create login and user is excluded from this repo.
Create a file called create-login.sql (this file is ignored by the git ingore file in this repo)
add the following to file 

--IMPORTANT use master
use master
create login [loginname] with password = '[password]'
go

--IMPORTANT switch to HeartyHearthDB
use HeartyHearthDB
go
create user [username] from login [loginname]

