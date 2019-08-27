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
#1	constant _NETDB_H
#1	constant HOST_NOT_FOUND
#2	constant TRY_AGAIN
#3	constant NO_RECOVERY
#4	constant NO_DATA

\ -------===< structs >===--------
\ hostent
begin-structure hostent
	drop 16 4 +field hostent-h_addrtype
	drop 8 8 +field hostent-h_aliases
	drop 24 8 +field hostent-h_addr_list
	drop 20 4 +field hostent-h_length
	drop 0 8 +field hostent-h_name
drop 32 end-structure
\ servent
begin-structure servent
	drop 0 8 +field servent-s_name
	drop 8 8 +field servent-s_aliases
	drop 16 4 +field servent-s_port
	drop 24 8 +field servent-s_proto
drop 32 end-structure
\ protoent
begin-structure protoent
	drop 16 4 +field protoent-p_proto
	drop 0 8 +field protoent-p_name
	drop 8 8 +field protoent-p_aliases
drop 24 end-structure

\ ------===< functions >===-------
FUNCTION: __h_errno_location (  -- a )	( -- )
FUNCTION: sethostent ( __stay_open -- void )	( __stay_open -- )
FUNCTION: endhostent (  -- void )	( -- )
FUNCTION: gethostent (  -- a )	( -- )
FUNCTION: gethostbyaddr ( __addr __len __type -- a )	( __addr __len __type -- )
FUNCTION: gethostbyname ( __name -- a )	( __name -- )
FUNCTION: setnetent ( __stay_open -- void )	( __stay_open -- )
FUNCTION: endnetent (  -- void )	( -- )
FUNCTION: getnetent (  -- a )	( -- )
FUNCTION: getnetbyaddr ( __net __type -- a )	( __net __type -- )
FUNCTION: getnetbyname ( __name -- a )	( __name -- )
FUNCTION: setservent ( __stay_open -- void )	( __stay_open -- )
FUNCTION: endservent (  -- void )	( -- )
FUNCTION: getservent (  -- a )	( -- )
FUNCTION: getservbyname ( __name __proto -- a )	( __name __proto -- )
FUNCTION: getservbyport ( __port __proto -- a )	( __port __proto -- )
FUNCTION: setprotoent ( __stay_open -- void )	( __stay_open -- )
FUNCTION: endprotoent (  -- void )	( -- )
FUNCTION: getprotoent (  -- a )	( -- )
FUNCTION: getprotobyname ( __name -- a )	( __name -- )
FUNCTION: getprotobynumber ( __proto -- a )	( __proto -- )

\ ----===< postfix >===-----
( none )
