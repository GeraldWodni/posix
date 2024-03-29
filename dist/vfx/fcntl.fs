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
\ struct f_owner_ex
begin-structure f_owner_ex
	drop 4 4 +field f_owner_ex-pid
	drop 0 4 +field f_owner_ex-type
drop 8 end-structure

\ ------===< functions >===-------
EXTERN: "C" int fcntl( int __fd, int __cmd, ...  );	( __fd __cmd <noname> -- )
EXTERN: "C" int open( char * __file, int __oflag, ...  );	( __file __oflag <noname> -- )
EXTERN: "C" int creat( char * __file, long __mode );	( __file __mode -- )
EXTERN: "C" int posix_fadvise( int __fd, long __offset, long __len, int __advise );	( __fd __offset __len __advise -- )
EXTERN: "C" int posix_fallocate( int __fd, long __offset, long __len );	( __fd __offset __len -- )

\ ----===< postfix >===-----
( none )
