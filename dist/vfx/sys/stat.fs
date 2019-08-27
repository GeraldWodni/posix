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
#1	constant _SYS_STAT_H
#1	constant _STAT_VER
#0	constant _MKNOD_VER
#1	constant _BITS_STAT_H
#0	constant _STAT_VER_KERNEL
#1	constant _STAT_VER_LINUX
#0	constant _MKNOD_VER_LINUX
#61440	constant __S_IFMT
#16384	constant __S_IFDIR
#8192	constant __S_IFCHR
#24576	constant __S_IFBLK
#32768	constant __S_IFREG
#4096	constant __S_IFIFO
#40960	constant __S_IFLNK
#49152	constant __S_IFSOCK
#2048	constant __S_ISUID
#1024	constant __S_ISGID
#512	constant __S_ISVTX
#256	constant __S_IREAD
#128	constant __S_IWRITE
#64	constant __S_IEXEC
#61440	constant S_IFMT
#16384	constant S_IFDIR
#8192	constant S_IFCHR
#24576	constant S_IFBLK
#32768	constant S_IFREG
#4096	constant S_IFIFO
#40960	constant S_IFLNK
#49152	constant S_IFSOCK
#2048	constant S_ISUID
#1024	constant S_ISGID
#512	constant S_ISVTX
#256	constant S_IREAD
#128	constant S_IWRITE
#64	constant S_IEXEC

\ ------===< functions >===-------
EXTERN: "C" int stat( char * __file, void * __buf );	( __file __buf -- )
EXTERN: "C" int fstat( int __fd, void * __buf );	( __fd __buf -- )
EXTERN: "C" int chmod( char * __file, n __mode );	( __file __mode -- )
EXTERN: "C" n umask( n __mask );	( __mask -- )
EXTERN: "C" int mkdir( char * __path, n __mode );	( __path __mode -- )
EXTERN: "C" int mkfifo( char * __path, n __mode );	( __path __mode -- )
EXTERN: "C" int __fxstat( int __ver, int __fildes, void * __stat_buf );	( __ver __fildes __stat_buf -- )
EXTERN: "C" int __xstat( int __ver, char * __filename, void * __stat_buf );	( __ver __filename __stat_buf -- )
EXTERN: "C" int __lxstat( int __ver, char * __filename, void * __stat_buf );	( __ver __filename __stat_buf -- )
EXTERN: "C" int __fxstatat( int __ver, int __fildes, char * __filename, void * __stat_buf, int __flag );	( __ver __fildes __filename __stat_buf __flag -- )
EXTERN: "C" int __xmknod( int __ver, char * __path, n __mode, void * __dev );	( __ver __path __mode __dev -- )
EXTERN: "C" int __xmknodat( int __ver, int __fd, char * __path, n __mode, void * __dev );	( __ver __fd __path __mode __dev -- )

\ ----===< postfix >===-----
( none )
