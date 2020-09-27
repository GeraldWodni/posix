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
#1	constant _MONETARY_H

\ ------===< functions >===-------
EXTERN: "C" long strfmon( void * __s, long __maxsize, char * __format, ...  );	( __s __maxsize __format <noname> -- )
EXTERN: "C" long strfmon_l( void * __s, long __maxsize, long __loc, char * __format, ...  );	( __s __maxsize __loc __format <noname> -- )

\ ----===< postfix >===-----
( none )
