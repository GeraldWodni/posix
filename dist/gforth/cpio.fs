\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library cpio
s" cpio" add-lib
\c #include <cpio.h>

\ ----===< int constants >===-----
#1	constant _CPIO_H
#256	constant C_IRUSR
#128	constant C_IWUSR
#64	constant C_IXUSR
#32	constant C_IRGRP
#16	constant C_IWGRP
#8	constant C_IXGRP
#4	constant C_IROTH
#2	constant C_IWOTH
#1	constant C_IXOTH
#2048	constant C_ISUID
#1024	constant C_ISGID
#512	constant C_ISVTX
#24576	constant C_ISBLK
#8192	constant C_ISCHR
#16384	constant C_ISDIR
#4096	constant C_ISFIFO
#49152	constant C_ISSOCK
#40960	constant C_ISLNK
#36864	constant C_ISCTG
#32768	constant C_ISREG

\ ----===< postfix >===-----
end-c-library
