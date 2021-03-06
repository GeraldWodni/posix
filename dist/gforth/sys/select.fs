\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library sys_select
s" sys_select" add-lib
\c #include <sys/select.h>

\ ----===< int constants >===-----
#1	constant _SYS_SELECT_H

\ -------===< structs >===--------
\ fd_set
begin-structure fd_set
	drop 0 128 +field fd_set-__fds_bits
drop 128 end-structure

\ ------===< functions >===-------
c-function select select n a a a a -- n	( __nfds __readfds __writefds __exceptfds __timeout -- )
c-function pselect pselect n a a a a a -- n	( __nfds __readfds __writefds __exceptfds __timeout __sigmask -- )

\ ----===< postfix >===-----
end-c-library
