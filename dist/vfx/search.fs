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
EXTERN: "C" void insque( void * __elem, void * __prev );	( __elem __prev -- )
EXTERN: "C" void remque( void * __elem );	( __elem -- )
EXTERN: "C" void * hsearch( void * __item, int __action );	( __item __action -- )
EXTERN: "C" int hcreate( n __nel );	( __nel -- )
EXTERN: "C" void hdestroy(  );	( -- )
EXTERN: "C" void * tsearch( void * __key, void * __rootp, void * __compar );	( __key __rootp __compar -- )
EXTERN: "C" void * tfind( void * __key, void * __rootp, void * __compar );	( __key __rootp __compar -- )
EXTERN: "C" void * tdelete( void * __key, void * __rootp, void * __compar );	( __key __rootp __compar -- )
EXTERN: "C" void twalk( void * __root, void * __action );	( __root __action -- )
EXTERN: "C" void * lfind( void * __key, void * __base, void * __nmemb, n __size, void * __compar );	( __key __base __nmemb __size __compar -- )
EXTERN: "C" void * lsearch( void * __key, void * __base, void * __nmemb, n __size, void * __compar );	( __key __base __nmemb __size __compar -- )

\ ----===< postfix >===-----
( none )
