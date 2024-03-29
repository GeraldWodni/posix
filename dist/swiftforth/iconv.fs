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
#1	constant _ICONV_H

\ ------===< functions >===-------
FUNCTION: iconv_close ( __cd -- n )	( __cd -- )
FUNCTION: iconv_open ( __tocode __fromcode -- a )	( __tocode __fromcode -- )
FUNCTION: iconv ( __cd __inbuf __inbytesleft __outbuf __outbytesleft -- u )	( __cd __inbuf __inbytesleft __outbuf __outbytesleft -- )

\ ----===< postfix >===-----
( none )
