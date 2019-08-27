\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library wctype
s" wctype" add-lib
\c #include <wctype.h>

\ ----===< int constants >===-----
#1	constant _WCTYPE_H
#4294967295	constant WEOF

\ ------===< functions >===-------
c-function wctrans wctrans s -- a	( __property -- )
c-function towctrans towctrans n a -- n	( __wc __desc -- )
c-function iswalnum_l iswalnum_l n n -- n	( __wc __locale -- )
c-function iswalpha_l iswalpha_l n n -- n	( __wc __locale -- )
c-function iswcntrl_l iswcntrl_l n n -- n	( __wc __locale -- )
c-function iswdigit_l iswdigit_l n n -- n	( __wc __locale -- )
c-function iswgraph_l iswgraph_l n n -- n	( __wc __locale -- )
c-function iswlower_l iswlower_l n n -- n	( __wc __locale -- )
c-function iswprint_l iswprint_l n n -- n	( __wc __locale -- )
c-function iswpunct_l iswpunct_l n n -- n	( __wc __locale -- )
c-function iswspace_l iswspace_l n n -- n	( __wc __locale -- )
c-function iswupper_l iswupper_l n n -- n	( __wc __locale -- )
c-function iswxdigit_l iswxdigit_l n n -- n	( __wc __locale -- )
c-function iswblank_l iswblank_l n n -- n	( __wc __locale -- )
c-function wctype_l wctype_l s n -- n	( __property __locale -- )
c-function iswctype_l iswctype_l n n n -- n	( __wc __desc __locale -- )
c-function towlower_l towlower_l n n -- n	( __wc __locale -- )
c-function towupper_l towupper_l n n -- n	( __wc __locale -- )
c-function wctrans_l wctrans_l s n -- a	( __property __locale -- )
c-function towctrans_l towctrans_l n a n -- n	( __wc __desc __locale -- )

\ ----===< postfix >===-----
end-c-library
