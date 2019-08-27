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
#1	constant _WORDEXP_H

\ --------===< enums >===---------
#1	constant WRDE_DOOFFS
#2	constant WRDE_APPEND
#4	constant WRDE_NOCMD
#8	constant WRDE_REUSE
#16	constant WRDE_SHOWERR
#32	constant WRDE_UNDEF
#63	constant __WRDE_FLAGS
#1	constant WRDE_NOSPACE
#2	constant WRDE_BADCHAR
#3	constant WRDE_BADVAL
#4	constant WRDE_CMDSUB
#5	constant WRDE_SYNTAX

\ -------===< structs >===--------
\ wordexp_t
begin-structure wordexp_t
	drop 8 8 +field wordexp_t-we_wordv
	drop 0 8 +field wordexp_t-we_wordc
	drop 16 8 +field wordexp_t-we_offs
drop 24 end-structure

\ ------===< functions >===-------
FUNCTION: wordexp ( __words __pwordexp __flags -- n )	( __words __pwordexp __flags -- )
FUNCTION: wordfree ( __wordexp -- void )	( __wordexp -- )

\ ----===< postfix >===-----
( none )
