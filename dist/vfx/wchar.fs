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
EXTERN: "C" void * wcscpy( void * __dest, char * __src );	( __dest __src -- )
EXTERN: "C" void * wcsncpy( void * __dest, char * __src, long __n );	( __dest __src __n -- )
EXTERN: "C" void * wcscat( void * __dest, char * __src );	( __dest __src -- )
EXTERN: "C" void * wcsncat( void * __dest, char * __src, long __n );	( __dest __src __n -- )
EXTERN: "C" int wcscmp( char * __s1, char * __s2 );	( __s1 __s2 -- )
EXTERN: "C" int wcsncmp( char * __s1, char * __s2, long __n );	( __s1 __s2 __n -- )
EXTERN: "C" int wcscasecmp( char * __s1, char * __s2 );	( __s1 __s2 -- )
EXTERN: "C" int wcsncasecmp( char * __s1, char * __s2, long __n );	( __s1 __s2 __n -- )
EXTERN: "C" int wcscasecmp_l( char * __s1, char * __s2, long __loc );	( __s1 __s2 __loc -- )
EXTERN: "C" int wcsncasecmp_l( char * __s1, char * __s2, long __n, long __loc );	( __s1 __s2 __n __loc -- )
EXTERN: "C" int wcscoll( char * __s1, char * __s2 );	( __s1 __s2 -- )
EXTERN: "C" long wcsxfrm( void * __s1, char * __s2, long __n );	( __s1 __s2 __n -- )
EXTERN: "C" int wcscoll_l( char * __s1, char * __s2, long __loc );	( __s1 __s2 __loc -- )
EXTERN: "C" long wcsxfrm_l( void * __s1, char * __s2, long __n, long __loc );	( __s1 __s2 __n __loc -- )
EXTERN: "C" void * wcsdup( char * __s );	( __s -- )
EXTERN: "C" void * wcschr( char * __wcs, int __wc );	( __wcs __wc -- )
EXTERN: "C" void * wcsrchr( char * __wcs, int __wc );	( __wcs __wc -- )
EXTERN: "C" long wcscspn( char * __wcs, char * __reject );	( __wcs __reject -- )
EXTERN: "C" long wcsspn( char * __wcs, char * __accept );	( __wcs __accept -- )
EXTERN: "C" void * wcspbrk( char * __wcs, char * __accept );	( __wcs __accept -- )
EXTERN: "C" void * wcsstr( char * __haystack, char * __needle );	( __haystack __needle -- )
EXTERN: "C" void * wcstok( void * __s, char * __delim, void * __ptr );	( __s __delim __ptr -- )
EXTERN: "C" long wcslen( char * __s );	( __s -- )
EXTERN: "C" long wcsnlen( char * __s, long __maxlen );	( __s __maxlen -- )
EXTERN: "C" void * wmemchr( char * __s, int __c, long __n );	( __s __c __n -- )
EXTERN: "C" int wmemcmp( char * __s1, char * __s2, long __n );	( __s1 __s2 __n -- )
EXTERN: "C" void * wmemcpy( void * __s1, char * __s2, long __n );	( __s1 __s2 __n -- )
EXTERN: "C" void * wmemmove( void * __s1, char * __s2, long __n );	( __s1 __s2 __n -- )
EXTERN: "C" void * wmemset( void * __s, int __c, long __n );	( __s __c __n -- )
EXTERN: "C" long btowc( int __c );	( __c -- )
EXTERN: "C" int wctob( long __c );	( __c -- )
EXTERN: "C" int mbsinit( void * __ps );	( __ps -- )
EXTERN: "C" long mbrtowc( void * __pwc, char * __s, long __n, void * __p );	( __pwc __s __n __p -- )
EXTERN: "C" long wcrtomb( void * __s, int __wc, void * __ps );	( __s __wc __ps -- )
EXTERN: "C" long __mbrlen( char * __s, long __n, void * __ps );	( __s __n __ps -- )
EXTERN: "C" long mbrlen( char * __s, long __n, void * __ps );	( __s __n __ps -- )
EXTERN: "C" long mbsrtowcs( void * __dst, void * __src, long __len, void * __ps );	( __dst __src __len __ps -- )
EXTERN: "C" long wcsrtombs( void * __dst, void * __src, long __len, void * __ps );	( __dst __src __len __ps -- )
EXTERN: "C" long mbsnrtowcs( void * __dst, void * __src, long __nmc, long __len, void * __ps );	( __dst __src __nmc __len __ps -- )
EXTERN: "C" long wcsnrtombs( void * __dst, void * __src, long __nwc, long __len, void * __ps );	( __dst __src __nwc __len __ps -- )
EXTERN: "C" double wcstod( char * __nptr, void * __endptr );	( __nptr __endptr -- )
EXTERN: "C" float wcstof( char * __nptr, void * __endptr );	( __nptr __endptr -- )
EXTERN: "C" double wcstold( char * __nptr, void * __endptr );	( __nptr __endptr -- )
EXTERN: "C" long wcstol( char * __nptr, void * __endptr, int __base );	( __nptr __endptr __base -- )
EXTERN: "C" long wcstoul( char * __nptr, void * __endptr, int __base );	( __nptr __endptr __base -- )
EXTERN: "C" long long wcstoll( char * __nptr, void * __endptr, int __base );	( __nptr __endptr __base -- )
EXTERN: "C" long long wcstoull( char * __nptr, void * __endptr, int __base );	( __nptr __endptr __base -- )
EXTERN: "C" void * wcpcpy( void * __dest, char * __src );	( __dest __src -- )
EXTERN: "C" void * wcpncpy( void * __dest, char * __src, long __n );	( __dest __src __n -- )
EXTERN: "C" int vfwscanf( void * __s, char * __format, long __arg );	( __s __format __arg -- )
EXTERN: "C" int vwscanf( char * __format, long __arg );	( __format __arg -- )
EXTERN: "C" int vswscanf( char * __s, char * __format, long __arg );	( __s __format __arg -- )
EXTERN: "C" long fgetwc( void * __stream );	( __stream -- )
EXTERN: "C" long getwc( void * __stream );	( __stream -- )
EXTERN: "C" long getwchar(  );	( -- )
EXTERN: "C" long fputwc( int __wc, void * __stream );	( __wc __stream -- )
EXTERN: "C" long putwc( int __wc, void * __stream );	( __wc __stream -- )
EXTERN: "C" long putwchar( int __wc );	( __wc -- )
EXTERN: "C" void * fgetws( void * __ws, int __n, void * __stream );	( __ws __n __stream -- )
EXTERN: "C" int fputws( char * __ws, void * __stream );	( __ws __stream -- )
EXTERN: "C" long ungetwc( long __wc, void * __stream );	( __wc __stream -- )
EXTERN: "C" long wcsftime( void * __s, long __maxsize, char * __format, void * __tp );	( __s __maxsize __format __tp -- )

\ ----===< postfix >===-----
( none )
