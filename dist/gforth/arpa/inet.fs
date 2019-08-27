\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library arpa_inet
s" arpa_inet" add-lib
\c #include <arpa/inet.h>

\ ----===< int constants >===-----
#1	constant _ARPA_INET_H

\ ------===< functions >===-------
c-function inet_addr inet_addr s -- n	( __cp -- )
c-function inet_lnaof inet_lnaof n -- n	( __in -- )
c-function inet_makeaddr inet_makeaddr n n -- n	( __net __host -- )
c-function inet_netof inet_netof n -- n	( __in -- )
c-function inet_network inet_network s -- n	( __cp -- )
c-function inet_ntoa inet_ntoa n -- a	( __in -- )
c-function inet_pton inet_pton n s a -- n	( __af __cp __buf -- )
c-function inet_ntop inet_ntop n a a n -- s	( __af __cp __buf __len -- )

\ ----===< postfix >===-----
end-c-library
