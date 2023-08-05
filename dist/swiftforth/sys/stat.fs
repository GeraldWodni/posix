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
#1	constant _BITS_STAT_H
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
FUNCTION: stat ( __file __buf -- n )	( __file __buf -- )
FUNCTION: fstat ( __fd __buf -- n )	( __fd __buf -- )
FUNCTION: lstat ( __file __buf -- n )	( __file __buf -- )
FUNCTION: chmod ( __file __mode -- n )	( __file __mode -- )
FUNCTION: fchmod ( __fd __mode -- n )	( __fd __mode -- )
FUNCTION: umask ( __mask -- n )	( __mask -- )
FUNCTION: mkdir ( __path __mode -- n )	( __path __mode -- )
FUNCTION: mkfifo ( __path __mode -- n )	( __path __mode -- )
FUNCTION: futimens ( __fd __times -- n )	( __fd __times -- )

\ ----===< postfix >===-----
( none )
