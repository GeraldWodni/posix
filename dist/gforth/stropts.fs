\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library stropts
s" stropts" add-lib
\c #include <stropts.h>

\ ----===< int constants >===-----
#1	constant _STROPTS_H

\ ------===< functions >===-------
c-function isastream isastream n -- n	( __fildes -- )
c-function getmsg getmsg n a a a -- n	( __fildes __ctlptr __dataptr __flagsp -- )
c-function getpmsg getpmsg n a a a a -- n	( __fildes __ctlptr __dataptr __bandp __flagsp -- )
c-function ioctl ioctl n u ... -- n	( __fd __request <noname> -- )
c-function putmsg putmsg n a a n -- n	( __fildes __ctlptr __dataptr __flags -- )
c-function putpmsg putpmsg n a a n n -- n	( __fildes __ctlptr __dataptr __band __flags -- )
c-function fattach fattach n s -- n	( __fildes __path -- )
c-function fdetach fdetach s -- n	( __path -- )

\ ----===< postfix >===-----
end-c-library
