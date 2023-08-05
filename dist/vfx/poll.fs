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
#1	constant _SYS_POLL_H
#1	constant POLLIN
#2	constant POLLPRI
#4	constant POLLOUT
#64	constant POLLRDNORM
#128	constant POLLRDBAND
#256	constant POLLWRNORM
#512	constant POLLWRBAND
#8	constant POLLERR
#16	constant POLLHUP
#32	constant POLLNVAL

\ -------===< structs >===--------
\ struct pollfd
begin-structure pollfd
	drop 0 4 +field pollfd-fd
	drop 4 2 +field pollfd-events
	drop 6 2 +field pollfd-revents
drop 8 end-structure

\ ------===< functions >===-------
EXTERN: "C" int poll( void * __fds, long __nfds, int __timeout );	( __fds __nfds __timeout -- )

\ ----===< postfix >===-----
( none )
