\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library ndbm
s" ndbm" add-lib
\c #include <ndbm.h>

\ ----===< int constants >===-----
#0	constant GDBM_READER
#1	constant GDBM_WRITER
#2	constant GDBM_WRCREAT
#3	constant GDBM_NEWDB
#7	constant GDBM_OPENMASK
#16	constant GDBM_FAST
#32	constant GDBM_SYNC
#64	constant GDBM_NOLOCK
#128	constant GDBM_NOMMAP
#256	constant GDBM_CLOEXEC
#512	constant GDBM_BSEXACT
#1024	constant GDBM_CLOERROR
#0	constant GDBM_INSERT
#1	constant GDBM_REPLACE
#1	constant GDBM_SETCACHESIZE
#2	constant GDBM_FASTMODE
#3	constant GDBM_SETSYNCMODE
#4	constant GDBM_SETCENTFREE
#5	constant GDBM_SETCOALESCEBLKS
#6	constant GDBM_SETMAXMAPSIZE
#7	constant GDBM_SETMMAP
#1	constant GDBM_CACHESIZE
#3	constant GDBM_SYNCMODE
#4	constant GDBM_CENTFREE
#5	constant GDBM_COALESCEBLKS
#8	constant GDBM_GETFLAGS
#9	constant GDBM_GETMMAP
#10	constant GDBM_GETCACHESIZE
#11	constant GDBM_GETSYNCMODE
#12	constant GDBM_GETCENTFREE
#13	constant GDBM_GETCOALESCEBLKS
#14	constant GDBM_GETMAXMAPSIZE
#15	constant GDBM_GETDBNAME
#16	constant GDBM_GETBLOCKSIZE
#1	constant GDBM_VERSION_MAJOR
#18	constant GDBM_VERSION_MINOR
#1	constant GDBM_VERSION_PATCH
#0	constant GDBM_RCVR_DEFAULT
#1	constant GDBM_RCVR_ERRFUN
#2	constant GDBM_RCVR_MAX_FAILED_KEYS
#4	constant GDBM_RCVR_MAX_FAILED_BUCKETS
#8	constant GDBM_RCVR_MAX_FAILURES
#16	constant GDBM_RCVR_BACKUP
#32	constant GDBM_RCVR_FORCE
#0	constant GDBM_DUMP_FMT_BINARY
#1	constant GDBM_DUMP_FMT_ASCII
#1	constant GDBM_META_MASK_MODE
#2	constant GDBM_META_MASK_OWNER
#0	constant GDBM_NO_ERROR
#1	constant GDBM_MALLOC_ERROR
#2	constant GDBM_BLOCK_SIZE_ERROR
#3	constant GDBM_FILE_OPEN_ERROR
#4	constant GDBM_FILE_WRITE_ERROR
#5	constant GDBM_FILE_SEEK_ERROR
#6	constant GDBM_FILE_READ_ERROR
#7	constant GDBM_BAD_MAGIC_NUMBER
#8	constant GDBM_EMPTY_DATABASE
#9	constant GDBM_CANT_BE_READER
#10	constant GDBM_CANT_BE_WRITER
#11	constant GDBM_READER_CANT_DELETE
#12	constant GDBM_READER_CANT_STORE
#13	constant GDBM_READER_CANT_REORGANIZE
#14	constant GDBM_UNKNOWN_ERROR
#15	constant GDBM_ITEM_NOT_FOUND
#16	constant GDBM_REORGANIZE_FAILED
#17	constant GDBM_CANNOT_REPLACE
#18	constant GDBM_ILLEGAL_DATA
#19	constant GDBM_OPT_ALREADY_SET
#20	constant GDBM_OPT_ILLEGAL
#21	constant GDBM_BYTE_SWAPPED
#22	constant GDBM_BAD_FILE_OFFSET
#23	constant GDBM_BAD_OPEN_FLAGS
#24	constant GDBM_FILE_STAT_ERROR
#25	constant GDBM_FILE_EOF
#26	constant GDBM_NO_DBNAME
#27	constant GDBM_ERR_FILE_OWNER
#28	constant GDBM_ERR_FILE_MODE
#29	constant GDBM_NEED_RECOVERY
#30	constant GDBM_BACKUP_FAILED
#31	constant GDBM_DIR_OVERFLOW
#32	constant GDBM_BAD_BUCKET
#33	constant GDBM_BAD_HEADER
#34	constant GDBM_BAD_AVAIL
#35	constant GDBM_BAD_HASH_TABLE
#36	constant GDBM_BAD_DIR_ENTRY
#37	constant GDBM_FILE_CLOSE_ERROR
#38	constant GDBM_FILE_SYNC_ERROR
#39	constant GDBM_FILE_TRUNCATE_ERROR
#0	constant _GDBM_MIN_ERRNO
#39	constant _GDBM_MAX_ERRNO
#14	constant GDBM_UNKNOWN_UPDATE

\ -------===< structs >===--------
\ DBM
begin-structure DBM
	drop 40 4 +field DBM-_dbm_errno
	drop 16 16 +field DBM-_dbm_memory
	drop 8 4 +field DBM-dirfd
	drop 32 8 +field DBM-_dbm_fetch_val
	drop 0 8 +field DBM-file
drop 48 end-structure
\ datum
begin-structure datum
	drop 8 4 +field datum-dsize
	drop 0 8 +field datum-dptr
drop 16 end-structure
\ gdbm_recovery
begin-structure gdbm_recovery
drop 88 end-structure

\ --===< function pointers >===---
c-funptr gdbm_recovery_s-errfun() {((struct gdbm_recovery_s*)ptr)->errfun} a s ... -- void	( data fmt <noname> -- )

\ ------===< functions >===-------
c-function dbm_open dbm_open a n n -- a	( file flags mode -- )
c-function dbm_close dbm_close a -- void	( dbf -- )
c-function dbm_fetch dbm_fetch a n -- n	( dbf key -- )
c-function dbm_store dbm_store a n n n -- n	( dbf key content flags -- )
c-function dbm_delete dbm_delete a n -- n	( dbf key -- )
c-function dbm_firstkey dbm_firstkey a -- n	( dbf -- )
c-function dbm_nextkey dbm_nextkey a -- n	( dbf -- )
c-function dbm_error dbm_error a -- n	( dbf -- )
c-function dbm_clearerr dbm_clearerr a -- void	( dbf -- )
c-function dbm_dirfno dbm_dirfno a -- n	( dbf -- )
c-function dbm_pagfno dbm_pagfno a -- n	( dbf -- )
c-function dbm_rdonly dbm_rdonly a -- n	( dbf -- )
c-function gdbm_fd_open gdbm_fd_open n s n n a -- a	( fd file_name block_size flags fatal_func -- )
c-function gdbm_open gdbm_open s n n n a -- a	( <noname> <noname> <noname> <noname> <noname> -- )
c-function gdbm_close gdbm_close a -- n	( <noname> -- )
c-function gdbm_store gdbm_store a a{*(datum*)} a{*(datum*)} n -- n	( <noname> <noname> <noname> <noname> -- )
c-function gdbm_fetch gdbm_fetch a a{*(datum*)} -- struct	( <noname> <noname> -- )
c-function gdbm_delete gdbm_delete a a{*(datum*)} -- n	( <noname> <noname> -- )
c-function gdbm_firstkey gdbm_firstkey a -- struct	( <noname> -- )
c-function gdbm_nextkey gdbm_nextkey a a{*(datum*)} -- struct	( <noname> <noname> -- )
c-function gdbm_reorganize gdbm_reorganize a -- n	( <noname> -- )
c-function gdbm_sync gdbm_sync a -- n	( <noname> -- )
c-function gdbm_exists gdbm_exists a a{*(datum*)} -- n	( <noname> <noname> -- )
c-function gdbm_setopt gdbm_setopt a n a n -- n	( <noname> <noname> <noname> <noname> -- )
c-function gdbm_fdesc gdbm_fdesc a -- n	( <noname> -- )
c-function gdbm_export gdbm_export a s n n -- n	( <noname> <noname> <noname> <noname> -- )
c-function gdbm_export_to_file gdbm_export_to_file a a -- n	( dbf fp -- )
c-function gdbm_import gdbm_import a s n -- n	( <noname> <noname> <noname> -- )
c-function gdbm_import_from_file gdbm_import_from_file a a n -- n	( dbf fp flag -- )
c-function gdbm_count gdbm_count a a -- n	( dbf pcount -- )
c-function gdbm_recover gdbm_recover a a n -- n	( dbf rcvr flags -- )
c-function gdbm_dump gdbm_dump a s n n n -- n	( <noname> <noname> fmt open_flags mode -- )
c-function gdbm_dump_to_file gdbm_dump_to_file a a n -- n	( <noname> <noname> fmt -- )
c-function gdbm_load gdbm_load a s n n a -- n	( <noname> <noname> replace meta_flags line -- )
c-function gdbm_load_from_file gdbm_load_from_file a a n n a -- n	( <noname> <noname> replace meta_flags line -- )
c-function gdbm_copy_meta gdbm_copy_meta a a -- n	( dst src -- )
c-function gdbm_errno_location gdbm_errno_location  -- a	( -- )
c-function gdbm_last_errno gdbm_last_errno a -- n	( dbf -- )
c-function gdbm_last_syserr gdbm_last_syserr a -- n	( dbf -- )
c-function gdbm_set_errno gdbm_set_errno a n n -- void	( dbf ec fatal -- )
c-function gdbm_clear_error gdbm_clear_error a -- void	( dbf -- )
c-function gdbm_needs_recovery gdbm_needs_recovery a -- n	( dbf -- )
c-function gdbm_check_syserr gdbm_check_syserr n -- n	( n -- )
c-function gdbm_strerror gdbm_strerror n -- s	( <noname> -- )
c-function gdbm_db_strerror gdbm_db_strerror a -- s	( dbf -- )
c-function gdbm_version_cmp gdbm_version_cmp a a -- n	( a b -- )

\ ----===< postfix >===-----
end-c-library
