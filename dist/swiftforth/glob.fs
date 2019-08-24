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
#1	constant _GLOB_H
#1	constant GLOB_ERR
#2	constant GLOB_MARK
#4	constant GLOB_NOSORT
#8	constant GLOB_DOOFFS
#16	constant GLOB_NOCHECK
#32	constant GLOB_APPEND
#64	constant GLOB_NOESCAPE
#128	constant GLOB_PERIOD
#256	constant GLOB_MAGCHAR
#512	constant GLOB_ALTDIRFUNC
#1024	constant GLOB_BRACE
#2048	constant GLOB_NOMAGIC
#4096	constant GLOB_TILDE
#8192	constant GLOB_ONLYDIR
#16384	constant GLOB_TILDE_CHECK
#32511	constant __GLOB_FLAGS
#1	constant GLOB_NOSPACE
#2	constant GLOB_ABORTED
#3	constant GLOB_NOMATCH
#4	constant GLOB_NOSYS

\ -------===< structs >===--------
\ glob_t
begin-structure glob_t
	drop 8 8 +field glob_t-gl_pathv
	drop 40 8 +field glob_t-gl_readdir
	drop 56 8 +field glob_t-gl_lstat
	drop 64 8 +field glob_t-gl_stat
	drop 0 8 +field glob_t-gl_pathc
	drop 16 8 +field glob_t-gl_offs
	drop 32 8 +field glob_t-gl_closedir
	drop 24 4 +field glob_t-gl_flags
	drop 48 8 +field glob_t-gl_opendir
drop 72 end-structure

\ --===< function pointers >===---
	( <noname> -- )
	( <noname> -- )
	( <noname> -- )
	( <noname> <noname> -- )
	( <noname> <noname> -- )

\ ------===< functions >===-------
FUNCTION: glob ( __pattern __flags __errfunc __pglob -- n )	( __pattern __flags __errfunc __pglob -- )
FUNCTION: globfree ( __pglob -- void )	( __pglob -- )

\ ----===< postfix >===-----
( none )
