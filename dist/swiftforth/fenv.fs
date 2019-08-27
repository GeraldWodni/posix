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
FUNCTION: feclearexcept ( __excepts -- n )	( __excepts -- )
FUNCTION: fegetexceptflag ( __flagp __excepts -- n )	( __flagp __excepts -- )
FUNCTION: feraiseexcept ( __excepts -- n )	( __excepts -- )
FUNCTION: fesetexceptflag ( __flagp __excepts -- n )	( __flagp __excepts -- )
FUNCTION: fetestexcept ( __excepts -- n )	( __excepts -- )
FUNCTION: fegetround (  -- n )	( -- )
FUNCTION: fesetround ( __rounding_direction -- n )	( __rounding_direction -- )
FUNCTION: fegetenv ( __envp -- n )	( __envp -- )
FUNCTION: feholdexcept ( __envp -- n )	( __envp -- )
FUNCTION: fesetenv ( __envp -- n )	( __envp -- )
FUNCTION: feupdateenv ( __envp -- n )	( __envp -- )

\ ----===< postfix >===-----
( none )
