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
#1	constant _FENV_H

\ --------===< enums >===---------
#1	constant FE_INVALID
#4	constant FE_DIVBYZERO
#8	constant FE_OVERFLOW
#16	constant FE_UNDERFLOW
#32	constant FE_INEXACT
#0	constant FE_TONEAREST
#1024	constant FE_DOWNWARD
#2048	constant FE_UPWARD
#3072	constant FE_TOWARDZERO

\ ------===< functions >===-------
EXTERN: "C" int feclearexcept( int __excepts );	( __excepts -- )
EXTERN: "C" int fegetexceptflag( void * __flagp, int __excepts );	( __flagp __excepts -- )
EXTERN: "C" int feraiseexcept( int __excepts );	( __excepts -- )
EXTERN: "C" int fesetexceptflag( void * __flagp, int __excepts );	( __flagp __excepts -- )
EXTERN: "C" int fetestexcept( int __excepts );	( __excepts -- )
EXTERN: "C" int fegetround(  );	( -- )
EXTERN: "C" int fesetround( int __rounding_direction );	( __rounding_direction -- )
EXTERN: "C" int fegetenv( void * __envp );	( __envp -- )
EXTERN: "C" int feholdexcept( void * __envp );	( __envp -- )
EXTERN: "C" int fesetenv( void * __envp );	( __envp -- )
EXTERN: "C" int feupdateenv( void * __envp );	( __envp -- )

\ ----===< postfix >===-----
( none )
