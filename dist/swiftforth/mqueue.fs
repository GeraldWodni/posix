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
FUNCTION: mq_open ( __name __oflag  -- n )	( __name __oflag <noname> -- )
FUNCTION: mq_close ( __mqdes -- n )	( __mqdes -- )
FUNCTION: mq_getattr ( __mqdes __mqstat -- n )	( __mqdes __mqstat -- )
FUNCTION: mq_setattr ( __mqdes __mqstat __omqstat -- n )	( __mqdes __mqstat __omqstat -- )
FUNCTION: mq_unlink ( __name -- n )	( __name -- )
FUNCTION: mq_notify ( __mqdes __notification -- n )	( __mqdes __notification -- )
FUNCTION: mq_receive ( __mqdes __msg_ptr __msg_len __msg_prio -- n )	( __mqdes __msg_ptr __msg_len __msg_prio -- )
FUNCTION: mq_send ( __mqdes __msg_ptr __msg_len __msg_prio -- n )	( __mqdes __msg_ptr __msg_len __msg_prio -- )
FUNCTION: mq_timedreceive ( __mqdes __msg_ptr __msg_len __msg_prio __abs_timeout -- n )	( __mqdes __msg_ptr __msg_len __msg_prio __abs_timeout -- )
FUNCTION: mq_timedsend ( __mqdes __msg_ptr __msg_len __msg_prio __abs_timeout -- n )	( __mqdes __msg_ptr __msg_len __msg_prio __abs_timeout -- )

\ ----===< postfix >===-----
( none )
