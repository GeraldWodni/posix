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
#1	constant _PWD_H

\ -------===< structs >===--------
\ passwd
begin-structure passwd
	drop 16 4 +field passwd-pw_uid
	drop 20 4 +field passwd-pw_gid
	drop 0 8 +field passwd-pw_name
	drop 24 8 +field passwd-pw_gecos
	drop 32 8 +field passwd-pw_dir
	drop 40 8 +field passwd-pw_shell
	drop 8 8 +field passwd-pw_passwd
drop 48 end-structure

\ ------===< functions >===-------
EXTERN: "C" void * getpwuid( long __uid );	( __uid -- )
EXTERN: "C" void * getpwnam( char * __name );	( __name -- )
EXTERN: "C" int getpwuid_r( long __uid, void * __resultbuf, void * __buffer, long __buflen, void * __result );	( __uid __resultbuf __buffer __buflen __result -- )
EXTERN: "C" int getpwnam_r( char * __name, void * __resultbuf, void * __buffer, long __buflen, void * __result );	( __name __resultbuf __buffer __buflen __result -- )

\ ----===< postfix >===-----
( none )
