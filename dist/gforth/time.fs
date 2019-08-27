\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library time
s" time" add-lib
\c #include <time.h>

\ ----===< int constants >===-----
#1	constant _TIME_H
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
c-function clock clock  -- n	( -- )
c-function time time a -- n	( __timer -- )
c-function difftime difftime n n -- r	( __time1 __time0 -- )
c-function mktime mktime a -- n	( __tp -- )
c-function strftime strftime a u s a -- u	( __s __maxsize __format __tp -- )
c-function strftime_l strftime_l a u s a n -- u	( __s __maxsize __format __tp __loc -- )
c-function gmtime gmtime a -- a	( __timer -- )
c-function localtime localtime a -- a	( __timer -- )
c-function gmtime_r gmtime_r a a -- a	( __timer __tp -- )
c-function localtime_r localtime_r a a -- a	( __timer __tp -- )
c-function asctime asctime a -- a	( __tp -- )
c-function ctime ctime a -- a	( __timer -- )
c-function asctime_r asctime_r a a -- a	( __tp __buf -- )
c-function ctime_r ctime_r a a -- a	( __timer __buf -- )
c-function tzset tzset  -- void	( -- )
c-function stime stime a -- n	( __when -- )
c-function timegm timegm a -- n	( __tp -- )
c-function timelocal timelocal a -- n	( __tp -- )
c-function dysize dysize n -- n	( __year -- )
c-function nanosleep nanosleep a a -- n	( __requested_time __remaining -- )
c-function clock_getres clock_getres n a -- n	( __clock_id __res -- )
c-function clock_gettime clock_gettime n a -- n	( __clock_id __tp -- )
c-function clock_settime clock_settime n a -- n	( __clock_id __tp -- )
c-function clock_nanosleep clock_nanosleep n n a a -- n	( __clock_id __flags __req __rem -- )
c-function clock_getcpuclockid clock_getcpuclockid n a -- n	( __pid __clock_id -- )
c-function timer_create timer_create n a a -- n	( __clock_id __evp __timerid -- )
c-function timer_delete timer_delete n -- n	( __timerid -- )
c-function timer_settime timer_settime n n a a -- n	( __timerid __flags __value __ovalue -- )
c-function timer_gettime timer_gettime n a -- n	( __timerid __value -- )
c-function timer_getoverrun timer_getoverrun n -- n	( __timerid -- )

\ ----===< postfix >===-----
end-c-library
