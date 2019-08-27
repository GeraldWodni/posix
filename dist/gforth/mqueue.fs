\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library mqueue
s" mqueue" add-lib
\c #include <mqueue.h>

\ ----===< int constants >===-----
#1	constant _MQUEUE_H

\ ------===< functions >===-------
c-function mq_open mq_open s n ... -- n	( __name __oflag <noname> -- )
c-function mq_close mq_close n -- n	( __mqdes -- )
c-function mq_getattr mq_getattr n a -- n	( __mqdes __mqstat -- )
c-function mq_setattr mq_setattr n a a -- n	( __mqdes __mqstat __omqstat -- )
c-function mq_unlink mq_unlink s -- n	( __name -- )
c-function mq_notify mq_notify n a -- n	( __mqdes __notification -- )
c-function mq_receive mq_receive n a u a -- n	( __mqdes __msg_ptr __msg_len __msg_prio -- )
c-function mq_send mq_send n s u u -- n	( __mqdes __msg_ptr __msg_len __msg_prio -- )

\ ----===< postfix >===-----
end-c-library
