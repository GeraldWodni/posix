\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library spawn
s" spawn" add-lib
\c #include <spawn.h>

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
c-function posix_spawn posix_spawn a s a a a a -- n	( __pid __path __file_actions __attrp __argv __envp -- )
c-function posix_spawnp posix_spawnp a s a a a a -- n	( __pid __file __file_actions __attrp __argv __envp -- )
c-function posix_spawnattr_init posix_spawnattr_init a -- n	( __attr -- )
c-function posix_spawnattr_destroy posix_spawnattr_destroy a -- n	( __attr -- )
c-function posix_spawnattr_getsigdefault posix_spawnattr_getsigdefault a a -- n	( __attr __sigdefault -- )
c-function posix_spawnattr_setsigdefault posix_spawnattr_setsigdefault a a -- n	( __attr __sigdefault -- )
c-function posix_spawnattr_getsigmask posix_spawnattr_getsigmask a a -- n	( __attr __sigmask -- )
c-function posix_spawnattr_setsigmask posix_spawnattr_setsigmask a a -- n	( __attr __sigmask -- )
c-function posix_spawnattr_getflags posix_spawnattr_getflags a a -- n	( __attr __flags -- )
c-function posix_spawnattr_setflags posix_spawnattr_setflags a n -- n	( _attr __flags -- )
c-function posix_spawnattr_getpgroup posix_spawnattr_getpgroup a a -- n	( __attr __pgroup -- )
c-function posix_spawnattr_setpgroup posix_spawnattr_setpgroup a n -- n	( __attr __pgroup -- )
c-function posix_spawnattr_getschedpolicy posix_spawnattr_getschedpolicy a a -- n	( __attr __schedpolicy -- )
c-function posix_spawnattr_setschedpolicy posix_spawnattr_setschedpolicy a n -- n	( __attr __schedpolicy -- )
c-function posix_spawnattr_getschedparam posix_spawnattr_getschedparam a a -- n	( __attr __schedparam -- )
c-function posix_spawnattr_setschedparam posix_spawnattr_setschedparam a a -- n	( __attr __schedparam -- )
c-function posix_spawn_file_actions_init posix_spawn_file_actions_init a -- n	( __file_actions -- )
c-function posix_spawn_file_actions_destroy posix_spawn_file_actions_destroy a -- n	( __file_actions -- )
c-function posix_spawn_file_actions_addopen posix_spawn_file_actions_addopen a n s n n -- n	( __file_actions __fd __path __oflag __mode -- )
c-function posix_spawn_file_actions_addclose posix_spawn_file_actions_addclose a n -- n	( __file_actions __fd -- )
c-function posix_spawn_file_actions_adddup2 posix_spawn_file_actions_adddup2 a n n -- n	( __file_actions __fd __newfd -- )

\ ----===< postfix >===-----
end-c-library
