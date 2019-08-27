\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library sys_msg
s" sys_msg" add-lib
\c #include <sys/msg.h>

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
c-function msgctl msgctl n n a -- n	( __msqid __cmd __buf -- )
c-function msgget msgget n n -- n	( __key __msgflg -- )
c-function msgrcv msgrcv n a u n n -- n	( __msqid __msgp __msgsz __msgtyp __msgflg -- )
c-function msgsnd msgsnd n a u n -- n	( __msqid __msgp __msgsz __msgflg -- )

\ ----===< postfix >===-----
end-c-library
