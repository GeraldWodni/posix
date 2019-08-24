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
#1	constant __FMTMSG_H
#0	constant MM_NULLSEV

\ --------===< enums >===---------
#1	constant MM_HARD
#2	constant MM_SOFT
#4	constant MM_FIRM
#8	constant MM_APPL
#16	constant MM_UTIL
#32	constant MM_OPSYS
#64	constant MM_RECOVER
#128	constant MM_NRECOV
#256	constant MM_PRINT
#512	constant MM_CONSOLE
#0	constant MM_NOSEV
#1	constant MM_HALT
#2	constant MM_ERROR
#3	constant MM_WARNING
#4	constant MM_INFO
#-1	constant MM_NOTOK
#0	constant MM_OK
#1	constant MM_NOMSG
#4	constant MM_NOCON

\ ------===< functions >===-------
FUNCTION: fmtmsg ( __classification __label __severity __text __action __tag -- n )	( __classification __label __severity __text __action __tag -- )

\ ----===< postfix >===-----
( none )
