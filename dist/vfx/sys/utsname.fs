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

\ ----===< int constants >===-----
#1	constant _SYS_UTSNAME_H

\ -------===< structs >===--------
\ struct utsname
begin-structure utsname
	drop 0 65 +field utsname-sysname
	drop 65 65 +field utsname-nodename
	drop 260 65 +field utsname-machine
	drop 195 65 +field utsname-version
	drop 130 65 +field utsname-release
drop 390 end-structure

\ ------===< functions >===-------
EXTERN: "C" int uname( void * __name );	( __name -- )

\ ----===< postfix >===-----
( none )
