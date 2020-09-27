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
#1	constant _GRP_H

\ -------===< structs >===--------
\ group
begin-structure group
	drop 24 8 +field group-gr_mem
	drop 0 8 +field group-gr_name
	drop 8 8 +field group-gr_passwd
	drop 16 4 +field group-gr_gid
drop 32 end-structure

\ ------===< functions >===-------
EXTERN: "C" void setgrent(  );	( -- )
EXTERN: "C" void endgrent(  );	( -- )
EXTERN: "C" void * getgrent(  );	( -- )
EXTERN: "C" void * getgrgid( long __gid );	( __gid -- )
EXTERN: "C" void * getgrnam( char * __name );	( __name -- )
EXTERN: "C" int getgrgid_r( long __gid, void * __resultbuf, void * __buffer, long __buflen, void * __result );	( __gid __resultbuf __buffer __buflen __result -- )
EXTERN: "C" int getgrnam_r( char * __name, void * __resultbuf, void * __buffer, long __buflen, void * __result );	( __name __resultbuf __buffer __buflen __result -- )

\ ----===< postfix >===-----
( none )
