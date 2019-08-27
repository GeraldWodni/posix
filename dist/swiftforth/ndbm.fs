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
	( data fmt <noname> -- )

\ ------===< functions >===-------
FUNCTION: dbm_open ( file flags mode -- a )	( file flags mode -- )
FUNCTION: dbm_close ( dbf -- void )	( dbf -- )
FUNCTION: dbm_fetch ( dbf key -- n )	( dbf key -- )
FUNCTION: dbm_store ( dbf key content flags -- n )	( dbf key content flags -- )
FUNCTION: dbm_delete ( dbf key -- n )	( dbf key -- )
FUNCTION: dbm_firstkey ( dbf -- n )	( dbf -- )
FUNCTION: dbm_nextkey ( dbf -- n )	( dbf -- )
FUNCTION: dbm_error ( dbf -- n )	( dbf -- )
FUNCTION: dbm_clearerr ( dbf -- void )	( dbf -- )
FUNCTION: dbm_dirfno ( dbf -- n )	( dbf -- )
FUNCTION: dbm_pagfno ( dbf -- n )	( dbf -- )
FUNCTION: dbm_rdonly ( dbf -- n )	( dbf -- )
FUNCTION: gdbm_fd_open ( fd file_name block_size flags fatal_func -- a )	( fd file_name block_size flags fatal_func -- )
FUNCTION: gdbm_open (      -- a )	( <noname> <noname> <noname> <noname> <noname> -- )
FUNCTION: gdbm_close (  -- n )	( <noname> -- )
FUNCTION: gdbm_store (     -- n )	( <noname> <noname> <noname> <noname> -- )
FUNCTION: gdbm_fetch (   -- struct )	( <noname> <noname> -- )
FUNCTION: gdbm_delete (   -- n )	( <noname> <noname> -- )
FUNCTION: gdbm_firstkey (  -- struct )	( <noname> -- )
FUNCTION: gdbm_nextkey (   -- struct )	( <noname> <noname> -- )
FUNCTION: gdbm_reorganize (  -- n )	( <noname> -- )
FUNCTION: gdbm_sync (  -- n )	( <noname> -- )
FUNCTION: gdbm_exists (   -- n )	( <noname> <noname> -- )
FUNCTION: gdbm_setopt (     -- n )	( <noname> <noname> <noname> <noname> -- )
FUNCTION: gdbm_fdesc (  -- n )	( <noname> -- )
FUNCTION: gdbm_export (     -- n )	( <noname> <noname> <noname> <noname> -- )
FUNCTION: gdbm_export_to_file ( dbf fp -- n )	( dbf fp -- )
FUNCTION: gdbm_import (    -- n )	( <noname> <noname> <noname> -- )
FUNCTION: gdbm_import_from_file ( dbf fp flag -- n )	( dbf fp flag -- )
FUNCTION: gdbm_count ( dbf pcount -- n )	( dbf pcount -- )
FUNCTION: gdbm_recover ( dbf rcvr flags -- n )	( dbf rcvr flags -- )
FUNCTION: gdbm_dump (   fmt open_flags mode -- n )	( <noname> <noname> fmt open_flags mode -- )
FUNCTION: gdbm_dump_to_file (   fmt -- n )	( <noname> <noname> fmt -- )
FUNCTION: gdbm_load (   replace meta_flags line -- n )	( <noname> <noname> replace meta_flags line -- )
FUNCTION: gdbm_load_from_file (   replace meta_flags line -- n )	( <noname> <noname> replace meta_flags line -- )
FUNCTION: gdbm_copy_meta ( dst src -- n )	( dst src -- )
FUNCTION: gdbm_errno_location (  -- a )	( -- )
FUNCTION: gdbm_last_errno ( dbf -- n )	( dbf -- )
FUNCTION: gdbm_last_syserr ( dbf -- n )	( dbf -- )
FUNCTION: gdbm_set_errno ( dbf ec fatal -- void )	( dbf ec fatal -- )
FUNCTION: gdbm_clear_error ( dbf -- void )	( dbf -- )
FUNCTION: gdbm_needs_recovery ( dbf -- n )	( dbf -- )
FUNCTION: gdbm_check_syserr ( n -- n )	( n -- )
FUNCTION: gdbm_strerror (  -- s )	( <noname> -- )
FUNCTION: gdbm_db_strerror ( dbf -- s )	( dbf -- )
FUNCTION: gdbm_version_cmp ( a b -- n )	( a b -- )

\ ----===< postfix >===-----
( none )
