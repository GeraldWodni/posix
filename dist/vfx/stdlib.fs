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

\ ------===< callbacks >===-------
	( <noname> <noname> -- )

\ ------===< functions >===-------
EXTERN: "C" n __ctype_get_mb_cur_max(  );	( -- )
EXTERN: "C" double atof( char * __nptr );	( __nptr -- )
EXTERN: "C" int atoi( char * __nptr );	( __nptr -- )
EXTERN: "C" long atol( char * __nptr );	( __nptr -- )
EXTERN: "C" double strtod( char * __nptr, void * __endptr );	( __nptr __endptr -- )
EXTERN: "C" long strtol( char * __nptr, void * __endptr, int __base );	( __nptr __endptr __base -- )
EXTERN: "C" long strtoul( char * __nptr, void * __endptr, int __base );	( __nptr __endptr __base -- )
EXTERN: "C" int rand(  );	( -- )
EXTERN: "C" void srand( int __seed );	( __seed -- )
EXTERN: "C" void * malloc( n __size );	( __size -- )
EXTERN: "C" void * calloc( n __nmemb, n __size );	( __nmemb __size -- )
EXTERN: "C" void * realloc( void * __ptr, n __size );	( __ptr __size -- )
EXTERN: "C" void free( void * __ptr );	( __ptr -- )
EXTERN: "C" void abort(  );	( -- )
EXTERN: "C" int atexit( void * __func );	( __func -- )
EXTERN: "C" void exit( int __status );	( __status -- )
EXTERN: "C" void * getenv( char * __name );	( __name -- )
EXTERN: "C" int system( char * __command );	( __command -- )
EXTERN: "C" void * bsearch( void * __key, void * __base, n __nmemb, n __size, void * __compar );	( __key __base __nmemb __size __compar -- )
EXTERN: "C" void qsort( void * __base, n __nmemb, n __size, void * __compar );	( __base __nmemb __size __compar -- )
EXTERN: "C" int abs( int __x );	( __x -- )
EXTERN: "C" long labs( long __x );	( __x -- )
EXTERN: "C" struct div( int __numer, int __denom );	( __numer __denom -- )
EXTERN: "C" struct ldiv( long __numer, long __denom );	( __numer __denom -- )
EXTERN: "C" int mblen( char * __s, n __n );	( __s __n -- )
EXTERN: "C" int mbtowc( void * __pwc, char * __s, n __n );	( __pwc __s __n -- )
EXTERN: "C" int wctomb( void * __s, int __wchar );	( __s __wchar -- )
EXTERN: "C" n mbstowcs( void * __pwcs, char * __s, n __n );	( __pwcs __s __n -- )
EXTERN: "C" n wcstombs( void * __s, char * __pwcs, n __n );	( __s __pwcs __n -- )

\ ----===< postfix >===-----
( none )
