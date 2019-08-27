\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library poll
s" poll" add-lib
\c #include <poll.h>

\ ----===< int constants >===-----
#1	constant _SYS_POLL_H

\ -------===< structs >===--------
\ pollfd
begin-structure pollfd
	drop 0 4 +field pollfd-fd
	drop 4 2 +field pollfd-events
	drop 6 2 +field pollfd-revents
drop 8 end-structure

\ ------===< functions >===-------
c-function poll poll a u n -- n	( __fds __nfds __timeout -- )

\ ----===< postfix >===-----
end-c-library