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
#1	constant _NL_TYPES_H
#1	constant NL_SETD
#1	constant NL_CAT_LOCALE

\ ------===< functions >===-------
FUNCTION: catopen ( __cat_name __flag -- a )	( __cat_name __flag -- )
FUNCTION: catgets ( __catalog __set __number __string -- a )	( __catalog __set __number __string -- )
FUNCTION: catclose ( __catalog -- n )	( __catalog -- )

\ ----===< postfix >===-----
( none )
