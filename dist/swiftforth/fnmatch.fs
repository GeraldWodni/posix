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
#1	constant _FNMATCH_H
#1	constant FNM_PATHNAME
#2	constant FNM_NOESCAPE
#4	constant FNM_PERIOD
#1	constant FNM_NOMATCH

\ ------===< functions >===-------
FUNCTION: fnmatch ( __pattern __name __flags -- n )	( __pattern __name __flags -- )

\ ----===< postfix >===-----
( none )
