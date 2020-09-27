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
#1	constant _SYS_SEM_H
#4096	constant SEM_UNDO
#11	constant GETPID
#12	constant GETVAL
#13	constant GETALL
#14	constant GETNCNT
#15	constant GETZCNT
#16	constant SETVAL
#17	constant SETALL
#1	constant _SEM_SEMUN_UNDEFINED

\ -------===< structs >===--------
\ sembuf
begin-structure sembuf
	drop 0 2 +field sembuf-sem_num
	drop 2 2 +field sembuf-sem_op
	drop 4 2 +field sembuf-sem_flg
drop 6 end-structure
\ semid_ds
begin-structure semid_ds
	drop 56 8 +field semid_ds-__sem_otime_high
	drop 72 8 +field semid_ds-__sem_ctime_high
	drop 48 8 +field semid_ds-sem_otime
	drop 0 48 +field semid_ds-sem_perm
	drop 64 8 +field semid_ds-sem_ctime
	drop 80 8 +field semid_ds-sem_nsems
	drop 88 8 +field semid_ds-__glibc_reserved3
	drop 96 8 +field semid_ds-__glibc_reserved4
drop 104 end-structure

\ ------===< functions >===-------
EXTERN: "C" int semctl( int __semid, int __semnum, int __cmd, ...  );	( __semid __semnum __cmd <noname> -- )
EXTERN: "C" int semget( long __key, int __nsems, int __semflg );	( __key __nsems __semflg -- )
EXTERN: "C" int semop( int __semid, void * __sops, long __nsops );	( __semid __sops __nsops -- )

\ ----===< postfix >===-----
( none )
