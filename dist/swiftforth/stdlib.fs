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
#1	constant _STDLIB_H
#1	constant __ldiv_t_defined
#1	constant __lldiv_t_defined
#2147483647	constant RAND_MAX
#1	constant EXIT_FAILURE
#0	constant EXIT_SUCCESS

\ -------===< structs >===--------
\ div_t
begin-structure div_t
	drop 0 4 +field div_t-quot
	drop 4 4 +field div_t-rem
drop 8 end-structure
\ ldiv_t
begin-structure ldiv_t
	drop 0 8 +field ldiv_t-quot
	drop 8 8 +field ldiv_t-rem
drop 16 end-structure
\ lldiv_t
begin-structure lldiv_t
	drop 0 8 +field lldiv_t-quot
	drop 8 8 +field lldiv_t-rem
drop 16 end-structure

\ ------===< callbacks >===-------
	( <noname> <noname> -- )

\ ------===< functions >===-------
FUNCTION: __ctype_get_mb_cur_max (  -- u )	( -- )
FUNCTION: atof ( __nptr -- r )	( __nptr -- )
FUNCTION: atoi ( __nptr -- n )	( __nptr -- )
FUNCTION: atol ( __nptr -- n )	( __nptr -- )
FUNCTION: atoll ( __nptr -- d )	( __nptr -- )
FUNCTION: strtod ( __nptr __endptr -- r )	( __nptr __endptr -- )
FUNCTION: strtof ( __nptr __endptr -- r )	( __nptr __endptr -- )
FUNCTION: strtold ( __nptr __endptr -- r )	( __nptr __endptr -- )
FUNCTION: strtol ( __nptr __endptr __base -- n )	( __nptr __endptr __base -- )
FUNCTION: strtoul ( __nptr __endptr __base -- u )	( __nptr __endptr __base -- )
FUNCTION: strtoll ( __nptr __endptr __base -- d )	( __nptr __endptr __base -- )
FUNCTION: strtoull ( __nptr __endptr __base -- ud )	( __nptr __endptr __base -- )
FUNCTION: rand (  -- n )	( -- )
FUNCTION: srand ( __seed -- void )	( __seed -- )
FUNCTION: malloc ( __size -- a )	( __size -- )
FUNCTION: calloc ( __nmemb __size -- a )	( __nmemb __size -- )
FUNCTION: realloc ( __ptr __size -- a )	( __ptr __size -- )
FUNCTION: free ( __ptr -- void )	( __ptr -- )
FUNCTION: abort (  -- void )	( -- )
FUNCTION: atexit ( __func -- n )	( __func -- )
FUNCTION: exit ( __status -- void )	( __status -- )
FUNCTION: _Exit ( __status -- void )	( __status -- )
FUNCTION: getenv ( __name -- a )	( __name -- )
FUNCTION: system ( __command -- n )	( __command -- )
FUNCTION: bsearch ( __key __base __nmemb __size __compar -- a )	( __key __base __nmemb __size __compar -- )
FUNCTION: qsort ( __base __nmemb __size __compar -- void )	( __base __nmemb __size __compar -- )
FUNCTION: abs ( __x -- n )	( __x -- )
FUNCTION: labs ( __x -- n )	( __x -- )
FUNCTION: llabs ( __x -- d )	( __x -- )
FUNCTION: div ( __numer __denom -- struct )	( __numer __denom -- )
FUNCTION: ldiv ( __numer __denom -- struct )	( __numer __denom -- )
FUNCTION: lldiv ( __numer __denom -- struct )	( __numer __denom -- )
FUNCTION: mblen ( __s __n -- n )	( __s __n -- )
FUNCTION: mbtowc ( __pwc __s __n -- n )	( __pwc __s __n -- )
FUNCTION: wctomb ( __s __wchar -- n )	( __s __wchar -- )
FUNCTION: mbstowcs ( __pwcs __s __n -- u )	( __pwcs __s __n -- )
FUNCTION: wcstombs ( __s __pwcs __n -- u )	( __s __pwcs __n -- )

\ ----===< postfix >===-----
( none )
