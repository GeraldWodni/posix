\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library assert
s" assert" add-lib
\c #include <assert.h>

\ ----===< int constants >===-----
#1	constant _ASSERT_H

\ ------===< functions >===-------
c-function __assert_fail __assert_fail s s u s -- void	( __assertion __file __line __function -- )
c-function __assert_perror_fail __assert_perror_fail n s u s -- void	( __errnum __file __line __function -- )
c-function __assert __assert s s n -- void	( __assertion __file __line -- )

\ ----===< postfix >===-----
end-c-library
