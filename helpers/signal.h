#include <asm-generic/signal-defs.h>

/* just pull scope and define, no final value required */
#undef SIG_BLOCK
#define SIG_BLOCK 42
#undef SIG_UNBLOCK
#define SIG_UNBLOCK 42
#undef SIG_SETMASK
#define SIG_SETMASK 42

#undef SIG_DFL
#define SIG_DFL 42
#undef SIG_IGN
#define SIG_IGN 42
#undef SIG_ERR
#define SIG_ERR 42

#undef SA_NOCLDSTOP
#define SA_NOCLDSTOP 42
#undef SA_NOCLDSTOP
#define SA_NOCLDSTOP 42
#undef SA_NOCLDWAIT 
#define SA_NOCLDWAIT 42
#undef SA_SIGINFO
#define SA_SIGINFO   42
#undef SA_ONSTACK
#define SA_ONSTACK   42
#undef SA_RESTART
#define SA_RESTART   42
#undef SA_NODEFER
#define SA_NODEFER   42
#undef SA_RESETHAND
#define SA_RESETHAND 42

#undef SS_ONSTACK
#define SS_ONSTACK 42
#undef SS_DISABLE
#define SS_DISABLE 42
