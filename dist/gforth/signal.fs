\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library signal
s" signal" add-lib
\c #include <signal.h>

\ ------===< callbacks >===-------
c-callback __sighandler_t: n -- void	( <noname> -- )

\ ------===< functions >===-------
c-function __sysv_signal __sysv_signal n a -- a	( __sig __handler -- )
c-function raise raise n -- n	( __sig -- )
c-function __libc_current_sigrtmin __libc_current_sigrtmin  -- n	( -- )
c-function __libc_current_sigrtmax __libc_current_sigrtmax  -- n	( -- )

\ ----===< postfix >===-----
end-c-library
