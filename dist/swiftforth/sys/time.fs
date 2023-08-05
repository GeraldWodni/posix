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
#1	constant _SYS_TIME_H

\ --------===< enums >===---------
#0	constant ITIMER_REAL
#1	constant ITIMER_VIRTUAL
#2	constant ITIMER_PROF

\ -------===< structs >===--------
\ struct itimerval
begin-structure itimerval
	drop 16 16 +field itimerval-it_value
	drop 0 16 +field itimerval-it_interval
drop 32 end-structure

\ ------===< functions >===-------
FUNCTION: gettimeofday ( __tv __tz -- n )	( __tv __tz -- )
FUNCTION: getitimer ( __which __value -- n )	( __which __value -- )
FUNCTION: setitimer ( __which __new __old -- n )	( __which __new __old -- )
FUNCTION: utimes ( __file __tvp -- n )	( __file __tvp -- )

\ ----===< postfix >===-----
( none )
