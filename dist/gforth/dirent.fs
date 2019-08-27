\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library dirent
s" dirent" add-lib
\c #include <dirent.h>

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
c-function opendir opendir s -- a	( __name -- )
c-function fdopendir fdopendir n -- a	( __fd -- )
c-function closedir closedir a -- n	( __dirp -- )
c-function readdir readdir a -- a	( __dirp -- )
c-function readdir_r readdir_r a a a -- n	( __dirp __entry __result -- )
c-function rewinddir rewinddir a -- void	( __dirp -- )
c-function dirfd dirfd a -- n	( __dirp -- )
c-function scandir scandir s a a a -- n	( __dir __namelist __selector __cmp -- )
c-function alphasort alphasort a a -- n	( __e1 __e2 -- )

\ ----===< postfix >===-----
end-c-library
