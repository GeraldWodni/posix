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
EXTERN: "C" void * memcpy( void * __dest, void * __src, n __n );	( __dest __src __n -- )
EXTERN: "C" void * memmove( void * __dest, void * __src, n __n );	( __dest __src __n -- )
EXTERN: "C" void * memset( void * __s, int __c, n __n );	( __s __c __n -- )
EXTERN: "C" int memcmp( void * __s1, void * __s2, n __n );	( __s1 __s2 __n -- )
EXTERN: "C" void * memchr( void * __s, int __c, n __n );	( __s __c __n -- )
EXTERN: "C" void * strcpy( void * __dest, char * __src );	( __dest __src -- )
EXTERN: "C" void * strncpy( void * __dest, char * __src, n __n );	( __dest __src __n -- )
EXTERN: "C" void * strcat( void * __dest, char * __src );	( __dest __src -- )
EXTERN: "C" void * strncat( void * __dest, char * __src, n __n );	( __dest __src __n -- )
EXTERN: "C" int strcmp( char * __s1, char * __s2 );	( __s1 __s2 -- )
EXTERN: "C" int strncmp( char * __s1, char * __s2, n __n );	( __s1 __s2 __n -- )
EXTERN: "C" int strcoll( char * __s1, char * __s2 );	( __s1 __s2 -- )
EXTERN: "C" n strxfrm( void * __dest, char * __src, n __n );	( __dest __src __n -- )
EXTERN: "C" void * strchr( char * __s, int __c );	( __s __c -- )
EXTERN: "C" void * strrchr( char * __s, int __c );	( __s __c -- )
EXTERN: "C" n strcspn( char * __s, char * __reject );	( __s __reject -- )
EXTERN: "C" n strspn( char * __s, char * __accept );	( __s __accept -- )
EXTERN: "C" void * strpbrk( char * __s, char * __accept );	( __s __accept -- )
EXTERN: "C" void * strstr( char * __haystack, char * __needle );	( __haystack __needle -- )
EXTERN: "C" void * strtok( void * __s, char * __delim );	( __s __delim -- )
EXTERN: "C" void * __strtok_r( void * __s, char * __delim, void * __save_ptr );	( __s __delim __save_ptr -- )
EXTERN: "C" n strlen( char * __s );	( __s -- )
EXTERN: "C" void * strerror( int __errnum );	( __errnum -- )

\ ----===< postfix >===-----
( none )
