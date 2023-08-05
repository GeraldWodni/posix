\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library sys_mman
s" sys_mman" add-lib
\c #include <sys/mman.h>

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
c-function mmap mmap a u n n n n -- a	( __addr __len __prot __flags __fd __offset -- )
c-function munmap munmap a u -- n	( __addr __len -- )
c-function mprotect mprotect a u n -- n	( __addr __len __prot -- )
c-function msync msync a u n -- n	( __addr __len __flags -- )
c-function posix_madvise posix_madvise a u n -- n	( __addr __len __advice -- )
c-function mlock mlock a u -- n	( __addr __len -- )
c-function munlock munlock a u -- n	( __addr __len -- )
c-function mlockall mlockall n -- n	( __flags -- )
c-function munlockall munlockall  -- n	( -- )
c-function shm_open shm_open s n n -- n	( __name __oflag __mode -- )
c-function shm_unlink shm_unlink s -- n	( __name -- )

\ ----===< postfix >===-----
end-c-library
