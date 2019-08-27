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
EXTERN: "C" void * __h_errno_location(  );	( -- )
EXTERN: "C" void sethostent( int __stay_open );	( __stay_open -- )
EXTERN: "C" void endhostent(  );	( -- )
EXTERN: "C" void * gethostent(  );	( -- )
EXTERN: "C" void * gethostbyaddr( void * __addr, n __len, int __type );	( __addr __len __type -- )
EXTERN: "C" void * gethostbyname( char * __name );	( __name -- )
EXTERN: "C" void setnetent( int __stay_open );	( __stay_open -- )
EXTERN: "C" void endnetent(  );	( -- )
EXTERN: "C" void * getnetent(  );	( -- )
EXTERN: "C" void * getnetbyaddr( n __net, int __type );	( __net __type -- )
EXTERN: "C" void * getnetbyname( char * __name );	( __name -- )
EXTERN: "C" void setservent( int __stay_open );	( __stay_open -- )
EXTERN: "C" void endservent(  );	( -- )
EXTERN: "C" void * getservent(  );	( -- )
EXTERN: "C" void * getservbyname( char * __name, char * __proto );	( __name __proto -- )
EXTERN: "C" void * getservbyport( int __port, char * __proto );	( __port __proto -- )
EXTERN: "C" void setprotoent( int __stay_open );	( __stay_open -- )
EXTERN: "C" void endprotoent(  );	( -- )
EXTERN: "C" void * getprotoent(  );	( -- )
EXTERN: "C" void * getprotobyname( char * __name );	( __name -- )
EXTERN: "C" void * getprotobynumber( int __proto );	( __proto -- )

\ ----===< postfix >===-----
( none )
