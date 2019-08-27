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
FUNCTION: pthread_create ( __newthread __attr __start_routine __arg -- n )	( __newthread __attr __start_routine __arg -- )
FUNCTION: pthread_exit ( __retval -- void )	( __retval -- )
FUNCTION: pthread_join ( __th __thread_return -- n )	( __th __thread_return -- )
FUNCTION: pthread_detach ( __th -- n )	( __th -- )
FUNCTION: pthread_self (  -- n )	( -- )
FUNCTION: pthread_equal ( __thread1 __thread2 -- n )	( __thread1 __thread2 -- )
FUNCTION: pthread_attr_init ( __attr -- n )	( __attr -- )
FUNCTION: pthread_attr_destroy ( __attr -- n )	( __attr -- )
FUNCTION: pthread_attr_getdetachstate ( __attr __detachstate -- n )	( __attr __detachstate -- )
FUNCTION: pthread_attr_setdetachstate ( __attr __detachstate -- n )	( __attr __detachstate -- )
FUNCTION: pthread_attr_getguardsize ( __attr __guardsize -- n )	( __attr __guardsize -- )
FUNCTION: pthread_attr_setguardsize ( __attr __guardsize -- n )	( __attr __guardsize -- )
FUNCTION: pthread_attr_getschedparam ( __attr __param -- n )	( __attr __param -- )
FUNCTION: pthread_attr_setschedparam ( __attr __param -- n )	( __attr __param -- )
FUNCTION: pthread_attr_getschedpolicy ( __attr __policy -- n )	( __attr __policy -- )
FUNCTION: pthread_attr_setschedpolicy ( __attr __policy -- n )	( __attr __policy -- )
FUNCTION: pthread_attr_getinheritsched ( __attr __inherit -- n )	( __attr __inherit -- )
FUNCTION: pthread_attr_setinheritsched ( __attr __inherit -- n )	( __attr __inherit -- )
FUNCTION: pthread_attr_getscope ( __attr __scope -- n )	( __attr __scope -- )
FUNCTION: pthread_attr_setscope ( __attr __scope -- n )	( __attr __scope -- )
FUNCTION: pthread_attr_getstackaddr ( __attr __stackaddr -- n )	( __attr __stackaddr -- )
FUNCTION: pthread_attr_setstackaddr ( __attr __stackaddr -- n )	( __attr __stackaddr -- )
FUNCTION: pthread_attr_getstacksize ( __attr __stacksize -- n )	( __attr __stacksize -- )
FUNCTION: pthread_attr_setstacksize ( __attr __stacksize -- n )	( __attr __stacksize -- )
FUNCTION: pthread_setschedparam ( __target_thread __policy __param -- n )	( __target_thread __policy __param -- )
FUNCTION: pthread_getschedparam ( __target_thread __policy __param -- n )	( __target_thread __policy __param -- )
FUNCTION: pthread_setschedprio ( __target_thread __prio -- n )	( __target_thread __prio -- )
FUNCTION: pthread_once ( __once_control __init_routine -- n )	( __once_control __init_routine -- )
FUNCTION: pthread_setcancelstate ( __state __oldstate -- n )	( __state __oldstate -- )
FUNCTION: pthread_setcanceltype ( __type __oldtype -- n )	( __type __oldtype -- )
FUNCTION: pthread_cancel ( __th -- n )	( __th -- )
FUNCTION: pthread_testcancel (  -- void )	( -- )
FUNCTION: __pthread_register_cancel ( __buf -- void )	( __buf -- )
FUNCTION: __pthread_unregister_cancel ( __buf -- void )	( __buf -- )
FUNCTION: __pthread_unwind_next ( __buf -- void )	( __buf -- )
FUNCTION: __sigsetjmp ( __env __savemask -- n )	( __env __savemask -- )
FUNCTION: pthread_mutex_init ( __mutex __mutexattr -- n )	( __mutex __mutexattr -- )
FUNCTION: pthread_mutex_destroy ( __mutex -- n )	( __mutex -- )
FUNCTION: pthread_mutex_trylock ( __mutex -- n )	( __mutex -- )
FUNCTION: pthread_mutex_lock ( __mutex -- n )	( __mutex -- )
FUNCTION: pthread_mutex_unlock ( __mutex -- n )	( __mutex -- )
FUNCTION: pthread_mutex_getprioceiling ( __mutex __prioceiling -- n )	( __mutex __prioceiling -- )
FUNCTION: pthread_mutex_setprioceiling ( __mutex __prioceiling __old_ceiling -- n )	( __mutex __prioceiling __old_ceiling -- )
FUNCTION: pthread_mutexattr_init ( __attr -- n )	( __attr -- )
FUNCTION: pthread_mutexattr_destroy ( __attr -- n )	( __attr -- )
FUNCTION: pthread_mutexattr_getpshared ( __attr __pshared -- n )	( __attr __pshared -- )
FUNCTION: pthread_mutexattr_setpshared ( __attr __pshared -- n )	( __attr __pshared -- )
FUNCTION: pthread_mutexattr_getprotocol ( __attr __protocol -- n )	( __attr __protocol -- )
FUNCTION: pthread_mutexattr_setprotocol ( __attr __protocol -- n )	( __attr __protocol -- )
FUNCTION: pthread_mutexattr_getprioceiling ( __attr __prioceiling -- n )	( __attr __prioceiling -- )
FUNCTION: pthread_mutexattr_setprioceiling ( __attr __prioceiling -- n )	( __attr __prioceiling -- )
FUNCTION: pthread_cond_init ( __cond __cond_attr -- n )	( __cond __cond_attr -- )
FUNCTION: pthread_cond_destroy ( __cond -- n )	( __cond -- )
FUNCTION: pthread_cond_signal ( __cond -- n )	( __cond -- )
FUNCTION: pthread_cond_broadcast ( __cond -- n )	( __cond -- )
FUNCTION: pthread_cond_wait ( __cond __mutex -- n )	( __cond __mutex -- )
FUNCTION: pthread_cond_timedwait ( __cond __mutex __abstime -- n )	( __cond __mutex __abstime -- )
FUNCTION: pthread_condattr_init ( __attr -- n )	( __attr -- )
FUNCTION: pthread_condattr_destroy ( __attr -- n )	( __attr -- )
FUNCTION: pthread_condattr_getpshared ( __attr __pshared -- n )	( __attr __pshared -- )
FUNCTION: pthread_condattr_setpshared ( __attr __pshared -- n )	( __attr __pshared -- )
FUNCTION: pthread_key_create ( __key __destr_function -- n )	( __key __destr_function -- )
FUNCTION: pthread_key_delete ( __key -- n )	( __key -- )
FUNCTION: pthread_getspecific ( __key -- a )	( __key -- )
FUNCTION: pthread_setspecific ( __key __pointer -- n )	( __key __pointer -- )
FUNCTION: pthread_atfork ( __prepare __parent __child -- n )	( __prepare __parent __child -- )

\ ----===< postfix >===-----
( none )
