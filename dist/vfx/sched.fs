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
#1	constant _SCHED_H

\ ------===< functions >===-------
EXTERN: "C" int sched_setparam( n __pid, void * __param );	( __pid __param -- )
EXTERN: "C" int sched_getparam( n __pid, void * __param );	( __pid __param -- )
EXTERN: "C" int sched_setscheduler( n __pid, int __policy, void * __param );	( __pid __policy __param -- )
EXTERN: "C" int sched_getscheduler( n __pid );	( __pid -- )
EXTERN: "C" int sched_yield(  );	( -- )
EXTERN: "C" int sched_get_priority_max( int __algorithm );	( __algorithm -- )
EXTERN: "C" int sched_get_priority_min( int __algorithm );	( __algorithm -- )
EXTERN: "C" int sched_rr_get_interval( n __pid, void * __t );	( __pid __t -- )

\ ----===< postfix >===-----
( none )
