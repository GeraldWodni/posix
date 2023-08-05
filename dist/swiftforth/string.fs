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
#1	constant _STRING_H

\ ------===< functions >===-------
FUNCTION: memcpy ( __dest __src __n -- a )	( __dest __src __n -- )
FUNCTION: memmove ( __dest __src __n -- a )	( __dest __src __n -- )
FUNCTION: memset ( __s __c __n -- a )	( __s __c __n -- )
FUNCTION: memcmp ( __s1 __s2 __n -- n )	( __s1 __s2 __n -- )
FUNCTION: __memcmpeq ( __s1 __s2 __n -- n )	( __s1 __s2 __n -- )
FUNCTION: memchr ( __s __c __n -- a )	( __s __c __n -- )
FUNCTION: strcpy ( __dest __src -- a )	( __dest __src -- )
FUNCTION: strncpy ( __dest __src __n -- a )	( __dest __src __n -- )
FUNCTION: strcat ( __dest __src -- a )	( __dest __src -- )
FUNCTION: strncat ( __dest __src __n -- a )	( __dest __src __n -- )
FUNCTION: strcmp ( __s1 __s2 -- n )	( __s1 __s2 -- )
FUNCTION: strncmp ( __s1 __s2 __n -- n )	( __s1 __s2 __n -- )
FUNCTION: strcoll ( __s1 __s2 -- n )	( __s1 __s2 -- )
FUNCTION: strxfrm ( __dest __src __n -- u )	( __dest __src __n -- )
FUNCTION: strcoll_l ( __s1 __s2 __l -- n )	( __s1 __s2 __l -- )
FUNCTION: strxfrm_l ( __dest __src __n __l -- u )	( __dest __src __n __l -- )
FUNCTION: strchr ( __s __c -- a )	( __s __c -- )
FUNCTION: strrchr ( __s __c -- a )	( __s __c -- )
FUNCTION: strcspn ( __s __reject -- u )	( __s __reject -- )
FUNCTION: strspn ( __s __accept -- u )	( __s __accept -- )
FUNCTION: strpbrk ( __s __accept -- a )	( __s __accept -- )
FUNCTION: strstr ( __haystack __needle -- a )	( __haystack __needle -- )
FUNCTION: strtok ( __s __delim -- a )	( __s __delim -- )
FUNCTION: __strtok_r ( __s __delim __save_ptr -- a )	( __s __delim __save_ptr -- )
FUNCTION: strtok_r ( __s __delim __save_ptr -- a )	( __s __delim __save_ptr -- )
FUNCTION: strlen ( __s -- u )	( __s -- )
FUNCTION: strnlen ( __string __maxlen -- u )	( __string __maxlen -- )
FUNCTION: strerror ( __errnum -- a )	( __errnum -- )
FUNCTION: __xpg_strerror_r ( __errnum __buf __buflen -- n )	( __errnum __buf __buflen -- )
FUNCTION: strerror_l ( __errnum __l -- a )	( __errnum __l -- )
FUNCTION: strsignal ( __sig -- a )	( __sig -- )
FUNCTION: __stpcpy ( __dest __src -- a )	( __dest __src -- )
FUNCTION: stpcpy ( __dest __src -- a )	( __dest __src -- )
FUNCTION: __stpncpy ( __dest __src __n -- a )	( __dest __src __n -- )
FUNCTION: stpncpy ( __dest __src __n -- a )	( __dest __src __n -- )

\ ----===< postfix >===-----
( none )
