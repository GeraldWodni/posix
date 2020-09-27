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
#1	constant _BITS_SIGNUM_GENERIC_H
#2	constant SIGINT
#4	constant SIGILL
#6	constant SIGABRT
#8	constant SIGFPE
#11	constant SIGSEGV
#15	constant SIGTERM
#1	constant SIGHUP
#3	constant SIGQUIT
#5	constant SIGTRAP
#9	constant SIGKILL
#13	constant SIGPIPE
#14	constant SIGALRM
#6	constant SIGIOT
#1	constant _BITS_SIGNUM_ARCH_H
#16	constant SIGSTKFLT
#30	constant SIGPWR
#7	constant SIGBUS
#31	constant SIGSYS
#23	constant SIGURG
#19	constant SIGSTOP
#20	constant SIGTSTP
#18	constant SIGCONT
#17	constant SIGCHLD
#21	constant SIGTTIN
#22	constant SIGTTOU
#29	constant SIGPOLL
#25	constant SIGXFSZ
#24	constant SIGXCPU
#26	constant SIGVTALRM
#27	constant SIGPROF
#10	constant SIGUSR1
#12	constant SIGUSR2
#28	constant SIGWINCH
#29	constant SIGIO
#17	constant SIGCLD
#32	constant __SIGRTMIN
#64	constant __SIGRTMAX
#1	constant __stack_t_defined
#0	constant SIG_BLOCK
#1	constant SIG_UNBLOCK
#2	constant SIG_SETMASK
#0	constant SIG_DFL
#1	constant SIG_IGN
#-1	constant SIG_ERR
#1	constant SA_NOCLDSTOP
#2	constant SA_NOCLDWAIT
#4	constant SA_SIGINFO
#134217728	constant SA_ONSTACK
#268435456	constant SA_RESTART
#1073741824	constant SA_NODEFER
#2147483648	constant SA_RESETHAND
#1	constant SS_ONSTACK
#2	constant SS_DISABLE

\ -------===< structs >===--------
\ stack_t
begin-structure stack_t
	drop 0 8 +field stack_t-ss_sp
	drop 16 8 +field stack_t-ss_size
	drop 8 4 +field stack_t-ss_flags
drop 24 end-structure

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
