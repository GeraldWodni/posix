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
c-function kill kill n n -- n	( __pid __sig -- )
c-function raise raise n -- n	( __sig -- )
c-function psignal psignal n s -- void	( __sig __s -- )
c-function psiginfo psiginfo a s -- void	( __pinfo __s -- )
c-function sigemptyset sigemptyset a -- n	( __set -- )
c-function sigfillset sigfillset a -- n	( __set -- )
c-function sigaddset sigaddset a n -- n	( __set __signo -- )
c-function sigdelset sigdelset a n -- n	( __set __signo -- )
c-function sigismember sigismember a n -- n	( __set __signo -- )
c-function sigprocmask sigprocmask n a a -- n	( __how __set __oset -- )
c-function sigsuspend sigsuspend a -- n	( __set -- )
c-function sigaction sigaction n a a -- n	( __sig __act __oact -- )
c-function sigpending sigpending a -- n	( __set -- )
c-function sigwaitinfo sigwaitinfo a a -- n	( __set __info -- )
c-function sigtimedwait sigtimedwait a a a -- n	( __set __info __timeout -- )
c-function sigqueue sigqueue n n n -- n	( __pid __sig __val -- )
c-function __libc_current_sigrtmin __libc_current_sigrtmin  -- n	( -- )
c-function __libc_current_sigrtmax __libc_current_sigrtmax  -- n	( -- )

\ ----===< postfix >===-----
end-c-library
