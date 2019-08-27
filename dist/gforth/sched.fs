\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library sched
s" sched" add-lib
\c #include <sched.h>

\ ----===< int constants >===-----
#1	constant _SCHED_H

\ ------===< functions >===-------
c-function sched_setparam sched_setparam n a -- n	( __pid __param -- )
c-function sched_getparam sched_getparam n a -- n	( __pid __param -- )
c-function sched_setscheduler sched_setscheduler n n a -- n	( __pid __policy __param -- )
c-function sched_getscheduler sched_getscheduler n -- n	( __pid -- )
c-function sched_yield sched_yield  -- n	( -- )
c-function sched_get_priority_max sched_get_priority_max n -- n	( __algorithm -- )
c-function sched_get_priority_min sched_get_priority_min n -- n	( __algorithm -- )
c-function sched_rr_get_interval sched_rr_get_interval n a -- n	( __pid __t -- )

\ ----===< postfix >===-----
end-c-library
