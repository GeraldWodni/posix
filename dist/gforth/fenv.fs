\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library fenv
s" fenv" add-lib
\c #include <fenv.h>

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
c-function feclearexcept feclearexcept n -- n	( __excepts -- )
c-function fegetexceptflag fegetexceptflag a n -- n	( __flagp __excepts -- )
c-function feraiseexcept feraiseexcept n -- n	( __excepts -- )
c-function fesetexceptflag fesetexceptflag a n -- n	( __flagp __excepts -- )
c-function fetestexcept fetestexcept n -- n	( __excepts -- )
c-function fegetround fegetround  -- n	( -- )
c-function fesetround fesetround n -- n	( __rounding_direction -- )
c-function fegetenv fegetenv a -- n	( __envp -- )
c-function feholdexcept feholdexcept a -- n	( __envp -- )
c-function fesetenv fesetenv a -- n	( __envp -- )
c-function feupdateenv feupdateenv a -- n	( __envp -- )

\ ----===< postfix >===-----
end-c-library
