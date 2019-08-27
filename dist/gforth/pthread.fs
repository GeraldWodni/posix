\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library pthread
s" pthread" add-lib
\c #include <pthread.h>

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
c-funptr _pthread_cleanup_buffer-__routine() {((struct _pthread_cleanup_buffer*)ptr)->__routine} a -- void	( <noname> -- )
c-funptr __pthread_cleanup_frame-__cancel_routine() {((struct __pthread_cleanup_frame*)ptr)->__cancel_routine} a -- void	( <noname> -- )

\ ------===< functions >===-------
c-function pthread_create pthread_create a a a a -- n	( __newthread __attr __start_routine __arg -- )
c-function pthread_exit pthread_exit a -- void	( __retval -- )
c-function pthread_join pthread_join n a -- n	( __th __thread_return -- )
c-function pthread_detach pthread_detach n -- n	( __th -- )
c-function pthread_self pthread_self  -- n	( -- )
c-function pthread_equal pthread_equal n n -- n	( __thread1 __thread2 -- )
c-function pthread_attr_init pthread_attr_init a -- n	( __attr -- )
c-function pthread_attr_destroy pthread_attr_destroy a -- n	( __attr -- )
c-function pthread_attr_getdetachstate pthread_attr_getdetachstate a a -- n	( __attr __detachstate -- )
c-function pthread_attr_setdetachstate pthread_attr_setdetachstate a n -- n	( __attr __detachstate -- )
c-function pthread_attr_getguardsize pthread_attr_getguardsize a a -- n	( __attr __guardsize -- )
c-function pthread_attr_setguardsize pthread_attr_setguardsize a u -- n	( __attr __guardsize -- )
c-function pthread_attr_getschedparam pthread_attr_getschedparam a a -- n	( __attr __param -- )
c-function pthread_attr_setschedparam pthread_attr_setschedparam a a -- n	( __attr __param -- )
c-function pthread_attr_getschedpolicy pthread_attr_getschedpolicy a a -- n	( __attr __policy -- )
c-function pthread_attr_setschedpolicy pthread_attr_setschedpolicy a n -- n	( __attr __policy -- )
c-function pthread_attr_getinheritsched pthread_attr_getinheritsched a a -- n	( __attr __inherit -- )
c-function pthread_attr_setinheritsched pthread_attr_setinheritsched a n -- n	( __attr __inherit -- )
c-function pthread_attr_getscope pthread_attr_getscope a a -- n	( __attr __scope -- )
c-function pthread_attr_setscope pthread_attr_setscope a n -- n	( __attr __scope -- )
c-function pthread_attr_getstackaddr pthread_attr_getstackaddr a a -- n	( __attr __stackaddr -- )
c-function pthread_attr_setstackaddr pthread_attr_setstackaddr a a -- n	( __attr __stackaddr -- )
c-function pthread_attr_getstacksize pthread_attr_getstacksize a a -- n	( __attr __stacksize -- )
c-function pthread_attr_setstacksize pthread_attr_setstacksize a u -- n	( __attr __stacksize -- )
c-function pthread_attr_getstack pthread_attr_getstack a a a -- n	( __attr __stackaddr __stacksize -- )
c-function pthread_attr_setstack pthread_attr_setstack a a u -- n	( __attr __stackaddr __stacksize -- )
c-function pthread_setschedparam pthread_setschedparam n n a -- n	( __target_thread __policy __param -- )
c-function pthread_getschedparam pthread_getschedparam n a a -- n	( __target_thread __policy __param -- )
c-function pthread_setschedprio pthread_setschedprio n n -- n	( __target_thread __prio -- )
c-function pthread_once pthread_once a a -- n	( __once_control __init_routine -- )
c-function pthread_setcancelstate pthread_setcancelstate n a -- n	( __state __oldstate -- )
c-function pthread_setcanceltype pthread_setcanceltype n a -- n	( __type __oldtype -- )
c-function pthread_cancel pthread_cancel n -- n	( __th -- )
c-function pthread_testcancel pthread_testcancel  -- void	( -- )
c-function __pthread_register_cancel __pthread_register_cancel a -- void	( __buf -- )
c-function __pthread_unregister_cancel __pthread_unregister_cancel a -- void	( __buf -- )
c-function __pthread_unwind_next __pthread_unwind_next a -- void	( __buf -- )
c-function __sigsetjmp __sigsetjmp a n -- n	( __env __savemask -- )
c-function pthread_mutex_init pthread_mutex_init a a -- n	( __mutex __mutexattr -- )
c-function pthread_mutex_destroy pthread_mutex_destroy a -- n	( __mutex -- )
c-function pthread_mutex_trylock pthread_mutex_trylock a -- n	( __mutex -- )
c-function pthread_mutex_lock pthread_mutex_lock a -- n	( __mutex -- )
c-function pthread_mutex_timedlock pthread_mutex_timedlock a a -- n	( __mutex __abstime -- )
c-function pthread_mutex_unlock pthread_mutex_unlock a -- n	( __mutex -- )
c-function pthread_mutex_getprioceiling pthread_mutex_getprioceiling a a -- n	( __mutex __prioceiling -- )
c-function pthread_mutex_setprioceiling pthread_mutex_setprioceiling a n a -- n	( __mutex __prioceiling __old_ceiling -- )
c-function pthread_mutex_consistent pthread_mutex_consistent a -- n	( __mutex -- )
c-function pthread_mutexattr_init pthread_mutexattr_init a -- n	( __attr -- )
c-function pthread_mutexattr_destroy pthread_mutexattr_destroy a -- n	( __attr -- )
c-function pthread_mutexattr_getpshared pthread_mutexattr_getpshared a a -- n	( __attr __pshared -- )
c-function pthread_mutexattr_setpshared pthread_mutexattr_setpshared a n -- n	( __attr __pshared -- )
c-function pthread_mutexattr_gettype pthread_mutexattr_gettype a a -- n	( __attr __kind -- )
c-function pthread_mutexattr_settype pthread_mutexattr_settype a n -- n	( __attr __kind -- )
c-function pthread_mutexattr_getprotocol pthread_mutexattr_getprotocol a a -- n	( __attr __protocol -- )
c-function pthread_mutexattr_setprotocol pthread_mutexattr_setprotocol a n -- n	( __attr __protocol -- )
c-function pthread_mutexattr_getprioceiling pthread_mutexattr_getprioceiling a a -- n	( __attr __prioceiling -- )
c-function pthread_mutexattr_setprioceiling pthread_mutexattr_setprioceiling a n -- n	( __attr __prioceiling -- )
c-function pthread_mutexattr_getrobust pthread_mutexattr_getrobust a a -- n	( __attr __robustness -- )
c-function pthread_mutexattr_setrobust pthread_mutexattr_setrobust a n -- n	( __attr __robustness -- )
c-function pthread_rwlock_init pthread_rwlock_init a a -- n	( __rwlock __attr -- )
c-function pthread_rwlock_destroy pthread_rwlock_destroy a -- n	( __rwlock -- )
c-function pthread_rwlock_rdlock pthread_rwlock_rdlock a -- n	( __rwlock -- )
c-function pthread_rwlock_tryrdlock pthread_rwlock_tryrdlock a -- n	( __rwlock -- )
c-function pthread_rwlock_timedrdlock pthread_rwlock_timedrdlock a a -- n	( __rwlock __abstime -- )
c-function pthread_rwlock_wrlock pthread_rwlock_wrlock a -- n	( __rwlock -- )
c-function pthread_rwlock_trywrlock pthread_rwlock_trywrlock a -- n	( __rwlock -- )
c-function pthread_rwlock_timedwrlock pthread_rwlock_timedwrlock a a -- n	( __rwlock __abstime -- )
c-function pthread_rwlock_unlock pthread_rwlock_unlock a -- n	( __rwlock -- )
c-function pthread_rwlockattr_init pthread_rwlockattr_init a -- n	( __attr -- )
c-function pthread_rwlockattr_destroy pthread_rwlockattr_destroy a -- n	( __attr -- )
c-function pthread_rwlockattr_getpshared pthread_rwlockattr_getpshared a a -- n	( __attr __pshared -- )
c-function pthread_rwlockattr_setpshared pthread_rwlockattr_setpshared a n -- n	( __attr __pshared -- )
c-function pthread_rwlockattr_getkind_np pthread_rwlockattr_getkind_np a a -- n	( __attr __pref -- )
c-function pthread_rwlockattr_setkind_np pthread_rwlockattr_setkind_np a n -- n	( __attr __pref -- )
c-function pthread_cond_init pthread_cond_init a a -- n	( __cond __cond_attr -- )
c-function pthread_cond_destroy pthread_cond_destroy a -- n	( __cond -- )
c-function pthread_cond_signal pthread_cond_signal a -- n	( __cond -- )
c-function pthread_cond_broadcast pthread_cond_broadcast a -- n	( __cond -- )
c-function pthread_cond_wait pthread_cond_wait a a -- n	( __cond __mutex -- )
c-function pthread_cond_timedwait pthread_cond_timedwait a a a -- n	( __cond __mutex __abstime -- )
c-function pthread_condattr_init pthread_condattr_init a -- n	( __attr -- )
c-function pthread_condattr_destroy pthread_condattr_destroy a -- n	( __attr -- )
c-function pthread_condattr_getpshared pthread_condattr_getpshared a a -- n	( __attr __pshared -- )
c-function pthread_condattr_setpshared pthread_condattr_setpshared a n -- n	( __attr __pshared -- )
c-function pthread_condattr_getclock pthread_condattr_getclock a a -- n	( __attr __clock_id -- )
c-function pthread_condattr_setclock pthread_condattr_setclock a n -- n	( __attr __clock_id -- )
c-function pthread_spin_init pthread_spin_init a n -- n	( __lock __pshared -- )
c-function pthread_spin_destroy pthread_spin_destroy a -- n	( __lock -- )
c-function pthread_spin_lock pthread_spin_lock a -- n	( __lock -- )
c-function pthread_spin_trylock pthread_spin_trylock a -- n	( __lock -- )
c-function pthread_spin_unlock pthread_spin_unlock a -- n	( __lock -- )
c-function pthread_barrier_init pthread_barrier_init a a u -- n	( __barrier __attr __count -- )
c-function pthread_barrier_destroy pthread_barrier_destroy a -- n	( __barrier -- )
c-function pthread_barrier_wait pthread_barrier_wait a -- n	( __barrier -- )
c-function pthread_barrierattr_init pthread_barrierattr_init a -- n	( __attr -- )
c-function pthread_barrierattr_destroy pthread_barrierattr_destroy a -- n	( __attr -- )
c-function pthread_barrierattr_getpshared pthread_barrierattr_getpshared a a -- n	( __attr __pshared -- )
c-function pthread_barrierattr_setpshared pthread_barrierattr_setpshared a n -- n	( __attr __pshared -- )
c-function pthread_key_create pthread_key_create a a -- n	( __key __destr_function -- )
c-function pthread_key_delete pthread_key_delete n -- n	( __key -- )
c-function pthread_getspecific pthread_getspecific n -- a	( __key -- )
c-function pthread_setspecific pthread_setspecific n a -- n	( __key __pointer -- )
c-function pthread_getcpuclockid pthread_getcpuclockid n a -- n	( __thread_id __clock_id -- )
c-function pthread_atfork pthread_atfork a a a -- n	( __prepare __parent __child -- )

\ ----===< postfix >===-----
end-c-library
