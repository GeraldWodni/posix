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
#1	constant _SYS_TIMES_H

\ -------===< structs >===--------
\ struct tms
begin-structure tms
	drop 16 8 +field tms-tms_cutime
	drop 8 8 +field tms-tms_stime
	drop 0 8 +field tms-tms_utime
	drop 24 8 +field tms-tms_cstime
drop 32 end-structure

\ ------===< functions >===-------
FUNCTION: times ( __buffer -- n )	( __buffer -- )

\ ----===< postfix >===-----
( none )
