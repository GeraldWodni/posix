\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library wchar
s" wchar" add-lib
\c #undef WCHAR_MIN
\c #undef WCHAR_MAX
\c #include <wchar.h>

\ ----===< int constants >===-----
#1	constant _WCHAR_H
#4294967295	constant WEOF
#-2147483648	constant WCHAR_MIN
#2147483647	constant WCHAR_MAX

\ ------===< functions >===-------
c-function wcscpy wcscpy a ws -- a	( __dest __src -- )
c-function wcsncpy wcsncpy a ws u -- a	( __dest __src __n -- )
c-function wcscat wcscat a ws -- a	( __dest __src -- )
c-function wcsncat wcsncat a ws u -- a	( __dest __src __n -- )
c-function wcscmp wcscmp ws ws -- n	( __s1 __s2 -- )
c-function wcsncmp wcsncmp ws ws u -- n	( __s1 __s2 __n -- )
c-function wcscasecmp wcscasecmp ws ws -- n	( __s1 __s2 -- )
c-function wcsncasecmp wcsncasecmp ws ws u -- n	( __s1 __s2 __n -- )
c-function wcscasecmp_l wcscasecmp_l ws ws n -- n	( __s1 __s2 __loc -- )
c-function wcsncasecmp_l wcsncasecmp_l ws ws u n -- n	( __s1 __s2 __n __loc -- )
c-function wcscoll wcscoll ws ws -- n	( __s1 __s2 -- )
c-function wcsxfrm wcsxfrm a ws u -- u	( __s1 __s2 __n -- )
c-function wcscoll_l wcscoll_l ws ws n -- n	( __s1 __s2 __loc -- )
c-function wcsxfrm_l wcsxfrm_l a ws u n -- u	( __s1 __s2 __n __loc -- )
c-function wcsdup wcsdup ws -- a	( __s -- )
c-function wcschr wcschr ws n -- a	( __wcs __wc -- )
c-function wcsrchr wcsrchr ws n -- a	( __wcs __wc -- )
c-function wcscspn wcscspn ws ws -- u	( __wcs __reject -- )
c-function wcsspn wcsspn ws ws -- u	( __wcs __accept -- )
c-function wcspbrk wcspbrk ws ws -- a	( __wcs __accept -- )
c-function wcsstr wcsstr ws ws -- a	( __haystack __needle -- )
c-function wcstok wcstok a ws a -- a	( __s __delim __ptr -- )
c-function wcslen wcslen ws -- u	( __s -- )
c-function wcsnlen wcsnlen ws u -- u	( __s __maxlen -- )
c-function wmemchr wmemchr ws n u -- a	( __s __c __n -- )
c-function wmemcmp wmemcmp ws ws u -- n	( __s1 __s2 __n -- )
c-function wmemcpy wmemcpy a ws u -- a	( __s1 __s2 __n -- )
c-function wmemmove wmemmove a ws u -- a	( __s1 __s2 __n -- )
c-function wmemset wmemset a n u -- a	( __s __c __n -- )
c-function btowc btowc n -- n	( __c -- )
c-function wctob wctob n -- n	( __c -- )
c-function mbsinit mbsinit a -- n	( __ps -- )
c-function mbrtowc mbrtowc a s u a -- u	( __pwc __s __n __p -- )
c-function wcrtomb wcrtomb a n a -- u	( __s __wc __ps -- )
c-function __mbrlen __mbrlen s u a -- u	( __s __n __ps -- )
c-function mbrlen mbrlen s u a -- u	( __s __n __ps -- )
c-function mbsrtowcs mbsrtowcs a a u a -- u	( __dst __src __len __ps -- )
c-function wcsrtombs wcsrtombs a a u a -- u	( __dst __src __len __ps -- )
c-function mbsnrtowcs mbsnrtowcs a a u u a -- u	( __dst __src __nmc __len __ps -- )
c-function wcsnrtombs wcsnrtombs a a u u a -- u	( __dst __src __nwc __len __ps -- )
c-function wcstod wcstod ws a -- r	( __nptr __endptr -- )
c-function wcstof wcstof ws a -- r	( __nptr __endptr -- )
c-function wcstold wcstold ws a -- r	( __nptr __endptr -- )
c-function wcstol wcstol ws a n -- n	( __nptr __endptr __base -- )
c-function wcstoul wcstoul ws a n -- u	( __nptr __endptr __base -- )
c-function wcstoll wcstoll ws a n -- d	( __nptr __endptr __base -- )
c-function wcstoull wcstoull ws a n -- ud	( __nptr __endptr __base -- )
c-function wcpcpy wcpcpy a ws -- a	( __dest __src -- )
c-function wcpncpy wcpncpy a ws u -- a	( __dest __src __n -- )
c-function vfwscanf vfwscanf a ws n -- n	( __s __format __arg -- )
c-function vwscanf vwscanf ws n -- n	( __format __arg -- )
c-function vswscanf vswscanf ws ws n -- n	( __s __format __arg -- )
c-function fgetwc fgetwc a -- n	( __stream -- )
c-function getwc getwc a -- n	( __stream -- )
c-function getwchar getwchar  -- n	( -- )
c-function fputwc fputwc n a -- n	( __wc __stream -- )
c-function putwc putwc n a -- n	( __wc __stream -- )
c-function putwchar putwchar n -- n	( __wc -- )
c-function fgetws fgetws a n a -- a	( __ws __n __stream -- )
c-function fputws fputws ws a -- n	( __ws __stream -- )
c-function ungetwc ungetwc n a -- n	( __wc __stream -- )
c-function wcsftime wcsftime a u ws a -- u	( __s __maxsize __format __tp -- )

\ ----===< postfix >===-----
end-c-library
