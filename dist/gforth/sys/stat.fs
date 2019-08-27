\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library sys_stat
s" sys_stat" add-lib
\c #include <sys/stat.h>

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
c-function stat stat s a -- n	( __file __buf -- )
c-function fstat fstat n a -- n	( __fd __buf -- )
c-function lstat lstat s a -- n	( __file __buf -- )
c-function chmod chmod s n -- n	( __file __mode -- )
c-function fchmod fchmod n n -- n	( __fd __mode -- )
c-function umask umask n -- n	( __mask -- )
c-function mkdir mkdir s n -- n	( __path __mode -- )
c-function mkfifo mkfifo s n -- n	( __path __mode -- )
c-function futimens futimens n a -- n	( __fd __times -- )
c-function __fxstat __fxstat n n a -- n	( __ver __fildes __stat_buf -- )
c-function __xstat __xstat n s a -- n	( __ver __filename __stat_buf -- )
c-function __lxstat __lxstat n s a -- n	( __ver __filename __stat_buf -- )
c-function __fxstatat __fxstatat n n s a n -- n	( __ver __fildes __filename __stat_buf __flag -- )
c-function __xmknod __xmknod n s n a -- n	( __ver __path __mode __dev -- )
c-function __xmknodat __xmknodat n n s n a -- n	( __ver __fd __path __mode __dev -- )

\ ----===< postfix >===-----
end-c-library
