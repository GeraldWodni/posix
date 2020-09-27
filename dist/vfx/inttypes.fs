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
EXTERN: "C" long imaxabs( long __n );	( __n -- )
EXTERN: "C" struct imaxdiv( long __numer, long __denom );	( __numer __denom -- )
EXTERN: "C" long strtoimax( char * __nptr, void * __endptr, int __base );	( __nptr __endptr __base -- )
EXTERN: "C" long strtoumax( char * __nptr, void * __endptr, int __base );	( __nptr __endptr __base -- )
EXTERN: "C" long wcstoimax( char * __nptr, void * __endptr, int __base );	( __nptr __endptr __base -- )
EXTERN: "C" long wcstoumax( char * __nptr, void * __endptr, int __base );	( __nptr __endptr __base -- )

\ ----===< postfix >===-----
( none )
