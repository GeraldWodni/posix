\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library errno
s" errno" add-lib
\c #include <errno.h>

\ ----===< int constants >===-----
#1	constant _ERRNO_H

\ ------===< functions >===-------
c-function __errno_location __errno_location  -- a	( -- )

\ ----===< postfix >===-----
end-c-library
