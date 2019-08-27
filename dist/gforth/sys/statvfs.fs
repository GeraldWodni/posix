\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library sys_statvfs
s" sys_statvfs" add-lib
\c #include <sys/statvfs.h>

\ ----===< int constants >===-----
#1	constant _SYS_STATVFS_H

\ --------===< enums >===---------
#1	constant ST_RDONLY
#2	constant ST_NOSUID

\ ------===< functions >===-------
c-function statvfs statvfs s a -- n	( __file __buf -- )
c-function fstatvfs fstatvfs n a -- n	( __fildes __buf -- )

\ ----===< postfix >===-----
end-c-library
