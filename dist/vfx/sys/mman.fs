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
#1	constant _SYS_MMAN_H
#1	constant PROT_READ
#2	constant PROT_WRITE
#4	constant PROT_EXEC
#0	constant PROT_NONE
#16777216	constant PROT_GROWSDOWN
#33554432	constant PROT_GROWSUP
#1	constant MAP_SHARED
#2	constant MAP_PRIVATE
#3	constant MAP_SHARED_VALIDATE
#15	constant MAP_TYPE
#16	constant MAP_FIXED
#0	constant MAP_FILE
#32	constant MAP_ANONYMOUS
#32	constant MAP_ANON
#26	constant MAP_HUGE_SHIFT
#63	constant MAP_HUGE_MASK
#1	constant MS_ASYNC
#4	constant MS_SYNC
#2	constant MS_INVALIDATE
#0	constant POSIX_MADV_NORMAL
#1	constant POSIX_MADV_RANDOM
#2	constant POSIX_MADV_SEQUENTIAL
#3	constant POSIX_MADV_WILLNEED
#4	constant POSIX_MADV_DONTNEED
#1	constant MCL_CURRENT
#2	constant MCL_FUTURE
#4	constant MCL_ONFAULT

\ ------===< functions >===-------
EXTERN: "C" void * mmap( void * __addr, long __len, int __prot, int __flags, int __fd, long __offset );	( __addr __len __prot __flags __fd __offset -- )
EXTERN: "C" int munmap( void * __addr, long __len );	( __addr __len -- )
EXTERN: "C" int mprotect( void * __addr, long __len, int __prot );	( __addr __len __prot -- )
EXTERN: "C" int msync( void * __addr, long __len, int __flags );	( __addr __len __flags -- )
EXTERN: "C" int posix_madvise( void * __addr, long __len, int __advice );	( __addr __len __advice -- )
EXTERN: "C" int mlock( void * __addr, long __len );	( __addr __len -- )
EXTERN: "C" int munlock( void * __addr, long __len );	( __addr __len -- )
EXTERN: "C" int mlockall( int __flags );	( __flags -- )
EXTERN: "C" int munlockall(  );	( -- )
EXTERN: "C" int shm_open( char * __name, int __oflag, long __mode );	( __name __oflag __mode -- )
EXTERN: "C" int shm_unlink( char * __name );	( __name -- )

\ ----===< postfix >===-----
( none )
