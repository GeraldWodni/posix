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
#1	constant _TIME_H
#1	constant _BITS_TIME_H
#0	constant CLOCK_REALTIME
#1	constant CLOCK_MONOTONIC
#2	constant CLOCK_PROCESS_CPUTIME_ID
#3	constant CLOCK_THREAD_CPUTIME_ID
#4	constant CLOCK_MONOTONIC_RAW
#5	constant CLOCK_REALTIME_COARSE
#6	constant CLOCK_MONOTONIC_COARSE
#7	constant CLOCK_BOOTTIME
#8	constant CLOCK_REALTIME_ALARM
#9	constant CLOCK_BOOTTIME_ALARM
#11	constant CLOCK_TAI
#1	constant TIMER_ABSTIME
#1	constant __struct_tm_defined

\ -------===< structs >===--------
\ tm
begin-structure tm
	drop 12 4 +field tm-tm_mday
	drop 16 4 +field tm-tm_mon
	drop 20 4 +field tm-tm_year
	drop 32 4 +field tm-tm_isdst
	drop 0 4 +field tm-tm_sec
	drop 24 4 +field tm-tm_wday
	drop 40 8 +field tm-tm_gmtoff
	drop 4 4 +field tm-tm_min
	drop 48 8 +field tm-tm_zone
	drop 28 4 +field tm-tm_yday
	drop 8 4 +field tm-tm_hour
drop 56 end-structure

\ ------===< functions >===-------
FUNCTION: clock (  -- n )	( -- )
FUNCTION: time ( __timer -- n )	( __timer -- )
FUNCTION: difftime ( __time1 __time0 -- r )	( __time1 __time0 -- )
FUNCTION: mktime ( __tp -- n )	( __tp -- )
FUNCTION: strftime ( __s __maxsize __format __tp -- u )	( __s __maxsize __format __tp -- )
FUNCTION: strftime_l ( __s __maxsize __format __tp __loc -- u )	( __s __maxsize __format __tp __loc -- )
FUNCTION: gmtime ( __timer -- a )	( __timer -- )
FUNCTION: localtime ( __timer -- a )	( __timer -- )
FUNCTION: gmtime_r ( __timer __tp -- a )	( __timer __tp -- )
FUNCTION: localtime_r ( __timer __tp -- a )	( __timer __tp -- )
FUNCTION: asctime ( __tp -- a )	( __tp -- )
FUNCTION: ctime ( __timer -- a )	( __timer -- )
FUNCTION: asctime_r ( __tp __buf -- a )	( __tp __buf -- )
FUNCTION: ctime_r ( __timer __buf -- a )	( __timer __buf -- )
FUNCTION: tzset (  -- void )	( -- )
FUNCTION: stime ( __when -- n )	( __when -- )
FUNCTION: timegm ( __tp -- n )	( __tp -- )
FUNCTION: timelocal ( __tp -- n )	( __tp -- )
FUNCTION: dysize ( __year -- n )	( __year -- )
FUNCTION: nanosleep ( __requested_time __remaining -- n )	( __requested_time __remaining -- )
FUNCTION: clock_getres ( __clock_id __res -- n )	( __clock_id __res -- )
FUNCTION: clock_gettime ( __clock_id __tp -- n )	( __clock_id __tp -- )
FUNCTION: clock_settime ( __clock_id __tp -- n )	( __clock_id __tp -- )
FUNCTION: clock_nanosleep ( __clock_id __flags __req __rem -- n )	( __clock_id __flags __req __rem -- )
FUNCTION: clock_getcpuclockid ( __pid __clock_id -- n )	( __pid __clock_id -- )
FUNCTION: timer_create ( __clock_id __evp __timerid -- n )	( __clock_id __evp __timerid -- )
FUNCTION: timer_delete ( __timerid -- n )	( __timerid -- )
FUNCTION: timer_settime ( __timerid __flags __value __ovalue -- n )	( __timerid __flags __value __ovalue -- )
FUNCTION: timer_gettime ( __timerid __value -- n )	( __timerid __value -- )
FUNCTION: timer_getoverrun ( __timerid -- n )	( __timerid -- )

\ ----===< postfix >===-----
( none )
