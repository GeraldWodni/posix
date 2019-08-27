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
#1	constant _DLFCN_H
#1	constant RTLD_LAZY
#2	constant RTLD_NOW
#3	constant RTLD_BINDING_MASK
#4	constant RTLD_NOLOAD
#8	constant RTLD_DEEPBIND
#256	constant RTLD_GLOBAL
#0	constant RTLD_LOCAL
#4096	constant RTLD_NODELETE

\ ------===< functions >===-------
FUNCTION: dlopen ( __file __mode -- a )	( __file __mode -- )
FUNCTION: dlclose ( __handle -- n )	( __handle -- )
FUNCTION: dlsym ( __handle __name -- a )	( __handle __name -- )
FUNCTION: dlerror (  -- a )	( -- )

\ ----===< postfix >===-----
( none )
