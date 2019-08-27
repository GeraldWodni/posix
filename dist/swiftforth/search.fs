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
#1	constant _SEARCH_H

\ --------===< enums >===---------
#0	constant FIND
#1	constant ENTER
#0	constant preorder
#1	constant postorder
#2	constant endorder
#3	constant leaf

\ -------===< structs >===--------
\ ENTRY
begin-structure ENTRY
	drop 8 8 +field ENTRY-data
	drop 0 8 +field ENTRY-key
drop 16 end-structure

\ ------===< callbacks >===-------
	( <noname> <noname> -- )
	( __nodep __value __level -- )

\ ------===< functions >===-------
FUNCTION: insque ( __elem __prev -- void )	( __elem __prev -- )
FUNCTION: remque ( __elem -- void )	( __elem -- )
FUNCTION: hsearch ( __item __action -- a )	( __item __action -- )
FUNCTION: hcreate ( __nel -- n )	( __nel -- )
FUNCTION: hdestroy (  -- void )	( -- )
FUNCTION: tsearch ( __key __rootp __compar -- a )	( __key __rootp __compar -- )
FUNCTION: tfind ( __key __rootp __compar -- a )	( __key __rootp __compar -- )
FUNCTION: tdelete ( __key __rootp __compar -- a )	( __key __rootp __compar -- )
FUNCTION: twalk ( __root __action -- void )	( __root __action -- )
FUNCTION: lfind ( __key __base __nmemb __size __compar -- a )	( __key __base __nmemb __size __compar -- )
FUNCTION: lsearch ( __key __base __nmemb __size __compar -- a )	( __key __base __nmemb __size __compar -- )

\ ----===< postfix >===-----
( none )
