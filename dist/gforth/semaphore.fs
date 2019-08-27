\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library semaphore
s" semaphore" add-lib
\c #include <semaphore.h>

\ ----===< int constants >===-----
#1	constant _SEMAPHORE_H

\ ------===< functions >===-------
c-function sem_init sem_init a n u -- n	( __sem __pshared __value -- )
c-function sem_destroy sem_destroy a -- n	( __sem -- )
c-function sem_open sem_open s n ... -- a	( __name __oflag <noname> -- )
c-function sem_close sem_close a -- n	( __sem -- )
c-function sem_unlink sem_unlink s -- n	( __name -- )
c-function sem_wait sem_wait a -- n	( __sem -- )
c-function sem_trywait sem_trywait a -- n	( __sem -- )
c-function sem_post sem_post a -- n	( __sem -- )
c-function sem_getvalue sem_getvalue a a -- n	( __sem __sval -- )

\ ----===< postfix >===-----
end-c-library
