\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library ctype
s" ctype" add-lib
\c #include <ctype.h>

\ ----===< int constants >===-----
#1	constant _CTYPE_H

\ --------===< enums >===---------
#256	constant _ISupper
#512	constant _ISlower
#1024	constant _ISalpha
#2048	constant _ISdigit
#4096	constant _ISxdigit
#8192	constant _ISspace
#16384	constant _ISprint
#32768	constant _ISgraph
#1	constant _ISblank
#2	constant _IScntrl
#4	constant _ISpunct
#8	constant _ISalnum

\ ------===< functions >===-------
c-function __ctype_b_loc __ctype_b_loc  -- a	( -- )
c-function __ctype_tolower_loc __ctype_tolower_loc  -- a	( -- )
c-function __ctype_toupper_loc __ctype_toupper_loc  -- a	( -- )
c-function isalnum isalnum n -- n	( <noname> -- )
c-function isalpha isalpha n -- n	( <noname> -- )
c-function iscntrl iscntrl n -- n	( <noname> -- )
c-function isdigit isdigit n -- n	( <noname> -- )
c-function islower islower n -- n	( <noname> -- )
c-function isgraph isgraph n -- n	( <noname> -- )
c-function isprint isprint n -- n	( <noname> -- )
c-function ispunct ispunct n -- n	( <noname> -- )
c-function isspace isspace n -- n	( <noname> -- )
c-function isupper isupper n -- n	( <noname> -- )
c-function isxdigit isxdigit n -- n	( <noname> -- )
c-function tolower tolower n -- n	( __c -- )
c-function toupper toupper n -- n	( __c -- )
c-function isblank isblank n -- n	( <noname> -- )

\ ----===< postfix >===-----
end-c-library
