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
\c #include <asm-generic/signal-defs.h>
\c #pragma GCC diagnostic ignored "-Wint-conversion"

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
