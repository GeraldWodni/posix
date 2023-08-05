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
#2048	constant GDBM_XVERIFY
#4096	constant GDBM_PREREAD
#8192	constant GDBM_NUMSYNC
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
#17	constant GDBM_GETDBFORMAT
#18	constant GDBM_GETDIRDEPTH
#19	constant GDBM_GETBUCKETSIZE
#20	constant GDBM_GETCACHEAUTO
#21	constant GDBM_SETCACHEAUTO
#0	constant GDBM_CACHE_AUTO
#1	constant GDBM_VERSION_MAJOR
#23	constant GDBM_VERSION_MINOR
#0	constant GDBM_VERSION_PATCH
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
#0	constant _GDBM_MIN_ERRNO

\ --------===< enums >===---------
#0	constant GDBM_SNAPSHOT_OK
#1	constant GDBM_SNAPSHOT_BAD
#2	constant GDBM_SNAPSHOT_ERR
#3	constant GDBM_SNAPSHOT_SAME
#4	constant GDBM_SNAPSHOT_SUSPICIOUS
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
#18	constant GDBM_MALFORMED_DATA
#18	constant GDBM_ILLEGAL_DATA
#19	constant GDBM_OPT_ALREADY_SET
#20	constant GDBM_OPT_BADVAL
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
#40	constant GDBM_BUCKET_CACHE_CORRUPTED
#41	constant GDBM_BAD_HASH_ENTRY
#42	constant GDBM_ERR_SNAPSHOT_CLONE
#43	constant GDBM_ERR_REALPATH
#44	constant GDBM_ERR_USAGE

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
\ struct gdbm_recovery_s
begin-structure gdbm_recovery
drop 88 end-structure
\ struct gdbm_cache_stat
begin-structure gdbm_cache_stat
	drop 0 8 +field gdbm_cache_stat-adr
	drop 8 8 +field gdbm_cache_stat-hits
drop 16 end-structure

\ --===< function pointers >===---
	( data fmt <noname> -- )

\ ------===< functions >===-------
EXTERN: "C" void * dbm_open( void * file, int flags, int mode );	( file flags mode -- )
EXTERN: "C" void dbm_close( void * dbf );	( dbf -- )
EXTERN: "C" long dbm_fetch( void * dbf, long key );	( dbf key -- )
EXTERN: "C" int dbm_store( void * dbf, long key, long content, int flags );	( dbf key content flags -- )
EXTERN: "C" int dbm_delete( void * dbf, long key );	( dbf key -- )
EXTERN: "C" long dbm_firstkey( void * dbf );	( dbf -- )
EXTERN: "C" long dbm_nextkey( void * dbf );	( dbf -- )
EXTERN: "C" int dbm_error( void * dbf );	( dbf -- )
EXTERN: "C" void dbm_clearerr( void * dbf );	( dbf -- )
EXTERN: "C" int dbm_dirfno( void * dbf );	( dbf -- )
EXTERN: "C" int dbm_pagfno( void * dbf );	( dbf -- )
EXTERN: "C" int dbm_rdonly( void * dbf );	( dbf -- )
EXTERN: "C" void * gdbm_fd_open( int fd, char * file_name, int block_size, int flags, void * fatal_func );	( fd file_name block_size flags fatal_func -- )
EXTERN: "C" void * gdbm_open( char * , int , int , int , void *  );	( <noname> <noname> <noname> <noname> <noname> -- )
EXTERN: "C" int gdbm_close( void *  );	( <noname> -- )
EXTERN: "C" int gdbm_store( void * , void * , void * , int  );	( <noname> <noname> <noname> <noname> -- )
EXTERN: "C" struct gdbm_fetch( void * , void *  );	( <noname> <noname> -- )
EXTERN: "C" int gdbm_delete( void * , void *  );	( <noname> <noname> -- )
EXTERN: "C" struct gdbm_firstkey( void *  );	( <noname> -- )
EXTERN: "C" struct gdbm_nextkey( void * , void *  );	( <noname> <noname> -- )
EXTERN: "C" int gdbm_reorganize( void *  );	( <noname> -- )
EXTERN: "C" int gdbm_sync( void *  );	( <noname> -- )
EXTERN: "C" int gdbm_failure_atomic( void * , char * , char *  );	( <noname> <noname> <noname> -- )
EXTERN: "C" int gdbm_convert( void * dbf, int flag );	( dbf flag -- )
EXTERN: "C" int gdbm_latest_snapshot( char * , char * , void *  );	( <noname> <noname> <noname> -- )
EXTERN: "C" int gdbm_exists( void * , void *  );	( <noname> <noname> -- )
EXTERN: "C" int gdbm_setopt( void * , int , void * , int  );	( <noname> <noname> <noname> <noname> -- )
EXTERN: "C" int gdbm_fdesc( void *  );	( <noname> -- )
EXTERN: "C" int gdbm_export( void * , char * , int , int  );	( <noname> <noname> <noname> <noname> -- )
EXTERN: "C" int gdbm_export_to_file( void * dbf, void * fp );	( dbf fp -- )
EXTERN: "C" int gdbm_import( void * , char * , int  );	( <noname> <noname> <noname> -- )
EXTERN: "C" int gdbm_import_from_file( void * dbf, void * fp, int flag );	( dbf fp flag -- )
EXTERN: "C" int gdbm_count( void * dbf, void * pcount );	( dbf pcount -- )
EXTERN: "C" int gdbm_bucket_count( void * dbf, void * pcount );	( dbf pcount -- )
EXTERN: "C" int gdbm_avail_verify( void * dbf );	( dbf -- )
EXTERN: "C" int gdbm_recover( void * dbf, void * rcvr, int flags );	( dbf rcvr flags -- )
EXTERN: "C" int gdbm_dump( void * , char * , int fmt, int open_flags, int mode );	( <noname> <noname> fmt open_flags mode -- )
EXTERN: "C" int gdbm_dump_to_file( void * , void * , int fmt );	( <noname> <noname> fmt -- )
EXTERN: "C" int gdbm_load( void * , char * , int replace, int meta_flags, void * line );	( <noname> <noname> replace meta_flags line -- )
EXTERN: "C" int gdbm_load_from_file( void * , void * , int replace, int meta_flags, void * line );	( <noname> <noname> replace meta_flags line -- )
EXTERN: "C" int gdbm_copy_meta( void * dst, void * src );	( dst src -- )
EXTERN: "C" void * gdbm_errno_location(  );	( -- )
EXTERN: "C" int gdbm_last_errno( void * dbf );	( dbf -- )
EXTERN: "C" int gdbm_last_syserr( void * dbf );	( dbf -- )
EXTERN: "C" void gdbm_set_errno( void * dbf, int ec, int fatal );	( dbf ec fatal -- )
EXTERN: "C" void gdbm_clear_error( void * dbf );	( dbf -- )
EXTERN: "C" int gdbm_needs_recovery( void * dbf );	( dbf -- )
EXTERN: "C" int gdbm_check_syserr( int n );	( n -- )
EXTERN: "C" char * gdbm_strerror( int  );	( <noname> -- )
EXTERN: "C" char * gdbm_db_strerror( void * dbf );	( dbf -- )
EXTERN: "C" int gdbm_version_cmp( void * a, void * b );	( a b -- )
EXTERN: "C" void gdbm_get_cache_stats( void * dbf, void * access_count, void * cache_hits, void * cache_count, void * bstat, long nstat );	( dbf access_count cache_hits cache_count bstat nstat -- )

\ ----===< postfix >===-----
( none )
