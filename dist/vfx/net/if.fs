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
#1	constant _NET_IF_H
#16	constant IF_NAMESIZE

\ -------===< structs >===--------
\ if_nameindex
begin-structure if_nameindex
	drop 0 4 +field if_nameindex-if_index
	drop 8 8 +field if_nameindex-if_name
drop 16 end-structure

\ ------===< functions >===-------
EXTERN: "C" int if_nametoindex( char * __ifname );	( __ifname -- )
EXTERN: "C" void * if_indextoname( int __ifindex, void * __ifname );	( __ifindex __ifname -- )
EXTERN: "C" void if_freenameindex( void * __ptr );	( __ptr -- )

\ ----===< postfix >===-----
( none )
