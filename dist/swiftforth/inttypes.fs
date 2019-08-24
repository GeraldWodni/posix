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
#1	constant _INTTYPES_H
#1	constant ____gwchar_t_defined

\ -------===< structs >===--------
\ imaxdiv_t
begin-structure imaxdiv_t
	drop 0 8 +field imaxdiv_t-quot
	drop 8 8 +field imaxdiv_t-rem
drop 16 end-structure

\ ------===< functions >===-------
FUNCTION: imaxabs ( __n -- n )	( __n -- )
FUNCTION: imaxdiv ( __numer __denom -- struct )	( __numer __denom -- )
FUNCTION: strtoimax ( __nptr __endptr __base -- n )	( __nptr __endptr __base -- )
FUNCTION: strtoumax ( __nptr __endptr __base -- n )	( __nptr __endptr __base -- )
FUNCTION: wcstoimax ( __nptr __endptr __base -- n )	( __nptr __endptr __base -- )
FUNCTION: wcstoumax ( __nptr __endptr __base -- n )	( __nptr __endptr __base -- )

\ ----===< postfix >===-----
( none )
