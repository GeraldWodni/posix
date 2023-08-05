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
#1	constant _SYS_RESOURCE_H
#-20	constant PRIO_MIN
#20	constant PRIO_MAX

\ --------===< enums >===---------
#0	constant RLIMIT_CPU
#1	constant RLIMIT_FSIZE
#2	constant RLIMIT_DATA
#3	constant RLIMIT_STACK
#4	constant RLIMIT_CORE
#5	constant __RLIMIT_RSS
#7	constant RLIMIT_NOFILE
#7	constant __RLIMIT_OFILE
#9	constant RLIMIT_AS
#6	constant __RLIMIT_NPROC
#8	constant __RLIMIT_MEMLOCK
#10	constant __RLIMIT_LOCKS
#11	constant __RLIMIT_SIGPENDING
#12	constant __RLIMIT_MSGQUEUE
#13	constant __RLIMIT_NICE
#14	constant __RLIMIT_RTPRIO
#15	constant __RLIMIT_RTTIME
#16	constant __RLIMIT_NLIMITS
#16	constant __RLIM_NLIMITS
#0	constant RUSAGE_SELF
#-1	constant RUSAGE_CHILDREN
#0	constant PRIO_PROCESS
#1	constant PRIO_PGRP
#2	constant PRIO_USER

\ -------===< structs >===--------
\ struct rlimit
begin-structure rlimit
	drop 0 8 +field rlimit-rlim_cur
	drop 8 8 +field rlimit-rlim_max
drop 16 end-structure

\ ------===< functions >===-------
EXTERN: "C" int getrlimit( int __resource, void * __rlimits );	( __resource __rlimits -- )
EXTERN: "C" int setrlimit( int __resource, void * __rlimits );	( __resource __rlimits -- )
EXTERN: "C" int getrusage( int __who, void * __usage );	( __who __usage -- )
EXTERN: "C" int getpriority( int __which, long __who );	( __which __who -- )
EXTERN: "C" int setpriority( int __which, long __who, int __prio );	( __which __who __prio -- )

\ ----===< postfix >===-----
( none )
