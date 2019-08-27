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
EXTERN: "C" void * __sysv_signal( int __sig, void * __handler );	( __sig __handler -- )
EXTERN: "C" int kill( n __pid, int __sig );	( __pid __sig -- )
EXTERN: "C" int raise( int __sig );	( __sig -- )
EXTERN: "C" void psignal( int __sig, char * __s );	( __sig __s -- )
EXTERN: "C" void psiginfo( void * __pinfo, char * __s );	( __pinfo __s -- )
EXTERN: "C" int sigemptyset( void * __set );	( __set -- )
EXTERN: "C" int sigfillset( void * __set );	( __set -- )
EXTERN: "C" int sigaddset( void * __set, int __signo );	( __set __signo -- )
EXTERN: "C" int sigdelset( void * __set, int __signo );	( __set __signo -- )
EXTERN: "C" int sigismember( void * __set, int __signo );	( __set __signo -- )
EXTERN: "C" int sigprocmask( int __how, void * __set, void * __oset );	( __how __set __oset -- )
EXTERN: "C" int sigsuspend( void * __set );	( __set -- )
EXTERN: "C" int sigaction( int __sig, void * __act, void * __oact );	( __sig __act __oact -- )
EXTERN: "C" int sigpending( void * __set );	( __set -- )
EXTERN: "C" int sigwaitinfo( void * __set, void * __info );	( __set __info -- )
EXTERN: "C" int sigtimedwait( void * __set, void * __info, void * __timeout );	( __set __info __timeout -- )
EXTERN: "C" int sigqueue( n __pid, int __sig, n __val );	( __pid __sig __val -- )
EXTERN: "C" int __libc_current_sigrtmin(  );	( -- )
EXTERN: "C" int __libc_current_sigrtmax(  );	( -- )

\ ----===< postfix >===-----
( none )
