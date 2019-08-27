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
#1	constant _STRINGS_H

\ ------===< functions >===-------
EXTERN: "C" int bcmp( void * __s1, void * __s2, n __n );	( __s1 __s2 __n -- )
EXTERN: "C" void bcopy( void * __src, void * __dest, n __n );	( __src __dest __n -- )
EXTERN: "C" void bzero( void * __s, n __n );	( __s __n -- )
EXTERN: "C" void * index( char * __s, int __c );	( __s __c -- )
EXTERN: "C" void * rindex( char * __s, int __c );	( __s __c -- )
EXTERN: "C" int ffs( int __i );	( __i -- )
EXTERN: "C" int strcasecmp( char * __s1, char * __s2 );	( __s1 __s2 -- )
EXTERN: "C" int strncasecmp( char * __s1, char * __s2, n __n );	( __s1 __s2 __n -- )

\ ----===< postfix >===-----
( none )
