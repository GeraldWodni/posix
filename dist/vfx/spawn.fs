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
#1	constant _SPAWN_H
#1	constant POSIX_SPAWN_RESETIDS
#2	constant POSIX_SPAWN_SETPGROUP
#4	constant POSIX_SPAWN_SETSIGDEF
#8	constant POSIX_SPAWN_SETSIGMASK
#16	constant POSIX_SPAWN_SETSCHEDPARAM
#32	constant POSIX_SPAWN_SETSCHEDULER

\ -------===< structs >===--------
\ posix_spawnattr_t
begin-structure posix_spawnattr_t
	drop 268 4 +field posix_spawnattr_t-__policy
	drop 0 2 +field posix_spawnattr_t-__flags
	drop 264 4 +field posix_spawnattr_t-__sp
	drop 272 64 +field posix_spawnattr_t-__pad
	drop 4 4 +field posix_spawnattr_t-__pgrp
	drop 8 128 +field posix_spawnattr_t-__sd
	drop 136 128 +field posix_spawnattr_t-__ss
drop 336 end-structure
\ posix_spawn_file_actions_t
begin-structure posix_spawn_file_actions_t
	drop 0 4 +field posix_spawn_file_actions_t-__allocated
	drop 8 8 +field posix_spawn_file_actions_t-__actions
	drop 16 64 +field posix_spawn_file_actions_t-__pad
	drop 4 4 +field posix_spawn_file_actions_t-__used
drop 80 end-structure

\ ------===< functions >===-------
EXTERN: "C" int posix_spawn( void * __pid, char * __path, void * __file_actions, void * __attrp, void * __argv, void * __envp );	( __pid __path __file_actions __attrp __argv __envp -- )
EXTERN: "C" int posix_spawnp( void * __pid, char * __file, void * __file_actions, void * __attrp, void * __argv, void * __envp );	( __pid __file __file_actions __attrp __argv __envp -- )
EXTERN: "C" int posix_spawnattr_init( void * __attr );	( __attr -- )
EXTERN: "C" int posix_spawnattr_destroy( void * __attr );	( __attr -- )
EXTERN: "C" int posix_spawnattr_getsigdefault( void * __attr, void * __sigdefault );	( __attr __sigdefault -- )
EXTERN: "C" int posix_spawnattr_setsigdefault( void * __attr, void * __sigdefault );	( __attr __sigdefault -- )
EXTERN: "C" int posix_spawnattr_getsigmask( void * __attr, void * __sigmask );	( __attr __sigmask -- )
EXTERN: "C" int posix_spawnattr_setsigmask( void * __attr, void * __sigmask );	( __attr __sigmask -- )
EXTERN: "C" int posix_spawnattr_getflags( void * __attr, void * __flags );	( __attr __flags -- )
EXTERN: "C" int posix_spawnattr_setflags( void * _attr, short __flags );	( _attr __flags -- )
EXTERN: "C" int posix_spawnattr_getpgroup( void * __attr, void * __pgroup );	( __attr __pgroup -- )
EXTERN: "C" int posix_spawnattr_setpgroup( void * __attr, n __pgroup );	( __attr __pgroup -- )
EXTERN: "C" int posix_spawnattr_getschedpolicy( void * __attr, void * __schedpolicy );	( __attr __schedpolicy -- )
EXTERN: "C" int posix_spawnattr_setschedpolicy( void * __attr, int __schedpolicy );	( __attr __schedpolicy -- )
EXTERN: "C" int posix_spawnattr_getschedparam( void * __attr, void * __schedparam );	( __attr __schedparam -- )
EXTERN: "C" int posix_spawnattr_setschedparam( void * __attr, void * __schedparam );	( __attr __schedparam -- )
EXTERN: "C" int posix_spawn_file_actions_init( void * __file_actions );	( __file_actions -- )
EXTERN: "C" int posix_spawn_file_actions_destroy( void * __file_actions );	( __file_actions -- )
EXTERN: "C" int posix_spawn_file_actions_addopen( void * __file_actions, int __fd, char * __path, int __oflag, n __mode );	( __file_actions __fd __path __oflag __mode -- )
EXTERN: "C" int posix_spawn_file_actions_addclose( void * __file_actions, int __fd );	( __file_actions __fd -- )
EXTERN: "C" int posix_spawn_file_actions_adddup2( void * __file_actions, int __fd, int __newfd );	( __file_actions __fd __newfd -- )

\ ----===< postfix >===-----
( none )
