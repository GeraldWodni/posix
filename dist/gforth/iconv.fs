\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library iconv
s" iconv" add-lib
\c #include <iconv.h>

\ ----===< int constants >===-----
#1	constant _ICONV_H

\ ------===< functions >===-------
c-function iconv_open iconv_open s s -- a	( __tocode __fromcode -- )
c-function iconv iconv a a a a a -- u	( __cd __inbuf __inbytesleft __outbuf __outbytesleft -- )
c-function iconv_close iconv_close a -- n	( __cd -- )

\ ----===< postfix >===-----
end-c-library
