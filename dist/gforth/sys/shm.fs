\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library sys_shm
s" sys_shm" add-lib
\c #include <sys/shm.h>

\ ----===< int constants >===-----
#1	constant _SYS_SHM_H
#256	constant SHM_R
#128	constant SHM_W
#4096	constant SHM_RDONLY
#8192	constant SHM_RND
#16384	constant SHM_REMAP
#32768	constant SHM_EXEC
#11	constant SHM_LOCK
#12	constant SHM_UNLOCK

\ -------===< structs >===--------
\ struct shmid_ds
begin-structure shmid_ds
	drop 96 8 +field shmid_ds-__glibc_reserved5
	drop 64 8 +field shmid_ds-shm_dtime
	drop 104 8 +field shmid_ds-__glibc_reserved6
	drop 48 8 +field shmid_ds-shm_segsz
	drop 56 8 +field shmid_ds-shm_atime
	drop 72 8 +field shmid_ds-shm_ctime
	drop 80 4 +field shmid_ds-shm_cpid
	drop 88 8 +field shmid_ds-shm_nattch
	drop 0 48 +field shmid_ds-shm_perm
	drop 84 4 +field shmid_ds-shm_lpid
drop 112 end-structure

\ ------===< functions >===-------
c-function shmctl shmctl n n a -- n	( __shmid __cmd __buf -- )
c-function shmget shmget n u n -- n	( __key __size __shmflg -- )
c-function shmat shmat n a n -- a	( __shmid __shmaddr __shmflg -- )
c-function shmdt shmdt a -- n	( __shmaddr -- )

\ ----===< postfix >===-----
end-c-library
