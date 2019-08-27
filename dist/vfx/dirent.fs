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

\ ------===< functions >===-------
EXTERN: "C" void * opendir( char * __name );	( __name -- )
EXTERN: "C" void * fdopendir( int __fd );	( __fd -- )
EXTERN: "C" int closedir( void * __dirp );	( __dirp -- )
EXTERN: "C" void * readdir( void * __dirp );	( __dirp -- )
EXTERN: "C" int readdir_r( void * __dirp, void * __entry, void * __result );	( __dirp __entry __result -- )
EXTERN: "C" void rewinddir( void * __dirp );	( __dirp -- )
EXTERN: "C" int dirfd( void * __dirp );	( __dirp -- )
EXTERN: "C" int scandir( char * __dir, void * __namelist, void * __selector, void * __cmp );	( __dir __namelist __selector __cmp -- )
EXTERN: "C" int alphasort( void * __e1, void * __e2 );	( __e1 __e2 -- )

\ ----===< postfix >===-----
( none )
