\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library stdio
s" stdio" add-lib
\c #include <stdio.h>

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
c-function remove remove s -- n	( __filename -- )
c-function rename rename s s -- n	( __old __new -- )
c-function fclose fclose a -- n	( __stream -- )
c-function tmpfile tmpfile  -- a	( -- )
c-function tmpnam tmpnam a -- a	( <noname> -- )
c-function fflush fflush a -- n	( __stream -- )
c-function fopen fopen s s -- a	( __filename __modes -- )
c-function freopen freopen s s a -- a	( __filename __modes __stream -- )
c-function fdopen fdopen n s -- a	( __fd __modes -- )
c-function setbuf setbuf a a -- void	( __stream __buf -- )
c-function setvbuf setvbuf a a n u -- n	( __stream __buf __modes __n -- )
c-function fprintf fprintf a s ... -- n	( __stream __format <noname> -- )
c-function printf printf s ... -- n	( __format <noname> -- )
c-function sprintf sprintf a s ... -- n	( __s __format <noname> -- )
c-function vfprintf vfprintf a s n -- n	( __s __format __arg -- )
c-function vprintf vprintf s n -- n	( __format __arg -- )
c-function vsprintf vsprintf a s n -- n	( __s __format __arg -- )
c-function snprintf snprintf a u s ... -- n	( __s __maxlen __format <noname> -- )
c-function vsnprintf vsnprintf a u s n -- n	( __s __maxlen __format __arg -- )
c-function vdprintf vdprintf n s n -- n	( __fd __fmt __arg -- )
c-function dprintf dprintf n s ... -- n	( __fd __fmt <noname> -- )
c-function fscanf fscanf a s ... -- n	( __stream __format <noname> -- )
c-function scanf scanf s ... -- n	( __format <noname> -- )
c-function sscanf sscanf s s ... -- n	( __s __format <noname> -- )
c-function vfscanf vfscanf a s n -- n	( __s __format __arg -- )
c-function vscanf vscanf s n -- n	( __format __arg -- )
c-function vsscanf vsscanf s s n -- n	( __s __format __arg -- )
c-function fgetc fgetc a -- n	( __stream -- )
c-function getc getc a -- n	( __stream -- )
c-function getchar getchar  -- n	( -- )
c-function fputc fputc n a -- n	( __c __stream -- )
c-function putc putc n a -- n	( __c __stream -- )
c-function putchar putchar n -- n	( __c -- )
c-function fgets fgets a n a -- a	( __s __n __stream -- )
c-function fputs fputs s a -- n	( __s __stream -- )
c-function puts puts s -- n	( __s -- )
c-function ungetc ungetc n a -- n	( __c __stream -- )
c-function fread fread a u u a -- u	( __ptr __size __n __stream -- )
c-function fwrite fwrite a u u a -- u	( __ptr __size __n __s -- )
c-function fseek fseek a n n -- n	( __stream __off __whence -- )
c-function ftell ftell a -- n	( __stream -- )
c-function rewind rewind a -- void	( __stream -- )
c-function fseeko fseeko a n n -- n	( __stream __off __whence -- )
c-function ftello ftello a -- n	( __stream -- )
c-function fgetpos fgetpos a a -- n	( __stream __pos -- )
c-function fsetpos fsetpos a a -- n	( __stream __pos -- )
c-function clearerr clearerr a -- void	( __stream -- )
c-function feof feof a -- n	( __stream -- )
c-function ferror ferror a -- n	( __stream -- )
c-function perror perror s -- void	( __s -- )
c-function fileno fileno a -- n	( __stream -- )
c-function ctermid ctermid a -- a	( __s -- )
c-function __uflow __uflow a -- n	( <noname> -- )
c-function __overflow __overflow a n -- n	( <noname> <noname> -- )

\ ----===< postfix >===-----
end-c-library
