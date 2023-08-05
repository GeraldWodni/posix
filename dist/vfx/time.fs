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
\ struct tm
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
EXTERN: "C" long clock(  );	( -- )
EXTERN: "C" long time( void * __timer );	( __timer -- )
EXTERN: "C" double difftime( long __time1, long __time0 );	( __time1 __time0 -- )
EXTERN: "C" long mktime( void * __tp );	( __tp -- )
EXTERN: "C" long strftime( void * __s, long __maxsize, char * __format, void * __tp );	( __s __maxsize __format __tp -- )
EXTERN: "C" long strftime_l( void * __s, long __maxsize, char * __format, void * __tp, long __loc );	( __s __maxsize __format __tp __loc -- )
EXTERN: "C" void * gmtime( void * __timer );	( __timer -- )
EXTERN: "C" void * localtime( void * __timer );	( __timer -- )
EXTERN: "C" void * gmtime_r( void * __timer, void * __tp );	( __timer __tp -- )
EXTERN: "C" void * localtime_r( void * __timer, void * __tp );	( __timer __tp -- )
EXTERN: "C" void * asctime( void * __tp );	( __tp -- )
EXTERN: "C" void * ctime( void * __timer );	( __timer -- )
EXTERN: "C" void * asctime_r( void * __tp, void * __buf );	( __tp __buf -- )
EXTERN: "C" void * ctime_r( void * __timer, void * __buf );	( __timer __buf -- )
EXTERN: "C" void tzset(  );	( -- )
EXTERN: "C" long timegm( void * __tp );	( __tp -- )
EXTERN: "C" long timelocal( void * __tp );	( __tp -- )
EXTERN: "C" int dysize( int __year );	( __year -- )
EXTERN: "C" int nanosleep( void * __requested_time, void * __remaining );	( __requested_time __remaining -- )
EXTERN: "C" int clock_getres( long __clock_id, void * __res );	( __clock_id __res -- )
EXTERN: "C" int clock_gettime( long __clock_id, void * __tp );	( __clock_id __tp -- )
EXTERN: "C" int clock_settime( long __clock_id, void * __tp );	( __clock_id __tp -- )
EXTERN: "C" int clock_nanosleep( long __clock_id, int __flags, void * __req, void * __rem );	( __clock_id __flags __req __rem -- )
EXTERN: "C" int clock_getcpuclockid( long __pid, void * __clock_id );	( __pid __clock_id -- )
EXTERN: "C" int timer_create( long __clock_id, void * __evp, void * __timerid );	( __clock_id __evp __timerid -- )
EXTERN: "C" int timer_delete( long __timerid );	( __timerid -- )
EXTERN: "C" int timer_settime( long __timerid, int __flags, void * __value, void * __ovalue );	( __timerid __flags __value __ovalue -- )
EXTERN: "C" int timer_gettime( long __timerid, void * __value );	( __timerid __value -- )
EXTERN: "C" int timer_getoverrun( long __timerid );	( __timerid -- )

\ ----===< postfix >===-----
( none )
