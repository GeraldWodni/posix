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
#1	constant _SEMAPHORE_H

\ ------===< functions >===-------
FUNCTION: sem_init ( __sem __pshared __value -- n )	( __sem __pshared __value -- )
FUNCTION: sem_destroy ( __sem -- n )	( __sem -- )
FUNCTION: sem_open ( __name __oflag  -- a )	( __name __oflag <noname> -- )
FUNCTION: sem_close ( __sem -- n )	( __sem -- )
FUNCTION: sem_unlink ( __name -- n )	( __name -- )
FUNCTION: sem_wait ( __sem -- n )	( __sem -- )
FUNCTION: sem_trywait ( __sem -- n )	( __sem -- )
FUNCTION: sem_post ( __sem -- n )	( __sem -- )
FUNCTION: sem_getvalue ( __sem __sval -- n )	( __sem __sval -- )

\ ----===< postfix >===-----
( none )
