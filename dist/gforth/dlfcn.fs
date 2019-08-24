\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library dlfcn
s" dlfcn" add-lib
\c #include <dlfcn.h>

\ ----===< int constants >===-----
#1	constant _DLFCN_H

\ ------===< functions >===-------
c-function dlopen dlopen s n -- a	( __file __mode -- )
c-function dlclose dlclose a -- n	( __handle -- )
c-function dlsym dlsym a s -- a	( __handle __name -- )
c-function dlerror dlerror  -- a	( -- )

\ ----===< postfix >===-----
end-c-library
