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
#1024	constant IPPORT_RESERVED
#1	constant AI_PASSIVE
#2	constant AI_CANONNAME
#4	constant AI_NUMERICHOST
#8	constant AI_V4MAPPED
#16	constant AI_ALL
#32	constant AI_ADDRCONFIG
#1024	constant AI_NUMERICSERV
#-1	constant EAI_BADFLAGS
#-2	constant EAI_NONAME
#-3	constant EAI_AGAIN
#-4	constant EAI_FAIL
#-6	constant EAI_FAMILY
#-7	constant EAI_SOCKTYPE
#-8	constant EAI_SERVICE
#-10	constant EAI_MEMORY
#-11	constant EAI_SYSTEM
#-12	constant EAI_OVERFLOW
#1	constant NI_NUMERICHOST
#2	constant NI_NUMERICSERV
#4	constant NI_NOFQDN
#8	constant NI_NAMEREQD
#16	constant NI_DGRAM

\ -------===< structs >===--------
\ struct hostent
begin-structure hostent
	drop 16 4 +field hostent-h_addrtype
	drop 8 8 +field hostent-h_aliases
	drop 24 8 +field hostent-h_addr_list
	drop 20 4 +field hostent-h_length
	drop 0 8 +field hostent-h_name
drop 32 end-structure
\ struct servent
begin-structure servent
	drop 0 8 +field servent-s_name
	drop 8 8 +field servent-s_aliases
	drop 16 4 +field servent-s_port
	drop 24 8 +field servent-s_proto
drop 32 end-structure
\ struct protoent
begin-structure protoent
	drop 16 4 +field protoent-p_proto
	drop 0 8 +field protoent-p_name
	drop 8 8 +field protoent-p_aliases
drop 24 end-structure
\ struct addrinfo
begin-structure addrinfo
	drop 0 4 +field addrinfo-ai_flags
	drop 32 8 +field addrinfo-ai_canonname
	drop 8 4 +field addrinfo-ai_socktype
	drop 40 8 +field addrinfo-ai_next
	drop 4 4 +field addrinfo-ai_family
	drop 12 4 +field addrinfo-ai_protocol
	drop 24 8 +field addrinfo-ai_addr
	drop 16 4 +field addrinfo-ai_addrlen
drop 48 end-structure

\ ------===< functions >===-------
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
FUNCTION: getaddrinfo ( __name __service __req __pai -- n )	( __name __service __req __pai -- )
FUNCTION: freeaddrinfo ( __ai -- void )	( __ai -- )
FUNCTION: gai_strerror ( __ecode -- s )	( __ecode -- )
FUNCTION: getnameinfo ( __sa __salen __host __hostlen __serv __servlen __flags -- n )	( __sa __salen __host __hostlen __serv __servlen __flags -- )

\ ----===< postfix >===-----
( none )
