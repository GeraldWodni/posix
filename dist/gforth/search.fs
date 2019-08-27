\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library search
s" search" add-lib
\c #define __USE_MISC
\c #include <search.h>

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
c-callback __compar_fn_t: a a -- n	( <noname> <noname> -- )
c-callback __action_fn_t: a n n -- void	( __nodep __value __level -- )

\ ------===< functions >===-------
c-function insque insque a a -- void	( __elem __prev -- )
c-function remque remque a -- void	( __elem -- )
c-function hsearch hsearch a{*(ENTRY*)} n -- a	( __item __action -- )
c-function hcreate hcreate u -- n	( __nel -- )
c-function hdestroy hdestroy  -- void	( -- )
c-function tsearch tsearch a a a -- a	( __key __rootp __compar -- )
c-function tfind tfind a a a -- a	( __key __rootp __compar -- )
c-function tdelete tdelete a a a -- a	( __key __rootp __compar -- )
c-function twalk twalk a a -- void	( __root __action -- )
c-function lfind lfind a a a u a -- a	( __key __base __nmemb __size __compar -- )
c-function lsearch lsearch a a a u a -- a	( __key __base __nmemb __size __compar -- )

\ ----===< postfix >===-----
end-c-library
