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

\ ------===< functions >===-------
FUNCTION: fcntl ( __fd __cmd  -- n )	( __fd __cmd <noname> -- )
FUNCTION: open ( __file __oflag  -- n )	( __file __oflag <noname> -- )
FUNCTION: creat ( __file __mode -- n )	( __file __mode -- )
FUNCTION: posix_fadvise ( __fd __offset __len __advise -- n )	( __fd __offset __len __advise -- )
FUNCTION: posix_fallocate ( __fd __offset __len -- n )	( __fd __offset __len -- )

\ ----===< postfix >===-----
( none )
