\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library setjmp
s" setjmp" add-lib
\c #include <setjmp.h>

\ ------===< functions >===-------
c-function setjmp setjmp a -- n	( __env -- )
c-function sigsetjmp sigsetjmp a n -- n	( __env __savemask -- )
c-function longjmp longjmp a n -- void	( __env __val -- )
c-function siglongjmp siglongjmp a n -- void	( __env __val -- )

\ ----===< postfix >===-----
end-c-library
