\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library monetary
s" monetary" add-lib
\c #include <monetary.h>

\ ----===< int constants >===-----
#1	constant _MONETARY_H

\ ------===< functions >===-------
c-function strfmon strfmon a u s ... -- n	( __s __maxsize __format <noname> -- )
c-function strfmon_l strfmon_l a u n s ... -- n	( __s __maxsize __loc __format <noname> -- )

\ ----===< postfix >===-----
end-c-library
