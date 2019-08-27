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
FUNCTION: wctrans ( __property -- a )	( __property -- )
FUNCTION: towctrans ( __wc __desc -- n )	( __wc __desc -- )
FUNCTION: iswalnum_l ( __wc __locale -- n )	( __wc __locale -- )
FUNCTION: iswalpha_l ( __wc __locale -- n )	( __wc __locale -- )
FUNCTION: iswcntrl_l ( __wc __locale -- n )	( __wc __locale -- )
FUNCTION: iswdigit_l ( __wc __locale -- n )	( __wc __locale -- )
FUNCTION: iswgraph_l ( __wc __locale -- n )	( __wc __locale -- )
FUNCTION: iswlower_l ( __wc __locale -- n )	( __wc __locale -- )
FUNCTION: iswprint_l ( __wc __locale -- n )	( __wc __locale -- )
FUNCTION: iswpunct_l ( __wc __locale -- n )	( __wc __locale -- )
FUNCTION: iswspace_l ( __wc __locale -- n )	( __wc __locale -- )
FUNCTION: iswupper_l ( __wc __locale -- n )	( __wc __locale -- )
FUNCTION: iswxdigit_l ( __wc __locale -- n )	( __wc __locale -- )
FUNCTION: iswblank_l ( __wc __locale -- n )	( __wc __locale -- )
FUNCTION: wctype_l ( __property __locale -- n )	( __property __locale -- )
FUNCTION: iswctype_l ( __wc __desc __locale -- n )	( __wc __desc __locale -- )
FUNCTION: towlower_l ( __wc __locale -- n )	( __wc __locale -- )
FUNCTION: towupper_l ( __wc __locale -- n )	( __wc __locale -- )
FUNCTION: wctrans_l ( __property __locale -- a )	( __property __locale -- )
FUNCTION: towctrans_l ( __wc __desc __locale -- n )	( __wc __desc __locale -- )

\ ----===< postfix >===-----
( none )
