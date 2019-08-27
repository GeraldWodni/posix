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
EXTERN: "C" int isastream( int __fildes );	( __fildes -- )
EXTERN: "C" int getmsg( int __fildes, void * __ctlptr, void * __dataptr, void * __flagsp );	( __fildes __ctlptr __dataptr __flagsp -- )
EXTERN: "C" int getpmsg( int __fildes, void * __ctlptr, void * __dataptr, void * __bandp, void * __flagsp );	( __fildes __ctlptr __dataptr __bandp __flagsp -- )
EXTERN: "C" int ioctl( int __fd, long __request, ...  );	( __fd __request <noname> -- )
EXTERN: "C" int putmsg( int __fildes, void * __ctlptr, void * __dataptr, int __flags );	( __fildes __ctlptr __dataptr __flags -- )
EXTERN: "C" int putpmsg( int __fildes, void * __ctlptr, void * __dataptr, int __band, int __flags );	( __fildes __ctlptr __dataptr __band __flags -- )
EXTERN: "C" int fattach( int __fildes, char * __path );	( __fildes __path -- )
EXTERN: "C" int fdetach( char * __path );	( __path -- )

\ ----===< postfix >===-----
( none )
