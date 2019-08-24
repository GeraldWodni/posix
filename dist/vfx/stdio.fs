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
#1	constant _STDIO_H
#0	constant _IOFBF
#1	constant _IOLBF
#2	constant _IONBF
#8192	constant BUFSIZ
#-1	constant EOF
#0	constant SEEK_SET
#1	constant SEEK_CUR
#2	constant SEEK_END

\ ------===< functions >===-------
EXTERN: "C" int remove( char * __filename );	( __filename -- )
EXTERN: "C" int rename( char * __old, char * __new );	( __old __new -- )
EXTERN: "C" void * tmpfile(  );	( -- )
EXTERN: "C" void * tmpnam( void * __s );	( __s -- )
EXTERN: "C" int fclose( void * __stream );	( __stream -- )
EXTERN: "C" int fflush( void * __stream );	( __stream -- )
EXTERN: "C" void * fopen( char * __filename, char * __modes );	( __filename __modes -- )
EXTERN: "C" void * freopen( char * __filename, char * __modes, void * __stream );	( __filename __modes __stream -- )
EXTERN: "C" void setbuf( void * __stream, void * __buf );	( __stream __buf -- )
EXTERN: "C" int setvbuf( void * __stream, void * __buf, int __modes, n __n );	( __stream __buf __modes __n -- )
EXTERN: "C" int fprintf( void * __stream, char * __format, ...  );	( __stream __format <noname> -- )
EXTERN: "C" int printf( char * __format, ...  );	( __format <noname> -- )
EXTERN: "C" int sprintf( void * __s, char * __format, ...  );	( __s __format <noname> -- )
EXTERN: "C" int vfprintf( void * __s, char * __format, n __arg );	( __s __format __arg -- )
EXTERN: "C" int vprintf( char * __format, n __arg );	( __format __arg -- )
EXTERN: "C" int vsprintf( void * __s, char * __format, n __arg );	( __s __format __arg -- )
EXTERN: "C" int snprintf( void * __s, n __maxlen, char * __format, ...  );	( __s __maxlen __format <noname> -- )
EXTERN: "C" int vsnprintf( void * __s, n __maxlen, char * __format, n __arg );	( __s __maxlen __format __arg -- )
EXTERN: "C" int fscanf( void * __stream, char * __format, ...  );	( __stream __format <noname> -- )
EXTERN: "C" int scanf( char * __format, ...  );	( __format <noname> -- )
EXTERN: "C" int sscanf( char * __s, char * __format, ...  );	( __s __format <noname> -- )
EXTERN: "C" int vfscanf( void * __s, char * __format, n __arg );	( __s __format __arg -- )
EXTERN: "C" int vscanf( char * __format, n __arg );	( __format __arg -- )
EXTERN: "C" int vsscanf( char * __s, char * __format, n __arg );	( __s __format __arg -- )
EXTERN: "C" int fgetc( void * __stream );	( __stream -- )
EXTERN: "C" int getc( void * __stream );	( __stream -- )
EXTERN: "C" int getchar(  );	( -- )
EXTERN: "C" int fputc( int __c, void * __stream );	( __c __stream -- )
EXTERN: "C" int putc( int __c, void * __stream );	( __c __stream -- )
EXTERN: "C" int putchar( int __c );	( __c -- )
EXTERN: "C" void * fgets( void * __s, int __n, void * __stream );	( __s __n __stream -- )
EXTERN: "C" int fputs( char * __s, void * __stream );	( __s __stream -- )
EXTERN: "C" int puts( char * __s );	( __s -- )
EXTERN: "C" int ungetc( int __c, void * __stream );	( __c __stream -- )
EXTERN: "C" n fread( void * __ptr, n __size, n __n, void * __stream );	( __ptr __size __n __stream -- )
EXTERN: "C" n fwrite( void * __ptr, n __size, n __n, void * __s );	( __ptr __size __n __s -- )
EXTERN: "C" int fseek( void * __stream, long __off, int __whence );	( __stream __off __whence -- )
EXTERN: "C" long ftell( void * __stream );	( __stream -- )
EXTERN: "C" void rewind( void * __stream );	( __stream -- )
EXTERN: "C" int fgetpos( void * __stream, void * __pos );	( __stream __pos -- )
EXTERN: "C" int fsetpos( void * __stream, void * __pos );	( __stream __pos -- )
EXTERN: "C" void clearerr( void * __stream );	( __stream -- )
EXTERN: "C" int feof( void * __stream );	( __stream -- )
EXTERN: "C" int ferror( void * __stream );	( __stream -- )
EXTERN: "C" void perror( char * __s );	( __s -- )
EXTERN: "C" int __uflow( void *  );	( <noname> -- )
EXTERN: "C" int __overflow( void * , int  );	( <noname> <noname> -- )

\ ----===< postfix >===-----
( none )
