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

\ ------===< callbacks >===-------
	( <noname> -- )

\ ------===< functions >===-------
FUNCTION: __sysv_signal ( __sig __handler -- a )	( __sig __handler -- )
FUNCTION: raise ( __sig -- n )	( __sig -- )
FUNCTION: __libc_current_sigrtmin (  -- n )	( -- )
FUNCTION: __libc_current_sigrtmax (  -- n )	( -- )

\ ----===< postfix >===-----
( none )
