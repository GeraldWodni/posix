\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library stdlib
s" stdlib" add-lib
\c #include <stdlib.h>

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
c-callback __compar_fn_t: a a -- n	( <noname> <noname> -- )

\ ------===< functions >===-------
c-function __ctype_get_mb_cur_max __ctype_get_mb_cur_max  -- u	( -- )
c-function atof atof s -- r	( __nptr -- )
c-function atoi atoi s -- n	( __nptr -- )
c-function atol atol s -- n	( __nptr -- )
c-function atoll atoll s -- d	( __nptr -- )
c-function strtod strtod s a -- r	( __nptr __endptr -- )
c-function strtof strtof s a -- r	( __nptr __endptr -- )
c-function strtold strtold s a -- r	( __nptr __endptr -- )
c-function strtol strtol s a n -- n	( __nptr __endptr __base -- )
c-function strtoul strtoul s a n -- u	( __nptr __endptr __base -- )
c-function strtoll strtoll s a n -- d	( __nptr __endptr __base -- )
c-function strtoull strtoull s a n -- ud	( __nptr __endptr __base -- )
c-function rand rand  -- n	( -- )
c-function srand srand u -- void	( __seed -- )
c-function malloc malloc u -- a	( __size -- )
c-function calloc calloc u u -- a	( __nmemb __size -- )
c-function realloc realloc a u -- a	( __ptr __size -- )
c-function free free a -- void	( __ptr -- )
c-function posix_memalign posix_memalign a u u -- n	( __memptr __alignment __size -- )
c-function abort abort  -- void	( -- )
c-function atexit atexit a -- n	( __func -- )
c-function exit exit n -- void	( __status -- )
c-function _Exit _Exit n -- void	( __status -- )
c-function getenv getenv s -- a	( __name -- )
c-function setenv setenv s s n -- n	( __name __value __replace -- )
c-function unsetenv unsetenv s -- n	( __name -- )
c-function mkstemp mkstemp a -- n	( __template -- )
c-function mkdtemp mkdtemp a -- a	( __template -- )
c-function system system s -- n	( __command -- )
c-function bsearch bsearch a a u u a -- a	( __key __base __nmemb __size __compar -- )
c-function qsort qsort a u u a -- void	( __base __nmemb __size __compar -- )
c-function abs abs n -- n	( __x -- )
c-function labs labs n -- n	( __x -- )
c-function llabs llabs d -- d	( __x -- )
c-function div div n n -- struct	( __numer __denom -- )
c-function ldiv ldiv n n -- struct	( __numer __denom -- )
c-function lldiv lldiv d d -- struct	( __numer __denom -- )
c-function mblen mblen s u -- n	( __s __n -- )
c-function mbtowc mbtowc a s u -- n	( __pwc __s __n -- )
c-function wctomb wctomb a n -- n	( __s __wchar -- )
c-function mbstowcs mbstowcs a s u -- u	( __pwcs __s __n -- )
c-function wcstombs wcstombs a ws u -- u	( __s __pwcs __n -- )
c-function getsubopt getsubopt a a a -- n	( __optionp __tokens __valuep -- )

\ ----===< postfix >===-----
end-c-library
