--IMPORTANT use master
create login CPUStaff_login with password = --Saved in vault

--IMPORTANT switch to HeartyHearthDB
create user CPUStaff_user from login CPUStaff_login

alter role db_datareader add member CPUStaff_user
 
alter role db_datawriter add member CPUStaff_user