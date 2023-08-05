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
FUNCTION: remove ( __filename -- n )	( __filename -- )
FUNCTION: rename ( __old __new -- n )	( __old __new -- )
FUNCTION: fclose ( __stream -- n )	( __stream -- )
FUNCTION: tmpfile (  -- a )	( -- )
FUNCTION: tmpnam (  -- a )	( <noname> -- )
FUNCTION: fflush ( __stream -- n )	( __stream -- )
FUNCTION: fopen ( __filename __modes -- a )	( __filename __modes -- )
FUNCTION: freopen ( __filename __modes __stream -- a )	( __filename __modes __stream -- )
FUNCTION: fdopen ( __fd __modes -- a )	( __fd __modes -- )
FUNCTION: setbuf ( __stream __buf -- void )	( __stream __buf -- )
FUNCTION: setvbuf ( __stream __buf __modes __n -- n )	( __stream __buf __modes __n -- )
FUNCTION: fprintf ( __stream __format  -- n )	( __stream __format <noname> -- )
FUNCTION: printf ( __format  -- n )	( __format <noname> -- )
FUNCTION: sprintf ( __s __format  -- n )	( __s __format <noname> -- )
FUNCTION: vfprintf ( __s __format __arg -- n )	( __s __format __arg -- )
FUNCTION: vprintf ( __format __arg -- n )	( __format __arg -- )
FUNCTION: vsprintf ( __s __format __arg -- n )	( __s __format __arg -- )
FUNCTION: snprintf ( __s __maxlen __format  -- n )	( __s __maxlen __format <noname> -- )
FUNCTION: vsnprintf ( __s __maxlen __format __arg -- n )	( __s __maxlen __format __arg -- )
FUNCTION: vdprintf ( __fd __fmt __arg -- n )	( __fd __fmt __arg -- )
FUNCTION: dprintf ( __fd __fmt  -- n )	( __fd __fmt <noname> -- )
FUNCTION: fscanf ( __stream __format  -- n )	( __stream __format <noname> -- )
FUNCTION: scanf ( __format  -- n )	( __format <noname> -- )
FUNCTION: sscanf ( __s __format  -- n )	( __s __format <noname> -- )
FUNCTION: vfscanf ( __s __format __arg -- n )	( __s __format __arg -- )
FUNCTION: vscanf ( __format __arg -- n )	( __format __arg -- )
FUNCTION: vsscanf ( __s __format __arg -- n )	( __s __format __arg -- )
FUNCTION: fgetc ( __stream -- n )	( __stream -- )
FUNCTION: getc ( __stream -- n )	( __stream -- )
FUNCTION: getchar (  -- n )	( -- )
FUNCTION: fputc ( __c __stream -- n )	( __c __stream -- )
FUNCTION: putc ( __c __stream -- n )	( __c __stream -- )
FUNCTION: putchar ( __c -- n )	( __c -- )
FUNCTION: fgets ( __s __n __stream -- a )	( __s __n __stream -- )
FUNCTION: fputs ( __s __stream -- n )	( __s __stream -- )
FUNCTION: puts ( __s -- n )	( __s -- )
FUNCTION: ungetc ( __c __stream -- n )	( __c __stream -- )
FUNCTION: fread ( __ptr __size __n __stream -- u )	( __ptr __size __n __stream -- )
FUNCTION: fwrite ( __ptr __size __n __s -- u )	( __ptr __size __n __s -- )
FUNCTION: fseek ( __stream __off __whence -- n )	( __stream __off __whence -- )
FUNCTION: ftell ( __stream -- n )	( __stream -- )
FUNCTION: rewind ( __stream -- void )	( __stream -- )
FUNCTION: fseeko ( __stream __off __whence -- n )	( __stream __off __whence -- )
FUNCTION: ftello ( __stream -- n )	( __stream -- )
FUNCTION: fgetpos ( __stream __pos -- n )	( __stream __pos -- )
FUNCTION: fsetpos ( __stream __pos -- n )	( __stream __pos -- )
FUNCTION: clearerr ( __stream -- void )	( __stream -- )
FUNCTION: feof ( __stream -- n )	( __stream -- )
FUNCTION: ferror ( __stream -- n )	( __stream -- )
FUNCTION: perror ( __s -- void )	( __s -- )
FUNCTION: fileno ( __stream -- n )	( __stream -- )
FUNCTION: ctermid ( __s -- a )	( __s -- )
FUNCTION: __uflow (  -- n )	( <noname> -- )
FUNCTION: __overflow (   -- n )	( <noname> <noname> -- )

\ ----===< postfix >===-----
( none )
