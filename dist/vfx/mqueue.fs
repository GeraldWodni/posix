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
#1	constant _MQUEUE_H

\ -------===< structs >===--------
\ mq_attr
begin-structure mq_attr
	drop 0 8 +field mq_attr-mq_flags
	drop 32 32 +field mq_attr-__pad
	drop 8 8 +field mq_attr-mq_maxmsg
	drop 16 8 +field mq_attr-mq_msgsize
	drop 24 8 +field mq_attr-mq_curmsgs
drop 64 end-structure

\ ------===< functions >===-------
EXTERN: "C" int mq_open( char * __name, int __oflag, ...  );	( __name __oflag <noname> -- )
EXTERN: "C" int mq_close( int __mqdes );	( __mqdes -- )
EXTERN: "C" int mq_getattr( int __mqdes, void * __mqstat );	( __mqdes __mqstat -- )
EXTERN: "C" int mq_setattr( int __mqdes, void * __mqstat, void * __omqstat );	( __mqdes __mqstat __omqstat -- )
EXTERN: "C" int mq_unlink( char * __name );	( __name -- )
EXTERN: "C" int mq_notify( int __mqdes, void * __notification );	( __mqdes __notification -- )
EXTERN: "C" n mq_receive( int __mqdes, void * __msg_ptr, n __msg_len, void * __msg_prio );	( __mqdes __msg_ptr __msg_len __msg_prio -- )
EXTERN: "C" int mq_send( int __mqdes, char * __msg_ptr, n __msg_len, int __msg_prio );	( __mqdes __msg_ptr __msg_len __msg_prio -- )
EXTERN: "C" n mq_timedreceive( int __mqdes, void * __msg_ptr, n __msg_len, void * __msg_prio, void * __abs_timeout );	( __mqdes __msg_ptr __msg_len __msg_prio __abs_timeout -- )
EXTERN: "C" int mq_timedsend( int __mqdes, char * __msg_ptr, n __msg_len, int __msg_prio, void * __abs_timeout );	( __mqdes __msg_ptr __msg_len __msg_prio __abs_timeout -- )

\ ----===< postfix >===-----
( none )
