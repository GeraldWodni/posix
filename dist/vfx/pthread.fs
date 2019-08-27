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
#1	constant _PTHREAD_H
#0	constant PTHREAD_ONCE_INIT

\ --------===< enums >===---------
#0	constant PTHREAD_CREATE_JOINABLE
#1	constant PTHREAD_CREATE_DETACHED
#0	constant PTHREAD_MUTEX_TIMED_NP
#1	constant PTHREAD_MUTEX_RECURSIVE_NP
#2	constant PTHREAD_MUTEX_ERRORCHECK_NP
#3	constant PTHREAD_MUTEX_ADAPTIVE_NP
#0	constant PTHREAD_INHERIT_SCHED
#1	constant PTHREAD_EXPLICIT_SCHED
#0	constant PTHREAD_SCOPE_SYSTEM
#1	constant PTHREAD_SCOPE_PROCESS
#0	constant PTHREAD_PROCESS_PRIVATE
#1	constant PTHREAD_PROCESS_SHARED
#0	constant PTHREAD_CANCEL_ENABLE
#1	constant PTHREAD_CANCEL_DISABLE
#0	constant PTHREAD_CANCEL_DEFERRED
#1	constant PTHREAD_CANCEL_ASYNCHRONOUS

\ -------===< structs >===--------
\ _pthread_cleanup_buffer
begin-structure _pthread_cleanup_buffer
	drop 0 8 +field _pthread_cleanup_buffer-__routine
	drop 24 8 +field _pthread_cleanup_buffer-__prev
	drop 8 8 +field _pthread_cleanup_buffer-__arg
	drop 16 4 +field _pthread_cleanup_buffer-__canceltype
drop 32 end-structure
\ __pthread_unwind_buf_t
begin-structure __pthread_unwind_buf_t
	drop 72 32 +field __pthread_unwind_buf_t-__pad
	drop 0 72 +field __pthread_unwind_buf_t-__cancel_jmp_buf
drop 104 end-structure
\ __pthread_unwind_buf_t___cancel_jmp_buf
begin-structure __pthread_unwind_buf_t___cancel_jmp_buf
	drop 64 4 +field __pthread_unwind_buf_t___cancel_jmp_buf-__mask_was_saved
	drop 0 64 +field __pthread_unwind_buf_t___cancel_jmp_buf-__cancel_jmp_buf
drop 72 end-structure
\ __pthread_cleanup_frame
begin-structure __pthread_cleanup_frame
	drop 0 8 +field __pthread_cleanup_frame-__cancel_routine
	drop 8 8 +field __pthread_cleanup_frame-__cancel_arg
	drop 20 4 +field __pthread_cleanup_frame-__cancel_type
	drop 16 4 +field __pthread_cleanup_frame-__do_it
drop 24 end-structure

\ --===< function pointers >===---
	( <noname> -- )
	( <noname> -- )

\ ------===< functions >===-------
EXTERN: "C" int pthread_create( void * __newthread, void * __attr, void * __start_routine, void * __arg );	( __newthread __attr __start_routine __arg -- )
EXTERN: "C" void pthread_exit( void * __retval );	( __retval -- )
EXTERN: "C" int pthread_join( n __th, void * __thread_return );	( __th __thread_return -- )
EXTERN: "C" int pthread_detach( n __th );	( __th -- )
EXTERN: "C" n pthread_self(  );	( -- )
EXTERN: "C" int pthread_equal( n __thread1, n __thread2 );	( __thread1 __thread2 -- )
EXTERN: "C" int pthread_attr_init( void * __attr );	( __attr -- )
EXTERN: "C" int pthread_attr_destroy( void * __attr );	( __attr -- )
EXTERN: "C" int pthread_attr_getdetachstate( void * __attr, void * __detachstate );	( __attr __detachstate -- )
EXTERN: "C" int pthread_attr_setdetachstate( void * __attr, int __detachstate );	( __attr __detachstate -- )
EXTERN: "C" int pthread_attr_getguardsize( void * __attr, void * __guardsize );	( __attr __guardsize -- )
EXTERN: "C" int pthread_attr_setguardsize( void * __attr, n __guardsize );	( __attr __guardsize -- )
EXTERN: "C" int pthread_attr_getschedparam( void * __attr, void * __param );	( __attr __param -- )
EXTERN: "C" int pthread_attr_setschedparam( void * __attr, void * __param );	( __attr __param -- )
EXTERN: "C" int pthread_attr_getschedpolicy( void * __attr, void * __policy );	( __attr __policy -- )
EXTERN: "C" int pthread_attr_setschedpolicy( void * __attr, int __policy );	( __attr __policy -- )
EXTERN: "C" int pthread_attr_getinheritsched( void * __attr, void * __inherit );	( __attr __inherit -- )
EXTERN: "C" int pthread_attr_setinheritsched( void * __attr, int __inherit );	( __attr __inherit -- )
EXTERN: "C" int pthread_attr_getscope( void * __attr, void * __scope );	( __attr __scope -- )
EXTERN: "C" int pthread_attr_setscope( void * __attr, int __scope );	( __attr __scope -- )
EXTERN: "C" int pthread_attr_getstackaddr( void * __attr, void * __stackaddr );	( __attr __stackaddr -- )
EXTERN: "C" int pthread_attr_setstackaddr( void * __attr, void * __stackaddr );	( __attr __stackaddr -- )
EXTERN: "C" int pthread_attr_getstacksize( void * __attr, void * __stacksize );	( __attr __stacksize -- )
EXTERN: "C" int pthread_attr_setstacksize( void * __attr, n __stacksize );	( __attr __stacksize -- )
EXTERN: "C" int pthread_setschedparam( n __target_thread, int __policy, void * __param );	( __target_thread __policy __param -- )
EXTERN: "C" int pthread_getschedparam( n __target_thread, void * __policy, void * __param );	( __target_thread __policy __param -- )
EXTERN: "C" int pthread_setschedprio( n __target_thread, int __prio );	( __target_thread __prio -- )
EXTERN: "C" int pthread_once( void * __once_control, void * __init_routine );	( __once_control __init_routine -- )
EXTERN: "C" int pthread_setcancelstate( int __state, void * __oldstate );	( __state __oldstate -- )
EXTERN: "C" int pthread_setcanceltype( int __type, void * __oldtype );	( __type __oldtype -- )
EXTERN: "C" int pthread_cancel( n __th );	( __th -- )
EXTERN: "C" void pthread_testcancel(  );	( -- )
EXTERN: "C" void __pthread_register_cancel( void * __buf );	( __buf -- )
EXTERN: "C" void __pthread_unregister_cancel( void * __buf );	( __buf -- )
EXTERN: "C" void __pthread_unwind_next( void * __buf );	( __buf -- )
EXTERN: "C" int __sigsetjmp( void * __env, int __savemask );	( __env __savemask -- )
EXTERN: "C" int pthread_mutex_init( void * __mutex, void * __mutexattr );	( __mutex __mutexattr -- )
EXTERN: "C" int pthread_mutex_destroy( void * __mutex );	( __mutex -- )
EXTERN: "C" int pthread_mutex_trylock( void * __mutex );	( __mutex -- )
EXTERN: "C" int pthread_mutex_lock( void * __mutex );	( __mutex -- )
EXTERN: "C" int pthread_mutex_unlock( void * __mutex );	( __mutex -- )
EXTERN: "C" int pthread_mutex_getprioceiling( void * __mutex, void * __prioceiling );	( __mutex __prioceiling -- )
EXTERN: "C" int pthread_mutex_setprioceiling( void * __mutex, int __prioceiling, void * __old_ceiling );	( __mutex __prioceiling __old_ceiling -- )
EXTERN: "C" int pthread_mutexattr_init( void * __attr );	( __attr -- )
EXTERN: "C" int pthread_mutexattr_destroy( void * __attr );	( __attr -- )
EXTERN: "C" int pthread_mutexattr_getpshared( void * __attr, void * __pshared );	( __attr __pshared -- )
EXTERN: "C" int pthread_mutexattr_setpshared( void * __attr, int __pshared );	( __attr __pshared -- )
EXTERN: "C" int pthread_mutexattr_getprotocol( void * __attr, void * __protocol );	( __attr __protocol -- )
EXTERN: "C" int pthread_mutexattr_setprotocol( void * __attr, int __protocol );	( __attr __protocol -- )
EXTERN: "C" int pthread_mutexattr_getprioceiling( void * __attr, void * __prioceiling );	( __attr __prioceiling -- )
EXTERN: "C" int pthread_mutexattr_setprioceiling( void * __attr, int __prioceiling );	( __attr __prioceiling -- )
EXTERN: "C" int pthread_cond_init( void * __cond, void * __cond_attr );	( __cond __cond_attr -- )
EXTERN: "C" int pthread_cond_destroy( void * __cond );	( __cond -- )
EXTERN: "C" int pthread_cond_signal( void * __cond );	( __cond -- )
EXTERN: "C" int pthread_cond_broadcast( void * __cond );	( __cond -- )
EXTERN: "C" int pthread_cond_wait( void * __cond, void * __mutex );	( __cond __mutex -- )
EXTERN: "C" int pthread_cond_timedwait( void * __cond, void * __mutex, void * __abstime );	( __cond __mutex __abstime -- )
EXTERN: "C" int pthread_condattr_init( void * __attr );	( __attr -- )
EXTERN: "C" int pthread_condattr_destroy( void * __attr );	( __attr -- )
EXTERN: "C" int pthread_condattr_getpshared( void * __attr, void * __pshared );	( __attr __pshared -- )
EXTERN: "C" int pthread_condattr_setpshared( void * __attr, int __pshared );	( __attr __pshared -- )
EXTERN: "C" int pthread_key_create( void * __key, void * __destr_function );	( __key __destr_function -- )
EXTERN: "C" int pthread_key_delete( n __key );	( __key -- )
EXTERN: "C" void * pthread_getspecific( n __key );	( __key -- )
EXTERN: "C" int pthread_setspecific( n __key, void * __pointer );	( __key __pointer -- )
EXTERN: "C" int pthread_atfork( void * __prepare, void * __parent, void * __child );	( __prepare __parent __child -- )

\ ----===< postfix >===-----
( none )
