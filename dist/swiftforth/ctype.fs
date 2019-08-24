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
FUNCTION: __ctype_b_loc (  -- a )	( -- )
FUNCTION: __ctype_tolower_loc (  -- a )	( -- )
FUNCTION: __ctype_toupper_loc (  -- a )	( -- )
FUNCTION: isalnum (  -- n )	( <noname> -- )
FUNCTION: isalpha (  -- n )	( <noname> -- )
FUNCTION: iscntrl (  -- n )	( <noname> -- )
FUNCTION: isdigit (  -- n )	( <noname> -- )
FUNCTION: islower (  -- n )	( <noname> -- )
FUNCTION: isgraph (  -- n )	( <noname> -- )
FUNCTION: isprint (  -- n )	( <noname> -- )
FUNCTION: ispunct (  -- n )	( <noname> -- )
FUNCTION: isspace (  -- n )	( <noname> -- )
FUNCTION: isupper (  -- n )	( <noname> -- )
FUNCTION: isxdigit (  -- n )	( <noname> -- )
FUNCTION: tolower ( __c -- n )	( __c -- )
FUNCTION: toupper ( __c -- n )	( __c -- )
FUNCTION: isblank (  -- n )	( <noname> -- )

\ ----===< postfix >===-----
( none )
