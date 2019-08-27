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
FUNCTION: posix_spawn ( __pid __path __file_actions __attrp __argv __envp -- n )	( __pid __path __file_actions __attrp __argv __envp -- )
FUNCTION: posix_spawnp ( __pid __file __file_actions __attrp __argv __envp -- n )	( __pid __file __file_actions __attrp __argv __envp -- )
FUNCTION: posix_spawnattr_init ( __attr -- n )	( __attr -- )
FUNCTION: posix_spawnattr_destroy ( __attr -- n )	( __attr -- )
FUNCTION: posix_spawnattr_getsigdefault ( __attr __sigdefault -- n )	( __attr __sigdefault -- )
FUNCTION: posix_spawnattr_setsigdefault ( __attr __sigdefault -- n )	( __attr __sigdefault -- )
FUNCTION: posix_spawnattr_getsigmask ( __attr __sigmask -- n )	( __attr __sigmask -- )
FUNCTION: posix_spawnattr_setsigmask ( __attr __sigmask -- n )	( __attr __sigmask -- )
FUNCTION: posix_spawnattr_getflags ( __attr __flags -- n )	( __attr __flags -- )
FUNCTION: posix_spawnattr_setflags ( _attr __flags -- n )	( _attr __flags -- )
FUNCTION: posix_spawnattr_getpgroup ( __attr __pgroup -- n )	( __attr __pgroup -- )
FUNCTION: posix_spawnattr_setpgroup ( __attr __pgroup -- n )	( __attr __pgroup -- )
FUNCTION: posix_spawnattr_getschedpolicy ( __attr __schedpolicy -- n )	( __attr __schedpolicy -- )
FUNCTION: posix_spawnattr_setschedpolicy ( __attr __schedpolicy -- n )	( __attr __schedpolicy -- )
FUNCTION: posix_spawnattr_getschedparam ( __attr __schedparam -- n )	( __attr __schedparam -- )
FUNCTION: posix_spawnattr_setschedparam ( __attr __schedparam -- n )	( __attr __schedparam -- )
FUNCTION: posix_spawn_file_actions_init ( __file_actions -- n )	( __file_actions -- )
FUNCTION: posix_spawn_file_actions_destroy ( __file_actions -- n )	( __file_actions -- )
FUNCTION: posix_spawn_file_actions_addopen ( __file_actions __fd __path __oflag __mode -- n )	( __file_actions __fd __path __oflag __mode -- )
FUNCTION: posix_spawn_file_actions_addclose ( __file_actions __fd -- n )	( __file_actions __fd -- )
FUNCTION: posix_spawn_file_actions_adddup2 ( __file_actions __fd __newfd -- n )	( __file_actions __fd __newfd -- )

\ ----===< postfix >===-----
( none )
