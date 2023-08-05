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
#1	constant _UTMPX_H
#32	constant __UT_LINESIZE
#32	constant __UT_NAMESIZE
#256	constant __UT_HOSTSIZE
#0	constant EMPTY
#2	constant BOOT_TIME
#3	constant NEW_TIME
#4	constant OLD_TIME
#5	constant INIT_PROCESS
#6	constant LOGIN_PROCESS
#7	constant USER_PROCESS
#8	constant DEAD_PROCESS

\ -------===< structs >===--------
\ struct __exit_status
begin-structure __exit_status
	drop 2 2 +field __exit_status-__e_exit
	drop 0 2 +field __exit_status-__e_termination
drop 4 end-structure
\ struct utmpx
begin-structure utmpx
	drop 364 20 +field utmpx-__glibc_reserved
	drop 4 4 +field utmpx-ut_pid
	drop 332 4 +field utmpx-ut_exit
	drop 0 2 +field utmpx-ut_type
	drop 44 32 +field utmpx-ut_user
	drop 8 32 +field utmpx-ut_line
	drop 336 8 +field utmpx-ut_session
	drop 340 16 +field utmpx-ut_tv
	drop 40 4 +field utmpx-ut_id
	drop 76 256 +field utmpx-ut_host
	drop 348 16 +field utmpx-ut_addr_v6
drop 384 end-structure

\ ------===< functions >===-------
EXTERN: "C" void setutxent(  );	( -- )
EXTERN: "C" void endutxent(  );	( -- )
EXTERN: "C" void * getutxent(  );	( -- )
EXTERN: "C" void * getutxid( void * __id );	( __id -- )
EXTERN: "C" void * getutxline( void * __line );	( __line -- )
EXTERN: "C" void * pututxline( void * __utmpx );	( __utmpx -- )

\ ----===< postfix >===-----
( none )
