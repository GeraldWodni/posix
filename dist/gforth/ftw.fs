\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library ftw
s" ftw" add-lib
\c #define __USE_XOPEN_EXTENDED
\c #include <ftw.h>

\ ----===< int constants >===-----
#1	constant _FTW_H

\ --------===< enums >===---------
#0	constant FTW_F
#1	constant FTW_D
#2	constant FTW_DNR
#3	constant FTW_NS
#4	constant FTW_SL
#5	constant FTW_DP
#6	constant FTW_SLN
#1	constant FTW_PHYS
#2	constant FTW_MOUNT
#4	constant FTW_CHDIR
#8	constant FTW_DEPTH

\ -------===< structs >===--------
\ struct FTW
begin-structure FTW
	drop 4 4 +field FTW-level
	drop 0 4 +field FTW-base
drop 8 end-structure

\ ------===< callbacks >===-------
c-callback __ftw_func_t: s a n -- n	( __filename __status __flag -- )
c-callback __nftw_func_t: s a n a -- n	( __filename __status __flag __info -- )

\ ------===< functions >===-------
c-function ftw ftw s a n -- n	( __dir __func __descriptors -- )
c-function nftw nftw s a n n -- n	( __dir __func __descriptors __flag -- )

\ ----===< postfix >===-----
end-c-library
