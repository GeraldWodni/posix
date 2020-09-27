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
#4096	constant MSG_NOERROR

\ -------===< structs >===--------
\ msqid_ds
begin-structure msqid_ds
	drop 100 4 +field msqid_ds-msg_lrpid
	drop 112 8 +field msqid_ds-__glibc_reserved5
	drop 56 8 +field msqid_ds-msg_rtime
	drop 96 4 +field msqid_ds-msg_lspid
	drop 80 8 +field msqid_ds-msg_qnum
	drop 72 8 +field msqid_ds-__msg_cbytes
	drop 88 8 +field msqid_ds-msg_qbytes
	drop 64 8 +field msqid_ds-msg_ctime
	drop 48 8 +field msqid_ds-msg_stime
	drop 0 48 +field msqid_ds-msg_perm
	drop 104 8 +field msqid_ds-__glibc_reserved4
drop 120 end-structure

\ ------===< functions >===-------
EXTERN: "C" int msgctl( int __msqid, int __cmd, void * __buf );	( __msqid __cmd __buf -- )
EXTERN: "C" int msgget( long __key, int __msgflg );	( __key __msgflg -- )
EXTERN: "C" long msgrcv( int __msqid, void * __msgp, long __msgsz, long __msgtyp, int __msgflg );	( __msqid __msgp __msgsz __msgtyp __msgflg -- )
EXTERN: "C" int msgsnd( int __msqid, void * __msgp, long __msgsz, int __msgflg );	( __msqid __msgp __msgsz __msgflg -- )

\ ----===< postfix >===-----
( none )
