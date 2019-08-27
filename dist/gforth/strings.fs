\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library strings
s" strings" add-lib
\c #include <strings.h>

\ ----===< int constants >===-----
#1	constant _STRINGS_H

\ ------===< functions >===-------
c-function bcmp bcmp a a u -- n	( __s1 __s2 __n -- )
c-function bcopy bcopy a a u -- void	( __src __dest __n -- )
c-function bzero bzero a u -- void	( __s __n -- )
c-function index index s n -- a	( __s __c -- )
c-function rindex rindex s n -- a	( __s __c -- )
c-function ffs ffs n -- n	( __i -- )
c-function strcasecmp strcasecmp s s -- n	( __s1 __s2 -- )
c-function strncasecmp strncasecmp s s u -- n	( __s1 __s2 __n -- )

\ ----===< postfix >===-----
end-c-library
