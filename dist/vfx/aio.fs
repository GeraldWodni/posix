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
#1	constant _AIO_H

\ --------===< enums >===---------
#0	constant AIO_CANCELED
#1	constant AIO_NOTCANCELED
#2	constant AIO_ALLDONE
#0	constant LIO_READ
#1	constant LIO_WRITE
#2	constant LIO_NOP
#0	constant LIO_WAIT
#1	constant LIO_NOWAIT

\ -------===< structs >===--------
\ aiocb
begin-structure aiocb
	drop 32 64 +field aiocb-aio_sigevent
	drop 8 4 +field aiocb-aio_reqprio
	drop 0 4 +field aiocb-aio_fildes
	drop 24 8 +field aiocb-aio_nbytes
	drop 16 8 +field aiocb-aio_buf
	drop 112 4 +field aiocb-__error_code
	drop 136 32 +field aiocb-__glibc_reserved
	drop 136 0 +field aiocb-__pad
	drop 120 8 +field aiocb-__return_value
	drop 108 4 +field aiocb-__policy
	drop 104 4 +field aiocb-__abs_prio
	drop 128 8 +field aiocb-aio_offset
	drop 96 8 +field aiocb-__next_prio
	drop 4 4 +field aiocb-aio_lio_opcode
drop 168 end-structure

\ ------===< functions >===-------
EXTERN: "C" int aio_read( void * __aiocbp );	( __aiocbp -- )
EXTERN: "C" int aio_write( void * __aiocbp );	( __aiocbp -- )
EXTERN: "C" int lio_listio( int __mode, void * __list, int __nent, void * __sig );	( __mode __list __nent __sig -- )
EXTERN: "C" int aio_error( void * __aiocbp );	( __aiocbp -- )
EXTERN: "C" n aio_return( void * __aiocbp );	( __aiocbp -- )
EXTERN: "C" int aio_cancel( int __fildes, void * __aiocbp );	( __fildes __aiocbp -- )
EXTERN: "C" int aio_suspend( void * __list, int __nent, void * __timeout );	( __list __nent __timeout -- )
EXTERN: "C" int aio_fsync( int __operation, void * __aiocbp );	( __operation __aiocbp -- )

\ ----===< postfix >===-----
( none )
