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
#1	constant _STROPTS_H

\ ------===< functions >===-------
FUNCTION: isastream ( __fildes -- n )	( __fildes -- )
FUNCTION: getmsg ( __fildes __ctlptr __dataptr __flagsp -- n )	( __fildes __ctlptr __dataptr __flagsp -- )
FUNCTION: getpmsg ( __fildes __ctlptr __dataptr __bandp __flagsp -- n )	( __fildes __ctlptr __dataptr __bandp __flagsp -- )
FUNCTION: ioctl ( __fd __request  -- n )	( __fd __request <noname> -- )
FUNCTION: putmsg ( __fildes __ctlptr __dataptr __flags -- n )	( __fildes __ctlptr __dataptr __flags -- )
FUNCTION: putpmsg ( __fildes __ctlptr __dataptr __band __flags -- n )	( __fildes __ctlptr __dataptr __band __flags -- )
FUNCTION: fattach ( __fildes __path -- n )	( __fildes __path -- )
FUNCTION: fdetach ( __path -- n )	( __path -- )

\ ----===< postfix >===-----
( none )
