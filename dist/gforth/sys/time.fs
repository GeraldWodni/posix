\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library sys_time
s" sys_time" add-lib
\c #include <sys/time.h>

\ ----===< int constants >===-----
#1	constant _SYS_TIME_H

\ --------===< enums >===---------
#0	constant ITIMER_REAL
#1	constant ITIMER_VIRTUAL
#2	constant ITIMER_PROF

\ -------===< structs >===--------
\ itimerval
begin-structure itimerval
	drop 16 16 +field itimerval-it_value
	drop 0 16 +field itimerval-it_interval
drop 32 end-structure

\ ------===< functions >===-------
c-function gettimeofday gettimeofday a a -- n	( __tv __tz -- )
c-function getitimer getitimer n a -- n	( __which __value -- )
c-function setitimer setitimer n a a -- n	( __which __new __old -- )
c-function utimes utimes s a -- n	( __file __tvp -- )

\ ----===< postfix >===-----
end-c-library
