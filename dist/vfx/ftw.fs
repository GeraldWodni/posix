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
#1	constant _FTW_H

\ --------===< enums >===---------
#0	constant FTW_F
#1	constant FTW_D
#2	constant FTW_DNR
#3	constant FTW_NS

\ ------===< callbacks >===-------
	( __filename __status __flag -- )

\ ------===< functions >===-------
EXTERN: "C" int ftw( char * __dir, void * __func, int __descriptors );	( __dir __func __descriptors -- )

\ ----===< postfix >===-----
( none )