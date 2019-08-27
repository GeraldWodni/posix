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
#1	constant _WCTYPE_H
#4294967295	constant WEOF

\ ------===< functions >===-------
EXTERN: "C" void * wctrans( char * __property );	( __property -- )
EXTERN: "C" n towctrans( n __wc, void * __desc );	( __wc __desc -- )
EXTERN: "C" int iswalnum_l( n __wc, n __locale );	( __wc __locale -- )
EXTERN: "C" int iswalpha_l( n __wc, n __locale );	( __wc __locale -- )
EXTERN: "C" int iswcntrl_l( n __wc, n __locale );	( __wc __locale -- )
EXTERN: "C" int iswdigit_l( n __wc, n __locale );	( __wc __locale -- )
EXTERN: "C" int iswgraph_l( n __wc, n __locale );	( __wc __locale -- )
EXTERN: "C" int iswlower_l( n __wc, n __locale );	( __wc __locale -- )
EXTERN: "C" int iswprint_l( n __wc, n __locale );	( __wc __locale -- )
EXTERN: "C" int iswpunct_l( n __wc, n __locale );	( __wc __locale -- )
EXTERN: "C" int iswspace_l( n __wc, n __locale );	( __wc __locale -- )
EXTERN: "C" int iswupper_l( n __wc, n __locale );	( __wc __locale -- )
EXTERN: "C" int iswxdigit_l( n __wc, n __locale );	( __wc __locale -- )
EXTERN: "C" int iswblank_l( n __wc, n __locale );	( __wc __locale -- )
EXTERN: "C" n wctype_l( char * __property, n __locale );	( __property __locale -- )
EXTERN: "C" int iswctype_l( n __wc, n __desc, n __locale );	( __wc __desc __locale -- )
EXTERN: "C" n towlower_l( n __wc, n __locale );	( __wc __locale -- )
EXTERN: "C" n towupper_l( n __wc, n __locale );	( __wc __locale -- )
EXTERN: "C" void * wctrans_l( char * __property, n __locale );	( __property __locale -- )
EXTERN: "C" n towctrans_l( n __wc, void * __desc, n __locale );	( __wc __desc __locale -- )

\ ----===< postfix >===-----
( none )
