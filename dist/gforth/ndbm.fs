\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library ndbm
s" ndbm" add-lib
\c #include <ndbm.h>

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
c-function dbm_open dbm_open a n n -- a	( file flags mode -- )
c-function dbm_close dbm_close a -- void	( dbf -- )
c-function dbm_fetch dbm_fetch a n -- n	( dbf key -- )
c-function dbm_store dbm_store a n n n -- n	( dbf key content flags -- )
c-function dbm_delete dbm_delete a n -- n	( dbf key -- )
c-function dbm_firstkey dbm_firstkey a -- n	( dbf -- )
c-function dbm_nextkey dbm_nextkey a -- n	( dbf -- )
c-function dbm_error dbm_error a -- n	( dbf -- )
c-function dbm_clearerr dbm_clearerr a -- void	( dbf -- )
c-function dbm_dirfno dbm_dirfno a -- n	( dbf -- )
c-function dbm_pagfno dbm_pagfno a -- n	( dbf -- )
c-function dbm_rdonly dbm_rdonly a -- n	( dbf -- )

\ ----===< postfix >===-----
end-c-library
