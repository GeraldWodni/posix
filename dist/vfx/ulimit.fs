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
#1	constant _ULIMIT_H

\ --------===< enums >===---------
#1	constant UL_GETFSIZE
#2	constant UL_SETFSIZE
#3	constant __UL_GETMAXBRK
#4	constant __UL_GETOPENMAX

\ ------===< functions >===-------
EXTERN: "C" long ulimit( int __cmd, ...  );	( __cmd <noname> -- )

\ ----===< postfix >===-----
( none )
