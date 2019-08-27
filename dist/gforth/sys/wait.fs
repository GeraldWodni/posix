\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library sys_wait
s" sys_wait" add-lib
\c #include <sys/wait.h>

\ ----===< int constants >===-----
#1	constant _SYS_WAIT_H
#1	constant WNOHANG
#2	constant WUNTRACED
#2	constant WSTOPPED
#4	constant WEXITED
#8	constant WCONTINUED
#16777216	constant WNOWAIT
#536870912	constant __WNOTHREAD
#1073741824	constant __WALL
#2147483648	constant __WCLONE
#65535	constant __W_CONTINUED
#128	constant __WCOREFLAG

\ --------===< enums >===---------
#0	constant P_ALL
#1	constant P_PID
#2	constant P_PGID

\ ------===< functions >===-------
c-function wait wait a -- n	( __stat_loc -- )
c-function waitpid waitpid n a n -- n	( __pid __stat_loc __options -- )
c-function waitid waitid n n a n -- n	( __idtype __id __infop __options -- )

\ ----===< postfix >===-----
end-c-library
