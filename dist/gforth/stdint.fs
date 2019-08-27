\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library stdint
s" stdint" add-lib
\c #include <stdint.h>

\ ----===< int constants >===-----
#1	constant _STDINT_H
#-128	constant INT8_MIN
#-32768	constant INT16_MIN
#-2147483648	constant INT32_MIN
#127	constant INT8_MAX
#32767	constant INT16_MAX
#2147483647	constant INT32_MAX
#255	constant UINT8_MAX
#65535	constant UINT16_MAX
#4294967295	constant UINT32_MAX
#-128	constant INT_LEAST8_MIN
#-32768	constant INT_LEAST16_MIN
#-2147483648	constant INT_LEAST32_MIN
#127	constant INT_LEAST8_MAX
#32767	constant INT_LEAST16_MAX
#2147483647	constant INT_LEAST32_MAX
#255	constant UINT_LEAST8_MAX
#65535	constant UINT_LEAST16_MAX
#4294967295	constant UINT_LEAST32_MAX
#-128	constant INT_FAST8_MIN
#-9223372036854775808	constant INT_FAST16_MIN
#-9223372036854775808	constant INT_FAST32_MIN
#127	constant INT_FAST8_MAX
#9223372036854775807	constant INT_FAST16_MAX
#9223372036854775807	constant INT_FAST32_MAX
#255	constant UINT_FAST8_MAX
#18446744073709551615	constant UINT_FAST16_MAX
#18446744073709551615	constant UINT_FAST32_MAX
#-9223372036854775808	constant INTPTR_MIN
#9223372036854775807	constant INTPTR_MAX
#18446744073709551615	constant UINTPTR_MAX
#-9223372036854775808	constant PTRDIFF_MIN
#9223372036854775807	constant PTRDIFF_MAX
#-2147483648	constant SIG_ATOMIC_MIN
#2147483647	constant SIG_ATOMIC_MAX
#18446744073709551615	constant SIZE_MAX
#0	constant WINT_MIN
#4294967295	constant WINT_MAX

\ ----===< long constants >===-----
#-9223372036854775808.	2constant INT64_MIN
#9223372036854775807.	2constant INT64_MAX
#18446744073709551615.	2constant UINT64_MAX
#-9223372036854775808.	2constant INT_LEAST64_MIN
#9223372036854775807.	2constant INT_LEAST64_MAX
#18446744073709551615.	2constant UINT_LEAST64_MAX
#-9223372036854775808.	2constant INT_FAST64_MIN
#9223372036854775807.	2constant INT_FAST64_MAX
#18446744073709551615.	2constant UINT_FAST64_MAX
#-9223372036854775808.	2constant INTMAX_MIN
#9223372036854775807.	2constant INTMAX_MAX
#18446744073709551615.	2constant UINTMAX_MAX

\ ----===< postfix >===-----
end-c-library
