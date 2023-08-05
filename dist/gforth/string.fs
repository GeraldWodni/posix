\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library string
s" string" add-lib
\c #include <string.h>

\ ----===< int constants >===-----
#1	constant _STRING_H

\ ------===< functions >===-------
c-function memcpy memcpy a a u -- a	( __dest __src __n -- )
c-function memmove memmove a a u -- a	( __dest __src __n -- )
c-function memset memset a n u -- a	( __s __c __n -- )
c-function memcmp memcmp a a u -- n	( __s1 __s2 __n -- )
c-function __memcmpeq __memcmpeq a a u -- n	( __s1 __s2 __n -- )
c-function memchr memchr a n u -- a	( __s __c __n -- )
c-function strcpy strcpy a s -- a	( __dest __src -- )
c-function strncpy strncpy a s u -- a	( __dest __src __n -- )
c-function strcat strcat a s -- a	( __dest __src -- )
c-function strncat strncat a s u -- a	( __dest __src __n -- )
c-function strcmp strcmp s s -- n	( __s1 __s2 -- )
c-function strncmp strncmp s s u -- n	( __s1 __s2 __n -- )
c-function strcoll strcoll s s -- n	( __s1 __s2 -- )
c-function strxfrm strxfrm a s u -- u	( __dest __src __n -- )
c-function strcoll_l strcoll_l s s n -- n	( __s1 __s2 __l -- )
c-function strxfrm_l strxfrm_l a s u n -- u	( __dest __src __n __l -- )
c-function strchr strchr s n -- a	( __s __c -- )
c-function strrchr strrchr s n -- a	( __s __c -- )
c-function strcspn strcspn s s -- u	( __s __reject -- )
c-function strspn strspn s s -- u	( __s __accept -- )
c-function strpbrk strpbrk s s -- a	( __s __accept -- )
c-function strstr strstr s s -- a	( __haystack __needle -- )
c-function strtok strtok a s -- a	( __s __delim -- )
c-function __strtok_r __strtok_r a s a -- a	( __s __delim __save_ptr -- )
c-function strtok_r strtok_r a s a -- a	( __s __delim __save_ptr -- )
c-function strlen strlen s -- u	( __s -- )
c-function strnlen strnlen s u -- u	( __string __maxlen -- )
c-function strerror strerror n -- a	( __errnum -- )
c-function __xpg_strerror_r __xpg_strerror_r n a u -- n	( __errnum __buf __buflen -- )
c-function strerror_l strerror_l n n -- a	( __errnum __l -- )
c-function strsignal strsignal n -- a	( __sig -- )
c-function __stpcpy __stpcpy a s -- a	( __dest __src -- )
c-function stpcpy stpcpy a s -- a	( __dest __src -- )
c-function __stpncpy __stpncpy a s u -- a	( __dest __src __n -- )
c-function stpncpy stpncpy a s u -- a	( __dest __src __n -- )

\ ----===< postfix >===-----
end-c-library
