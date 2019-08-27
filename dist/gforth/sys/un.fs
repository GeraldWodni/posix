\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library sys_un
s" sys_un" add-lib
\c #include <sys/un.h>

\ ----===< int constants >===-----
#1	constant _BITS_SOCKADDR_H
#128	constant _SS_SIZE

\ -------===< structs >===--------
\ sockaddr_un
begin-structure sockaddr_un
	drop 2 108 +field sockaddr_un-sun_path
	drop 0 2 +field sockaddr_un-sun_family
drop 110 end-structure

\ ----===< postfix >===-----
end-c-library
