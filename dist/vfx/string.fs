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
EXTERN: "C" void * memcpy( void * __dest, void * __src, long __n );	( __dest __src __n -- )
EXTERN: "C" void * memmove( void * __dest, void * __src, long __n );	( __dest __src __n -- )
EXTERN: "C" void * memset( void * __s, int __c, long __n );	( __s __c __n -- )
EXTERN: "C" int memcmp( void * __s1, void * __s2, long __n );	( __s1 __s2 __n -- )
EXTERN: "C" int __memcmpeq( void * __s1, void * __s2, long __n );	( __s1 __s2 __n -- )
EXTERN: "C" void * memchr( void * __s, int __c, long __n );	( __s __c __n -- )
EXTERN: "C" void * strcpy( void * __dest, char * __src );	( __dest __src -- )
EXTERN: "C" void * strncpy( void * __dest, char * __src, long __n );	( __dest __src __n -- )
EXTERN: "C" void * strcat( void * __dest, char * __src );	( __dest __src -- )
EXTERN: "C" void * strncat( void * __dest, char * __src, long __n );	( __dest __src __n -- )
EXTERN: "C" int strcmp( char * __s1, char * __s2 );	( __s1 __s2 -- )
EXTERN: "C" int strncmp( char * __s1, char * __s2, long __n );	( __s1 __s2 __n -- )
EXTERN: "C" int strcoll( char * __s1, char * __s2 );	( __s1 __s2 -- )
EXTERN: "C" long strxfrm( void * __dest, char * __src, long __n );	( __dest __src __n -- )
EXTERN: "C" int strcoll_l( char * __s1, char * __s2, long __l );	( __s1 __s2 __l -- )
EXTERN: "C" long strxfrm_l( void * __dest, char * __src, long __n, long __l );	( __dest __src __n __l -- )
EXTERN: "C" void * strchr( char * __s, int __c );	( __s __c -- )
EXTERN: "C" void * strrchr( char * __s, int __c );	( __s __c -- )
EXTERN: "C" long strcspn( char * __s, char * __reject );	( __s __reject -- )
EXTERN: "C" long strspn( char * __s, char * __accept );	( __s __accept -- )
EXTERN: "C" void * strpbrk( char * __s, char * __accept );	( __s __accept -- )
EXTERN: "C" void * strstr( char * __haystack, char * __needle );	( __haystack __needle -- )
EXTERN: "C" void * strtok( void * __s, char * __delim );	( __s __delim -- )
EXTERN: "C" void * __strtok_r( void * __s, char * __delim, void * __save_ptr );	( __s __delim __save_ptr -- )
EXTERN: "C" void * strtok_r( void * __s, char * __delim, void * __save_ptr );	( __s __delim __save_ptr -- )
EXTERN: "C" long strlen( char * __s );	( __s -- )
EXTERN: "C" long strnlen( char * __string, long __maxlen );	( __string __maxlen -- )
EXTERN: "C" void * strerror( int __errnum );	( __errnum -- )
EXTERN: "C" int __xpg_strerror_r( int __errnum, void * __buf, long __buflen );	( __errnum __buf __buflen -- )
EXTERN: "C" void * strerror_l( int __errnum, long __l );	( __errnum __l -- )
EXTERN: "C" void * strsignal( int __sig );	( __sig -- )
EXTERN: "C" void * __stpcpy( void * __dest, char * __src );	( __dest __src -- )
EXTERN: "C" void * stpcpy( void * __dest, char * __src );	( __dest __src -- )
EXTERN: "C" void * __stpncpy( void * __dest, char * __src, long __n );	( __dest __src __n -- )
EXTERN: "C" void * stpncpy( void * __dest, char * __src, long __n );	( __dest __src __n -- )

\ ----===< postfix >===-----
( none )
