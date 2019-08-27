\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library netdb
s" netdb" add-lib
\c #include <netdb.h>

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
c-function __h_errno_location __h_errno_location  -- a	( -- )
c-function sethostent sethostent n -- void	( __stay_open -- )
c-function endhostent endhostent  -- void	( -- )
c-function gethostent gethostent  -- a	( -- )
c-function gethostbyaddr gethostbyaddr a n n -- a	( __addr __len __type -- )
c-function gethostbyname gethostbyname s -- a	( __name -- )
c-function setnetent setnetent n -- void	( __stay_open -- )
c-function endnetent endnetent  -- void	( -- )
c-function getnetent getnetent  -- a	( -- )
c-function getnetbyaddr getnetbyaddr n n -- a	( __net __type -- )
c-function getnetbyname getnetbyname s -- a	( __name -- )
c-function setservent setservent n -- void	( __stay_open -- )
c-function endservent endservent  -- void	( -- )
c-function getservent getservent  -- a	( -- )
c-function getservbyname getservbyname s s -- a	( __name __proto -- )
c-function getservbyport getservbyport n s -- a	( __port __proto -- )
c-function setprotoent setprotoent n -- void	( __stay_open -- )
c-function endprotoent endprotoent  -- void	( -- )
c-function getprotoent getprotoent  -- a	( -- )
c-function getprotobyname getprotobyname s -- a	( __name -- )
c-function getprotobynumber getprotobynumber n -- a	( __proto -- )

\ ----===< postfix >===-----
end-c-library
