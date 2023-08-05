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
#-1	constant PTHREAD_BARRIER_SERIAL_THREAD

\ --------===< enums >===---------
#0	constant PTHREAD_CREATE_JOINABLE
#1	constant PTHREAD_CREATE_DETACHED
#0	constant PTHREAD_MUTEX_TIMED_NP
#1	constant PTHREAD_MUTEX_RECURSIVE_NP
#2	constant PTHREAD_MUTEX_ERRORCHECK_NP
#3	constant PTHREAD_MUTEX_ADAPTIVE_NP
#0	constant PTHREAD_MUTEX_NORMAL
#1	constant PTHREAD_MUTEX_RECURSIVE
#2	constant PTHREAD_MUTEX_ERRORCHECK
#0	constant PTHREAD_MUTEX_DEFAULT
#0	constant PTHREAD_MUTEX_STALLED
#0	constant PTHREAD_MUTEX_STALLED_NP
#1	constant PTHREAD_MUTEX_ROBUST
#1	constant PTHREAD_MUTEX_ROBUST_NP
#0	constant PTHREAD_RWLOCK_PREFER_READER_NP
#1	constant PTHREAD_RWLOCK_PREFER_WRITER_NP
#2	constant PTHREAD_RWLOCK_PREFER_WRITER_NONRECURSIVE_NP
#0	constant PTHREAD_RWLOCK_DEFAULT_NP
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
\ struct _pthread_cleanup_buffer
begin-structure _pthread_cleanup_buffer
	drop 0 8 +field _pthread_cleanup_buffer-__routine
	drop 24 8 +field _pthread_cleanup_buffer-__prev
	drop 8 8 +field _pthread_cleanup_buffer-__arg
	drop 16 4 +field _pthread_cleanup_buffer-__canceltype
drop 32 end-structure
\ struct __cancel_jmp_buf_tag
begin-structure __cancel_jmp_buf_tag
	drop 64 4 +field __cancel_jmp_buf_tag-__mask_was_saved
	drop 0 64 +field __cancel_jmp_buf_tag-__cancel_jmp_buf
drop 72 end-structure
\ __pthread_unwind_buf_t
begin-structure __pthread_unwind_buf_t
	drop 72 32 +field __pthread_unwind_buf_t-__pad
	drop 0 72 +field __pthread_unwind_buf_t-__cancel_jmp_buf
drop 104 end-structure
\ struct __pthread_cleanup_frame
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
EXTERN: "C" int pthread_join( long __th, void * __thread_return );	( __th __thread_return -- )
EXTERN: "C" int pthread_detach( long __th );	( __th -- )
EXTERN: "C" long pthread_self(  );	( -- )
EXTERN: "C" int pthread_equal( long __thread1, long __thread2 );	( __thread1 __thread2 -- )
EXTERN: "C" int pthread_attr_init( void * __attr );	( __attr -- )
EXTERN: "C" int pthread_attr_destroy( void * __attr );	( __attr -- )
EXTERN: "C" int pthread_attr_getdetachstate( void * __attr, void * __detachstate );	( __attr __detachstate -- )
EXTERN: "C" int pthread_attr_setdetachstate( void * __attr, int __detachstate );	( __attr __detachstate -- )
EXTERN: "C" int pthread_attr_getguardsize( void * __attr, void * __guardsize );	( __attr __guardsize -- )
EXTERN: "C" int pthread_attr_setguardsize( void * __attr, long __guardsize );	( __attr __guardsize -- )
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
EXTERN: "C" int pthread_attr_setstacksize( void * __attr, long __stacksize );	( __attr __stacksize -- )
EXTERN: "C" int pthread_attr_getstack( void * __attr, void * __stackaddr, void * __stacksize );	( __attr __stackaddr __stacksize -- )
EXTERN: "C" int pthread_attr_setstack( void * __attr, void * __stackaddr, long __stacksize );	( __attr __stackaddr __stacksize -- )
EXTERN: "C" int pthread_setschedparam( long __target_thread, int __policy, void * __param );	( __target_thread __policy __param -- )
EXTERN: "C" int pthread_getschedparam( long __target_thread, void * __policy, void * __param );	( __target_thread __policy __param -- )
EXTERN: "C" int pthread_setschedprio( long __target_thread, int __prio );	( __target_thread __prio -- )
EXTERN: "C" int pthread_once( void * __once_control, void * __init_routine );	( __once_control __init_routine -- )
EXTERN: "C" int pthread_setcancelstate( int __state, void * __oldstate );	( __state __oldstate -- )
EXTERN: "C" int pthread_setcanceltype( int __type, void * __oldtype );	( __type __oldtype -- )
EXTERN: "C" int pthread_cancel( long __th );	( __th -- )
EXTERN: "C" void pthread_testcancel(  );	( -- )
EXTERN: "C" void __pthread_register_cancel( void * __buf );	( __buf -- )
EXTERN: "C" void __pthread_unregister_cancel( void * __buf );	( __buf -- )
EXTERN: "C" void __pthread_unwind_next( void * __buf );	( __buf -- )
EXTERN: "C" int __sigsetjmp( void * __env, int __savemask );	( __env __savemask -- )
EXTERN: "C" int pthread_mutex_init( void * __mutex, void * __mutexattr );	( __mutex __mutexattr -- )
EXTERN: "C" int pthread_mutex_destroy( void * __mutex );	( __mutex -- )
EXTERN: "C" int pthread_mutex_trylock( void * __mutex );	( __mutex -- )
EXTERN: "C" int pthread_mutex_lock( void * __mutex );	( __mutex -- )
EXTERN: "C" int pthread_mutex_timedlock( void * __mutex, void * __abstime );	( __mutex __abstime -- )
EXTERN: "C" int pthread_mutex_unlock( void * __mutex );	( __mutex -- )
EXTERN: "C" int pthread_mutex_getprioceiling( void * __mutex, void * __prioceiling );	( __mutex __prioceiling -- )
EXTERN: "C" int pthread_mutex_setprioceiling( void * __mutex, int __prioceiling, void * __old_ceiling );	( __mutex __prioceiling __old_ceiling -- )
EXTERN: "C" int pthread_mutex_consistent( void * __mutex );	( __mutex -- )
EXTERN: "C" int pthread_mutexattr_init( void * __attr );	( __attr -- )
EXTERN: "C" int pthread_mutexattr_destroy( void * __attr );	( __attr -- )
EXTERN: "C" int pthread_mutexattr_getpshared( void * __attr, void * __pshared );	( __attr __pshared -- )
EXTERN: "C" int pthread_mutexattr_setpshared( void * __attr, int __pshared );	( __attr __pshared -- )
EXTERN: "C" int pthread_mutexattr_gettype( void * __attr, void * __kind );	( __attr __kind -- )
EXTERN: "C" int pthread_mutexattr_settype( void * __attr, int __kind );	( __attr __kind -- )
EXTERN: "C" int pthread_mutexattr_getprotocol( void * __attr, void * __protocol );	( __attr __protocol -- )
EXTERN: "C" int pthread_mutexattr_setprotocol( void * __attr, int __protocol );	( __attr __protocol -- )
EXTERN: "C" int pthread_mutexattr_getprioceiling( void * __attr, void * __prioceiling );	( __attr __prioceiling -- )
EXTERN: "C" int pthread_mutexattr_setprioceiling( void * __attr, int __prioceiling );	( __attr __prioceiling -- )
EXTERN: "C" int pthread_mutexattr_getrobust( void * __attr, void * __robustness );	( __attr __robustness -- )
EXTERN: "C" int pthread_mutexattr_setrobust( void * __attr, int __robustness );	( __attr __robustness -- )
EXTERN: "C" int pthread_rwlock_init( void * __rwlock, void * __attr );	( __rwlock __attr -- )
EXTERN: "C" int pthread_rwlock_destroy( void * __rwlock );	( __rwlock -- )
EXTERN: "C" int pthread_rwlock_rdlock( void * __rwlock );	( __rwlock -- )
EXTERN: "C" int pthread_rwlock_tryrdlock( void * __rwlock );	( __rwlock -- )
EXTERN: "C" int pthread_rwlock_timedrdlock( void * __rwlock, void * __abstime );	( __rwlock __abstime -- )
EXTERN: "C" int pthread_rwlock_wrlock( void * __rwlock );	( __rwlock -- )
EXTERN: "C" int pthread_rwlock_trywrlock( void * __rwlock );	( __rwlock -- )
EXTERN: "C" int pthread_rwlock_timedwrlock( void * __rwlock, void * __abstime );	( __rwlock __abstime -- )
EXTERN: "C" int pthread_rwlock_unlock( void * __rwlock );	( __rwlock -- )
EXTERN: "C" int pthread_rwlockattr_init( void * __attr );	( __attr -- )
EXTERN: "C" int pthread_rwlockattr_destroy( void * __attr );	( __attr -- )
EXTERN: "C" int pthread_rwlockattr_getpshared( void * __attr, void * __pshared );	( __attr __pshared -- )
EXTERN: "C" int pthread_rwlockattr_setpshared( void * __attr, int __pshared );	( __attr __pshared -- )
EXTERN: "C" int pthread_rwlockattr_getkind_np( void * __attr, void * __pref );	( __attr __pref -- )
EXTERN: "C" int pthread_rwlockattr_setkind_np( void * __attr, int __pref );	( __attr __pref -- )
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
EXTERN: "C" int pthread_condattr_getclock( void * __attr, void * __clock_id );	( __attr __clock_id -- )
EXTERN: "C" int pthread_condattr_setclock( void * __attr, long __clock_id );	( __attr __clock_id -- )
EXTERN: "C" int pthread_spin_init( void * __lock, int __pshared );	( __lock __pshared -- )
EXTERN: "C" int pthread_spin_destroy( void * __lock );	( __lock -- )
EXTERN: "C" int pthread_spin_lock( void * __lock );	( __lock -- )
EXTERN: "C" int pthread_spin_trylock( void * __lock );	( __lock -- )
EXTERN: "C" int pthread_spin_unlock( void * __lock );	( __lock -- )
EXTERN: "C" int pthread_barrier_init( void * __barrier, void * __attr, int __count );	( __barrier __attr __count -- )
EXTERN: "C" int pthread_barrier_destroy( void * __barrier );	( __barrier -- )
EXTERN: "C" int pthread_barrier_wait( void * __barrier );	( __barrier -- )
EXTERN: "C" int pthread_barrierattr_init( void * __attr );	( __attr -- )
EXTERN: "C" int pthread_barrierattr_destroy( void * __attr );	( __attr -- )
EXTERN: "C" int pthread_barrierattr_getpshared( void * __attr, void * __pshared );	( __attr __pshared -- )
EXTERN: "C" int pthread_barrierattr_setpshared( void * __attr, int __pshared );	( __attr __pshared -- )
EXTERN: "C" int pthread_key_create( void * __key, void * __destr_function );	( __key __destr_function -- )
EXTERN: "C" int pthread_key_delete( long __key );	( __key -- )
EXTERN: "C" void * pthread_getspecific( long __key );	( __key -- )
EXTERN: "C" int pthread_setspecific( long __key, void * __pointer );	( __key __pointer -- )
EXTERN: "C" int pthread_getcpuclockid( long __thread_id, void * __clock_id );	( __thread_id __clock_id -- )
EXTERN: "C" int pthread_atfork( void * __prepare, void * __parent, void * __child );	( __prepare __parent __child -- )

\ ----===< postfix >===-----
( none )
