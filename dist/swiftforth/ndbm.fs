\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
( none )

\ -------===< structs >===--------
\ DBM
begin-structure DBM
	drop 40 4 +field DBM-_dbm_errno
	drop 16 16 +field DBM-_dbm_memory
	drop 8 4 +field DBM-dirfd
	drop 32 8 +field DBM-_dbm_fetch_val
	drop 0 8 +field DBM-file
drop 48 end-structure

\ ------===< functions >===-------
FUNCTION: dbm_open ( file flags mode -- a )	( file flags mode -- )
FUNCTION: dbm_close ( dbf -- void )	( dbf -- )
FUNCTION: dbm_fetch ( dbf key -- n )	( dbf key -- )
FUNCTION: dbm_store ( dbf key content flags -- n )	( dbf key content flags -- )
FUNCTION: dbm_delete ( dbf key -- n )	( dbf key -- )
FUNCTION: dbm_firstkey ( dbf -- n )	( dbf -- )
FUNCTION: dbm_nextkey ( dbf -- n )	( dbf -- )
FUNCTION: dbm_error ( dbf -- n )	( dbf -- )
FUNCTION: dbm_clearerr ( dbf -- void )	( dbf -- )
FUNCTION: dbm_dirfno ( dbf -- n )	( dbf -- )
FUNCTION: dbm_pagfno ( dbf -- n )	( dbf -- )
FUNCTION: dbm_rdonly ( dbf -- n )	( dbf -- )

\ ----===< postfix >===-----
( none )
