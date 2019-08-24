\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library math
s" math" add-lib
\c #include <math.h>

\ ----===< int constants >===-----
#1	constant _MATH_H

\ ---===< float constants >===----
infe0	fconstant HUGE_VAL
2.718282e0	fconstant M_E
1.442695e0	fconstant M_LOG2E
0.434294e0	fconstant M_LOG10E
0.693147e0	fconstant M_LN2
2.302585e0	fconstant M_LN10
3.141593e0	fconstant M_PI
1.570796e0	fconstant M_PI_2
0.785398e0	fconstant M_PI_4
0.318310e0	fconstant M_1_PI
0.636620e0	fconstant M_2_PI
1.128379e0	fconstant M_2_SQRTPI
1.414214e0	fconstant M_SQRT2
0.707107e0	fconstant M_SQRT1_2

\ ----===< postfix >===-----
end-c-library
