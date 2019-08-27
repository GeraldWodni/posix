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
EXTERN: "C" void * wcsncpy( void * __dest, char * __src, n __n );	( __dest __src __n -- )
EXTERN: "C" void * wcscat( void * __dest, char * __src );	( __dest __src -- )
EXTERN: "C" void * wcsncat( void * __dest, char * __src, n __n );	( __dest __src __n -- )
EXTERN: "C" int wcscmp( char * __s1, char * __s2 );	( __s1 __s2 -- )
EXTERN: "C" int wcsncmp( char * __s1, char * __s2, n __n );	( __s1 __s2 __n -- )
EXTERN: "C" int wcscoll( char * __s1, char * __s2 );	( __s1 __s2 -- )
EXTERN: "C" n wcsxfrm( void * __s1, char * __s2, n __n );	( __s1 __s2 __n -- )
EXTERN: "C" void * wcschr( char * __wcs, int __wc );	( __wcs __wc -- )
EXTERN: "C" void * wcsrchr( char * __wcs, int __wc );	( __wcs __wc -- )
EXTERN: "C" n wcscspn( char * __wcs, char * __reject );	( __wcs __reject -- )
EXTERN: "C" n wcsspn( char * __wcs, char * __accept );	( __wcs __accept -- )
EXTERN: "C" void * wcspbrk( char * __wcs, char * __accept );	( __wcs __accept -- )
EXTERN: "C" void * wcsstr( char * __haystack, char * __needle );	( __haystack __needle -- )
EXTERN: "C" void * wcstok( void * __s, char * __delim, void * __ptr );	( __s __delim __ptr -- )
EXTERN: "C" n wcslen( char * __s );	( __s -- )
EXTERN: "C" void * wmemchr( char * __s, int __c, n __n );	( __s __c __n -- )
EXTERN: "C" int wmemcmp( char * __s1, char * __s2, n __n );	( __s1 __s2 __n -- )
EXTERN: "C" void * wmemcpy( void * __s1, char * __s2, n __n );	( __s1 __s2 __n -- )
EXTERN: "C" void * wmemmove( void * __s1, char * __s2, n __n );	( __s1 __s2 __n -- )
EXTERN: "C" void * wmemset( void * __s, int __c, n __n );	( __s __c __n -- )
EXTERN: "C" n btowc( int __c );	( __c -- )
EXTERN: "C" int wctob( n __c );	( __c -- )
EXTERN: "C" int mbsinit( void * __ps );	( __ps -- )
EXTERN: "C" n mbrtowc( void * __pwc, char * __s, n __n, void * __p );	( __pwc __s __n __p -- )
EXTERN: "C" n wcrtomb( void * __s, int __wc, void * __ps );	( __s __wc __ps -- )
EXTERN: "C" n __mbrlen( char * __s, n __n, void * __ps );	( __s __n __ps -- )
EXTERN: "C" n mbrlen( char * __s, n __n, void * __ps );	( __s __n __ps -- )
EXTERN: "C" n mbsrtowcs( void * __dst, void * __src, n __len, void * __ps );	( __dst __src __len __ps -- )
EXTERN: "C" n wcsrtombs( void * __dst, void * __src, n __len, void * __ps );	( __dst __src __len __ps -- )
EXTERN: "C" double wcstod( char * __nptr, void * __endptr );	( __nptr __endptr -- )
EXTERN: "C" float wcstof( char * __nptr, void * __endptr );	( __nptr __endptr -- )
EXTERN: "C" double wcstold( char * __nptr, void * __endptr );	( __nptr __endptr -- )
EXTERN: "C" long wcstol( char * __nptr, void * __endptr, int __base );	( __nptr __endptr __base -- )
EXTERN: "C" long wcstoul( char * __nptr, void * __endptr, int __base );	( __nptr __endptr __base -- )
EXTERN: "C" long long wcstoll( char * __nptr, void * __endptr, int __base );	( __nptr __endptr __base -- )
EXTERN: "C" long long wcstoull( char * __nptr, void * __endptr, int __base );	( __nptr __endptr __base -- )
EXTERN: "C" int vfwscanf( void * __s, char * __format, n __arg );	( __s __format __arg -- )
EXTERN: "C" int vwscanf( char * __format, n __arg );	( __format __arg -- )
EXTERN: "C" int vswscanf( char * __s, char * __format, n __arg );	( __s __format __arg -- )
EXTERN: "C" n fgetwc( void * __stream );	( __stream -- )
EXTERN: "C" n getwc( void * __stream );	( __stream -- )
EXTERN: "C" n getwchar(  );	( -- )
EXTERN: "C" n fputwc( int __wc, void * __stream );	( __wc __stream -- )
EXTERN: "C" n putwc( int __wc, void * __stream );	( __wc __stream -- )
EXTERN: "C" n putwchar( int __wc );	( __wc -- )
EXTERN: "C" void * fgetws( void * __ws, int __n, void * __stream );	( __ws __n __stream -- )
EXTERN: "C" int fputws( char * __ws, void * __stream );	( __ws __stream -- )
EXTERN: "C" n ungetwc( n __wc, void * __stream );	( __wc __stream -- )
EXTERN: "C" n wcsftime( void * __s, n __maxsize, char * __format, void * __tp );	( __s __maxsize __format __tp -- )

\ ----===< postfix >===-----
( none )
