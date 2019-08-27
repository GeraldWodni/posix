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
#1	constant _DIRENT_H
#1	constant _DIRENT_MATCHES_DIRENT64

\ -------===< structs >===--------
\ dirent
begin-structure dirent
	drop 18 1 +field dirent-d_type
	drop 8 8 +field dirent-d_off
	drop 16 2 +field dirent-d_reclen
	drop 0 8 +field dirent-d_ino
	drop 19 256 +field dirent-d_name
drop 280 end-structure

\ ------===< functions >===-------
FUNCTION: opendir ( __name -- a )	( __name -- )
FUNCTION: fdopendir ( __fd -- a )	( __fd -- )
FUNCTION: closedir ( __dirp -- n )	( __dirp -- )
FUNCTION: readdir ( __dirp -- a )	( __dirp -- )
FUNCTION: readdir_r ( __dirp __entry __result -- n )	( __dirp __entry __result -- )
FUNCTION: rewinddir ( __dirp -- void )	( __dirp -- )
FUNCTION: dirfd ( __dirp -- n )	( __dirp -- )
FUNCTION: scandir ( __dir __namelist __selector __cmp -- n )	( __dir __namelist __selector __cmp -- )
FUNCTION: alphasort ( __e1 __e2 -- n )	( __e1 __e2 -- )

\ ----===< postfix >===-----
( none )
