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

\ ----===< int constants >===-----
#1	constant _SETJMP_H

\ -------===< structs >===--------
\ __jmp_buf_tag
begin-structure __jmp_buf_tag
	drop 64 4 +field __jmp_buf_tag-__mask_was_saved
	drop 0 64 +field __jmp_buf_tag-__jmpbuf
	drop 72 128 +field __jmp_buf_tag-__saved_mask
drop 200 end-structure

\ ------===< functions >===-------
c-function setjmp setjmp a -- n	( __env -- )
c-function __sigsetjmp __sigsetjmp a n -- n	( __env __savemask -- )
c-function _setjmp _setjmp a -- n	( __env -- )
c-function longjmp longjmp a n -- void	( __env __val -- )

\ ----===< postfix >===-----
end-c-library
