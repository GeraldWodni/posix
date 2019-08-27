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
EXTERN: "C" void * dbm_open( void * file, int flags, int mode );	( file flags mode -- )
EXTERN: "C" void dbm_close( void * dbf );	( dbf -- )
EXTERN: "C" n dbm_fetch( void * dbf, n key );	( dbf key -- )
EXTERN: "C" int dbm_store( void * dbf, n key, n content, int flags );	( dbf key content flags -- )
EXTERN: "C" int dbm_delete( void * dbf, n key );	( dbf key -- )
EXTERN: "C" n dbm_firstkey( void * dbf );	( dbf -- )
EXTERN: "C" n dbm_nextkey( void * dbf );	( dbf -- )
EXTERN: "C" int dbm_error( void * dbf );	( dbf -- )
EXTERN: "C" void dbm_clearerr( void * dbf );	( dbf -- )
EXTERN: "C" int dbm_dirfno( void * dbf );	( dbf -- )
EXTERN: "C" int dbm_pagfno( void * dbf );	( dbf -- )
EXTERN: "C" int dbm_rdonly( void * dbf );	( dbf -- )

\ ----===< postfix >===-----
( none )
