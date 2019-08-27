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
EXTERN: "C" void * __ctype_b_loc(  );	( -- )
EXTERN: "C" void * __ctype_tolower_loc(  );	( -- )
EXTERN: "C" void * __ctype_toupper_loc(  );	( -- )
EXTERN: "C" int isalnum( int  );	( <noname> -- )
EXTERN: "C" int isalpha( int  );	( <noname> -- )
EXTERN: "C" int iscntrl( int  );	( <noname> -- )
EXTERN: "C" int isdigit( int  );	( <noname> -- )
EXTERN: "C" int islower( int  );	( <noname> -- )
EXTERN: "C" int isgraph( int  );	( <noname> -- )
EXTERN: "C" int isprint( int  );	( <noname> -- )
EXTERN: "C" int ispunct( int  );	( <noname> -- )
EXTERN: "C" int isspace( int  );	( <noname> -- )
EXTERN: "C" int isupper( int  );	( <noname> -- )
EXTERN: "C" int isxdigit( int  );	( <noname> -- )
EXTERN: "C" int tolower( int __c );	( __c -- )
EXTERN: "C" int toupper( int __c );	( __c -- )
EXTERN: "C" int isblank( int  );	( <noname> -- )
EXTERN: "C" int isalnum_l( int , n  );	( <noname> <noname> -- )
EXTERN: "C" int isalpha_l( int , n  );	( <noname> <noname> -- )
EXTERN: "C" int iscntrl_l( int , n  );	( <noname> <noname> -- )
EXTERN: "C" int isdigit_l( int , n  );	( <noname> <noname> -- )
EXTERN: "C" int islower_l( int , n  );	( <noname> <noname> -- )
EXTERN: "C" int isgraph_l( int , n  );	( <noname> <noname> -- )
EXTERN: "C" int isprint_l( int , n  );	( <noname> <noname> -- )
EXTERN: "C" int ispunct_l( int , n  );	( <noname> <noname> -- )
EXTERN: "C" int isspace_l( int , n  );	( <noname> <noname> -- )
EXTERN: "C" int isupper_l( int , n  );	( <noname> <noname> -- )
EXTERN: "C" int isxdigit_l( int , n  );	( <noname> <noname> -- )
EXTERN: "C" int isblank_l( int , n  );	( <noname> <noname> -- )
EXTERN: "C" int __tolower_l( int __c, n __l );	( __c __l -- )
EXTERN: "C" int tolower_l( int __c, n __l );	( __c __l -- )
EXTERN: "C" int __toupper_l( int __c, n __l );	( __c __l -- )
EXTERN: "C" int toupper_l( int __c, n __l );	( __c __l -- )

\ ----===< postfix >===-----
( none )
