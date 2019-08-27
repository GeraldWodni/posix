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
#1	constant _SYS_STATVFS_H

\ --------===< enums >===---------
#1	constant ST_RDONLY
#2	constant ST_NOSUID

\ ------===< functions >===-------
FUNCTION: statvfs ( __file __buf -- n )	( __file __buf -- )
FUNCTION: fstatvfs ( __fildes __buf -- n )	( __fildes __buf -- )

\ ----===< postfix >===-----
( none )
