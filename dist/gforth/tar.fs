\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library tar
s" tar" add-lib
\c #include <tar.h>

\ ----===< int constants >===-----
#1	constant _TAR_H
#2048	constant TSUID
#1024	constant TSGID
#256	constant TUREAD
#128	constant TUWRITE
#64	constant TUEXEC
#32	constant TGREAD
#16	constant TGWRITE
#8	constant TGEXEC
#4	constant TOREAD
#2	constant TOWRITE
#1	constant TOEXEC
#48	constant REGTYPE
#0	constant AREGTYPE
#49	constant LNKTYPE
#50	constant SYMTYPE
#51	constant CHRTYPE
#52	constant BLKTYPE
#53	constant DIRTYPE
#54	constant FIFOTYPE
#55	constant CONTTYPE
#6	constant TMAGLEN
#2	constant TVERSLEN

\ ----===< postfix >===-----
end-c-library
