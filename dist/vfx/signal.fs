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
EXTERN: "C" void * __sysv_signal( int __sig, void * __handler );	( __sig __handler -- )
EXTERN: "C" int raise( int __sig );	( __sig -- )
EXTERN: "C" int __libc_current_sigrtmin(  );	( -- )
EXTERN: "C" int __libc_current_sigrtmax(  );	( -- )

\ ----===< postfix >===-----
( none )
