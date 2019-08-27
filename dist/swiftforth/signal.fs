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
#7	constant SIGBUS
#31	constant SIGSYS
#13	constant SIGPIPE
#14	constant SIGALRM
#23	constant SIGURG
#19	constant SIGSTOP
#20	constant SIGTSTP
#18	constant SIGCONT
#17	constant SIGCHLD
#21	constant SIGTTIN
#22	constant SIGTTOU
#29	constant SIGPOLL
#24	constant SIGXCPU
#25	constant SIGXFSZ
#26	constant SIGVTALRM
#27	constant SIGPROF
#10	constant SIGUSR1
#12	constant SIGUSR2
#28	constant SIGWINCH
#29	constant SIGIO
#6	constant SIGIOT
#17	constant SIGCLD
#32	constant __SIGRTMIN
#64	constant __SIGRTMAX
#65	constant _NSIG
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
