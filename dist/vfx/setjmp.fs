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

\ -------===< structs >===--------
\ __jmp_buf_tag
begin-structure __jmp_buf_tag
	drop 64 4 +field __jmp_buf_tag-__mask_was_saved
	drop 0 64 +field __jmp_buf_tag-__jmpbuf
	drop 72 128 +field __jmp_buf_tag-__saved_mask
drop 200 end-structure

\ ------===< functions >===-------
EXTERN: "C" int setjmp( void * __env );	( __env -- )
EXTERN: "C" int sigsetjmp( void * __env, int __savemask );	( __env __savemask -- )
EXTERN: "C" void longjmp( void * __env, int __val );	( __env __val -- )
EXTERN: "C" void siglongjmp( void * __env, int __val );	( __env __val -- )

\ ----===< postfix >===-----
( none )
