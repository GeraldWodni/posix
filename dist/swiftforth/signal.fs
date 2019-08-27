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

\ ------===< callbacks >===-------
	( <noname> -- )

\ ------===< functions >===-------
FUNCTION: __sysv_signal ( __sig __handler -- a )	( __sig __handler -- )
FUNCTION: kill ( __pid __sig -- n )	( __pid __sig -- )
FUNCTION: raise ( __sig -- n )	( __sig -- )
FUNCTION: psignal ( __sig __s -- void )	( __sig __s -- )
FUNCTION: psiginfo ( __pinfo __s -- void )	( __pinfo __s -- )
FUNCTION: sigemptyset ( __set -- n )	( __set -- )
FUNCTION: sigfillset ( __set -- n )	( __set -- )
FUNCTION: sigaddset ( __set __signo -- n )	( __set __signo -- )
FUNCTION: sigdelset ( __set __signo -- n )	( __set __signo -- )
FUNCTION: sigismember ( __set __signo -- n )	( __set __signo -- )
FUNCTION: sigprocmask ( __how __set __oset -- n )	( __how __set __oset -- )
FUNCTION: sigsuspend ( __set -- n )	( __set -- )
FUNCTION: sigaction ( __sig __act __oact -- n )	( __sig __act __oact -- )
FUNCTION: sigpending ( __set -- n )	( __set -- )
FUNCTION: sigwaitinfo ( __set __info -- n )	( __set __info -- )
FUNCTION: sigtimedwait ( __set __info __timeout -- n )	( __set __info __timeout -- )
FUNCTION: sigqueue ( __pid __sig __val -- n )	( __pid __sig __val -- )
FUNCTION: __libc_current_sigrtmin (  -- n )	( -- )
FUNCTION: __libc_current_sigrtmax (  -- n )	( -- )

\ ----===< postfix >===-----
( none )
