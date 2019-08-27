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
EXTERN: "C" int sem_init( void * __sem, int __pshared, int __value );	( __sem __pshared __value -- )
EXTERN: "C" int sem_destroy( void * __sem );	( __sem -- )
EXTERN: "C" void * sem_open( char * __name, int __oflag, ...  );	( __name __oflag <noname> -- )
EXTERN: "C" int sem_close( void * __sem );	( __sem -- )
EXTERN: "C" int sem_unlink( char * __name );	( __name -- )
EXTERN: "C" int sem_wait( void * __sem );	( __sem -- )
EXTERN: "C" int sem_timedwait( void * __sem, void * __abstime );	( __sem __abstime -- )
EXTERN: "C" int sem_trywait( void * __sem );	( __sem -- )
EXTERN: "C" int sem_post( void * __sem );	( __sem -- )
EXTERN: "C" int sem_getvalue( void * __sem, void * __sval );	( __sem __sval -- )

\ ----===< postfix >===-----
( none )
