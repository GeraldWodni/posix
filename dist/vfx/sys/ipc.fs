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
#1	constant _SYS_IPC_H
#512	constant IPC_CREAT
#1024	constant IPC_EXCL
#2048	constant IPC_NOWAIT
#0	constant IPC_RMID
#1	constant IPC_SET
#2	constant IPC_STAT

\ -------===< structs >===--------
\ ipc_perm
begin-structure ipc_perm
	drop 26 2 +field ipc_perm-__pad2
	drop 0 4 +field ipc_perm-__key
	drop 32 8 +field ipc_perm-__glibc_reserved1
	drop 24 2 +field ipc_perm-__seq
	drop 40 8 +field ipc_perm-__glibc_reserved2
	drop 4 4 +field ipc_perm-uid
	drop 8 4 +field ipc_perm-gid
	drop 12 4 +field ipc_perm-cuid
	drop 16 4 +field ipc_perm-cgid
	drop 20 4 +field ipc_perm-mode
drop 48 end-structure

\ ------===< functions >===-------
EXTERN: "C" long ftok( char * __pathname, int __proj_id );	( __pathname __proj_id -- )

\ ----===< postfix >===-----
( none )
