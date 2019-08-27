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
#1	constant _SYS_UIO_H
#1	constant __iovec_defined

\ -------===< structs >===--------
\ iovec
begin-structure iovec
	drop 0 8 +field iovec-iov_base
	drop 8 8 +field iovec-iov_len
drop 16 end-structure

\ ------===< functions >===-------
EXTERN: "C" n readv( int __fd, void * __iovec, int __count );	( __fd __iovec __count -- )
EXTERN: "C" n writev( int __fd, void * __iovec, int __count );	( __fd __iovec __count -- )

\ ----===< postfix >===-----
( none )
