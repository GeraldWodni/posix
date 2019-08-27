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
#16	constant MAP_FIXED
#1	constant MS_ASYNC
#4	constant MS_SYNC
#2	constant MS_INVALIDATE
#1	constant MCL_CURRENT
#2	constant MCL_FUTURE
#4	constant MCL_ONFAULT

\ ------===< functions >===-------
FUNCTION: mmap ( __addr __len __prot __flags __fd __offset -- a )	( __addr __len __prot __flags __fd __offset -- )
FUNCTION: munmap ( __addr __len -- n )	( __addr __len -- )
FUNCTION: mprotect ( __addr __len __prot -- n )	( __addr __len __prot -- )
FUNCTION: msync ( __addr __len __flags -- n )	( __addr __len __flags -- )
FUNCTION: mlock ( __addr __len -- n )	( __addr __len -- )
FUNCTION: munlock ( __addr __len -- n )	( __addr __len -- )
FUNCTION: mlockall ( __flags -- n )	( __flags -- )
FUNCTION: munlockall (  -- n )	( -- )
FUNCTION: shm_open ( __name __oflag __mode -- n )	( __name __oflag __mode -- )
FUNCTION: shm_unlink ( __name -- n )	( __name -- )

\ ----===< postfix >===-----
( none )
