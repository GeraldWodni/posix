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
#1	constant _ARPA_INET_H

\ ------===< functions >===-------
EXTERN: "C" long inet_addr( char * __cp );	( __cp -- )
EXTERN: "C" long inet_lnaof( long __in );	( __in -- )
EXTERN: "C" long inet_makeaddr( long __net, long __host );	( __net __host -- )
EXTERN: "C" long inet_netof( long __in );	( __in -- )
EXTERN: "C" long inet_network( char * __cp );	( __cp -- )
EXTERN: "C" void * inet_ntoa( long __in );	( __in -- )
EXTERN: "C" int inet_pton( int __af, char * __cp, void * __buf );	( __af __cp __buf -- )
EXTERN: "C" char * inet_ntop( int __af, void * __cp, void * __buf, long __len );	( __af __cp __buf __len -- )

\ ----===< postfix >===-----
( none )
