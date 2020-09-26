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
#1	constant _WCHAR_H
#4294967295	constant WEOF
#-2147483648	constant WCHAR_MIN
#2147483647	constant WCHAR_MAX

\ ------===< functions >===-------
FUNCTION: wcscpy ( __dest __src -- a )	( __dest __src -- )
FUNCTION: wcsncpy ( __dest __src __n -- a )	( __dest __src __n -- )
FUNCTION: wcscat ( __dest __src -- a )	( __dest __src -- )
FUNCTION: wcsncat ( __dest __src __n -- a )	( __dest __src __n -- )
FUNCTION: wcscmp ( __s1 __s2 -- n )	( __s1 __s2 -- )
FUNCTION: wcsncmp ( __s1 __s2 __n -- n )	( __s1 __s2 __n -- )
FUNCTION: wcscasecmp ( __s1 __s2 -- n )	( __s1 __s2 -- )
FUNCTION: wcsncasecmp ( __s1 __s2 __n -- n )	( __s1 __s2 __n -- )
FUNCTION: wcscasecmp_l ( __s1 __s2 __loc -- n )	( __s1 __s2 __loc -- )
FUNCTION: wcsncasecmp_l ( __s1 __s2 __n __loc -- n )	( __s1 __s2 __n __loc -- )
FUNCTION: wcscoll ( __s1 __s2 -- n )	( __s1 __s2 -- )
FUNCTION: wcsxfrm ( __s1 __s2 __n -- u )	( __s1 __s2 __n -- )
FUNCTION: wcscoll_l ( __s1 __s2 __loc -- n )	( __s1 __s2 __loc -- )
FUNCTION: wcsxfrm_l ( __s1 __s2 __n __loc -- u )	( __s1 __s2 __n __loc -- )
FUNCTION: wcsdup ( __s -- a )	( __s -- )
FUNCTION: wcschr ( __wcs __wc -- a )	( __wcs __wc -- )
FUNCTION: wcsrchr ( __wcs __wc -- a )	( __wcs __wc -- )
FUNCTION: wcscspn ( __wcs __reject -- u )	( __wcs __reject -- )
FUNCTION: wcsspn ( __wcs __accept -- u )	( __wcs __accept -- )
FUNCTION: wcspbrk ( __wcs __accept -- a )	( __wcs __accept -- )
FUNCTION: wcsstr ( __haystack __needle -- a )	( __haystack __needle -- )
FUNCTION: wcstok ( __s __delim __ptr -- a )	( __s __delim __ptr -- )
FUNCTION: wcslen ( __s -- u )	( __s -- )
FUNCTION: wcsnlen ( __s __maxlen -- u )	( __s __maxlen -- )
FUNCTION: wmemchr ( __s __c __n -- a )	( __s __c __n -- )
FUNCTION: wmemcmp ( __s1 __s2 __n -- n )	( __s1 __s2 __n -- )
FUNCTION: wmemcpy ( __s1 __s2 __n -- a )	( __s1 __s2 __n -- )
FUNCTION: wmemmove ( __s1 __s2 __n -- a )	( __s1 __s2 __n -- )
FUNCTION: wmemset ( __s __c __n -- a )	( __s __c __n -- )
FUNCTION: btowc ( __c -- n )	( __c -- )
FUNCTION: wctob ( __c -- n )	( __c -- )
FUNCTION: mbsinit ( __ps -- n )	( __ps -- )
FUNCTION: mbrtowc ( __pwc __s __n __p -- u )	( __pwc __s __n __p -- )
FUNCTION: wcrtomb ( __s __wc __ps -- u )	( __s __wc __ps -- )
FUNCTION: __mbrlen ( __s __n __ps -- u )	( __s __n __ps -- )
FUNCTION: mbrlen ( __s __n __ps -- u )	( __s __n __ps -- )
FUNCTION: mbsrtowcs ( __dst __src __len __ps -- u )	( __dst __src __len __ps -- )
FUNCTION: wcsrtombs ( __dst __src __len __ps -- u )	( __dst __src __len __ps -- )
FUNCTION: mbsnrtowcs ( __dst __src __nmc __len __ps -- u )	( __dst __src __nmc __len __ps -- )
FUNCTION: wcsnrtombs ( __dst __src __nwc __len __ps -- u )	( __dst __src __nwc __len __ps -- )
FUNCTION: wcstod ( __nptr __endptr -- r )	( __nptr __endptr -- )
FUNCTION: wcstof ( __nptr __endptr -- r )	( __nptr __endptr -- )
FUNCTION: wcstold ( __nptr __endptr -- r )	( __nptr __endptr -- )
FUNCTION: wcstol ( __nptr __endptr __base -- n )	( __nptr __endptr __base -- )
FUNCTION: wcstoul ( __nptr __endptr __base -- u )	( __nptr __endptr __base -- )
FUNCTION: wcstoll ( __nptr __endptr __base -- d )	( __nptr __endptr __base -- )
FUNCTION: wcstoull ( __nptr __endptr __base -- ud )	( __nptr __endptr __base -- )
FUNCTION: wcpcpy ( __dest __src -- a )	( __dest __src -- )
FUNCTION: wcpncpy ( __dest __src __n -- a )	( __dest __src __n -- )
FUNCTION: vfwscanf ( __s __format __arg -- n )	( __s __format __arg -- )
FUNCTION: vwscanf ( __format __arg -- n )	( __format __arg -- )
FUNCTION: vswscanf ( __s __format __arg -- n )	( __s __format __arg -- )
FUNCTION: fgetwc ( __stream -- n )	( __stream -- )
FUNCTION: getwc ( __stream -- n )	( __stream -- )
FUNCTION: getwchar (  -- n )	( -- )
FUNCTION: fputwc ( __wc __stream -- n )	( __wc __stream -- )
FUNCTION: putwc ( __wc __stream -- n )	( __wc __stream -- )
FUNCTION: putwchar ( __wc -- n )	( __wc -- )
FUNCTION: fgetws ( __ws __n __stream -- a )	( __ws __n __stream -- )
FUNCTION: fputws ( __ws __stream -- n )	( __ws __stream -- )
FUNCTION: ungetwc ( __wc __stream -- n )	( __wc __stream -- )
FUNCTION: wcsftime ( __s __maxsize __format __tp -- u )	( __s __maxsize __format __tp -- )

\ ----===< postfix >===-----
( none )
