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

\ ----===< int constants >===-----
#1	constant _FCNTL_H
#0	constant SEEK_SET
#1	constant SEEK_CUR
#2	constant SEEK_END

\ ------===< functions >===-------
c-function fcntl fcntl n n ... -- n	( __fd __cmd <noname> -- )
c-function open open s n ... -- n	( __file __oflag <noname> -- )
c-function creat creat s n -- n	( __file __mode -- )
c-function posix_fadvise posix_fadvise n n n n -- n	( __fd __offset __len __advise -- )
c-function posix_fallocate posix_fallocate n n n -- n	( __fd __offset __len -- )

\ ----===< postfix >===-----
end-c-library
