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

\ ------===< functions >===-------
FUNCTION: setjmp ( __env -- n )	( __env -- )
FUNCTION: sigsetjmp ( __env __savemask -- n )	( __env __savemask -- )
FUNCTION: longjmp ( __env __val -- void )	( __env __val -- )
FUNCTION: siglongjmp ( __env __val -- void )	( __env __val -- )

\ ----===< postfix >===-----
( none )
