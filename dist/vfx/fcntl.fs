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
#1	constant _FCNTL_H

\ ------===< functions >===-------
EXTERN: "C" int fcntl( int __fd, int __cmd, ...  );	( __fd __cmd <noname> -- )
EXTERN: "C" int open( char * __file, int __oflag, ...  );	( __file __oflag <noname> -- )
EXTERN: "C" int creat( char * __file, n __mode );	( __file __mode -- )

\ ----===< postfix >===-----
( none )
