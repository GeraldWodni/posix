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
FUNCTION: bcmp ( __s1 __s2 __n -- n )	( __s1 __s2 __n -- )
FUNCTION: bcopy ( __src __dest __n -- void )	( __src __dest __n -- )
FUNCTION: bzero ( __s __n -- void )	( __s __n -- )
FUNCTION: index ( __s __c -- a )	( __s __c -- )
FUNCTION: rindex ( __s __c -- a )	( __s __c -- )
FUNCTION: ffs ( __i -- n )	( __i -- )
FUNCTION: strcasecmp ( __s1 __s2 -- n )	( __s1 __s2 -- )
FUNCTION: strncasecmp ( __s1 __s2 __n -- n )	( __s1 __s2 __n -- )

\ ----===< postfix >===-----
( none )
