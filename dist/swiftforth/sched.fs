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
#1	constant _BITS_SCHED_H
#0	constant SCHED_OTHER
#1	constant SCHED_FIFO
#2	constant SCHED_RR
#1	constant _BITS_TYPES_STRUCT_SCHED_PARAM

\ -------===< structs >===--------
\ struct sched_param
begin-structure sched_param
	drop 0 4 +field sched_param-sched_priority
drop 4 end-structure

\ ------===< functions >===-------
FUNCTION: sched_setparam ( __pid __param -- n )	( __pid __param -- )
FUNCTION: sched_getparam ( __pid __param -- n )	( __pid __param -- )
FUNCTION: sched_setscheduler ( __pid __policy __param -- n )	( __pid __policy __param -- )
FUNCTION: sched_getscheduler ( __pid -- n )	( __pid -- )
FUNCTION: sched_yield (  -- n )	( -- )
FUNCTION: sched_get_priority_max ( __algorithm -- n )	( __algorithm -- )
FUNCTION: sched_get_priority_min ( __algorithm -- n )	( __algorithm -- )
FUNCTION: sched_rr_get_interval ( __pid __t -- n )	( __pid __t -- )

\ ----===< postfix >===-----
( none )
