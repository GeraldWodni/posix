\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library fcntl
s" fcntl" add-lib
\c #include <fcntl.h>
\c #define HAVE_ARCH_STRUCT_FLOCK
\c #include <asm/fcntl.h>

\ ----===< int constants >===-----
#1	constant _FCNTL_H
#0	constant SEEK_SET
#1	constant SEEK_CUR
#2	constant SEEK_END
#3	constant O_ACCMODE
#0	constant O_RDONLY
#1	constant O_WRONLY
#2	constant O_RDWR
#64	constant O_CREAT
#128	constant O_EXCL
#256	constant O_NOCTTY
#512	constant O_TRUNC
#1024	constant O_APPEND
#2048	constant O_NONBLOCK
#4096	constant O_DSYNC
#8192	constant FASYNC
#16384	constant O_DIRECT
#32768	constant O_LARGEFILE
#65536	constant O_DIRECTORY
#131072	constant O_NOFOLLOW
#262144	constant O_NOATIME
#524288	constant O_CLOEXEC
#1052672	constant O_SYNC
#2097152	constant O_PATH
#4259840	constant __O_TMPFILE
#4259840	constant O_TMPFILE
#4259904	constant O_TMPFILE_MASK
#2048	constant O_NDELAY
#0	constant F_DUPFD
#1	constant F_GETFD
#2	constant F_SETFD
#3	constant F_GETFL
#4	constant F_SETFL
#5	constant F_GETLK
#6	constant F_SETLK
#7	constant F_SETLKW
#8	constant F_SETOWN
#9	constant F_GETOWN
#10	constant F_SETSIG
#11	constant F_GETSIG
#5	constant F_GETLK64
#6	constant F_SETLK64
#7	constant F_SETLKW64
#15	constant F_SETOWN_EX
#16	constant F_GETOWN_EX
#17	constant F_GETOWNER_UIDS
#36	constant F_OFD_GETLK
#37	constant F_OFD_SETLK
#38	constant F_OFD_SETLKW
#0	constant F_OWNER_TID
#1	constant F_OWNER_PID
#2	constant F_OWNER_PGRP
#1	constant FD_CLOEXEC
#0	constant F_RDLCK
#1	constant F_WRLCK
#2	constant F_UNLCK
#4	constant F_EXLCK
#8	constant F_SHLCK
#1	constant LOCK_SH
#2	constant LOCK_EX
#4	constant LOCK_NB
#8	constant LOCK_UN
#32	constant LOCK_MAND
#64	constant LOCK_READ
#128	constant LOCK_WRITE
#192	constant LOCK_RW
#1024	constant F_LINUX_SPECIFIC_BASE

\ -------===< structs >===--------
\ f_owner_ex
begin-structure f_owner_ex
	drop 4 4 +field f_owner_ex-pid
	drop 0 4 +field f_owner_ex-type
drop 8 end-structure
\ flock
begin-structure flock
	drop 0 2 +field flock-l_type
	drop 8 8 +field flock-l_start
	drop 16 8 +field flock-l_len
	drop 24 4 +field flock-l_pid
	drop 2 2 +field flock-l_whence
drop 32 end-structure
\ flock64
begin-structure flock64
	drop 0 2 +field flock64-l_type
	drop 8 8 +field flock64-l_start
	drop 16 8 +field flock64-l_len
	drop 24 4 +field flock64-l_pid
	drop 2 2 +field flock64-l_whence
drop 32 end-structure

\ ------===< functions >===-------
c-function fcntl fcntl n n ... -- n	( __fd __cmd <noname> -- )
c-function open open s n ... -- n	( __file __oflag <noname> -- )
c-function creat creat s n -- n	( __file __mode -- )
c-function posix_fadvise posix_fadvise n n n n -- n	( __fd __offset __len __advise -- )
c-function posix_fallocate posix_fallocate n n n -- n	( __fd __offset __len -- )

\ ----===< postfix >===-----
end-c-library
