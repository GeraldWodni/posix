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
FUNCTION: inet_addr ( __cp -- n )	( __cp -- )
FUNCTION: inet_lnaof ( __in -- n )	( __in -- )
FUNCTION: inet_makeaddr ( __net __host -- n )	( __net __host -- )
FUNCTION: inet_netof ( __in -- n )	( __in -- )
FUNCTION: inet_network ( __cp -- n )	( __cp -- )
FUNCTION: inet_ntoa ( __in -- a )	( __in -- )
FUNCTION: inet_pton ( __af __cp __buf -- n )	( __af __cp __buf -- )
FUNCTION: inet_ntop ( __af __cp __buf __len -- s )	( __af __cp __buf __len -- )

\ ----===< postfix >===-----
( none )
