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
#1	constant _UNISTD_H
#200809	constant _POSIX_VERSION
#200809	constant __POSIX2_THIS_VERSION
#200809	constant _POSIX2_VERSION
#200809	constant _POSIX2_C_VERSION
#200809	constant _POSIX2_C_BIND
#200809	constant _POSIX2_C_DEV
#200809	constant _POSIX2_SW_DEV
#200809	constant _POSIX2_LOCALEDEF
#700	constant _XOPEN_VERSION
#4	constant _XOPEN_XCU_VERSION
#1	constant _XOPEN_XPG2
#1	constant _XOPEN_XPG3
#1	constant _XOPEN_XPG4
#1	constant _XOPEN_UNIX
#1	constant _XOPEN_ENH_I18N
#1	constant _XOPEN_LEGACY
#0	constant STDIN_FILENO
#1	constant STDOUT_FILENO
#2	constant STDERR_FILENO
#4	constant R_OK
#2	constant W_OK
#1	constant X_OK
#0	constant F_OK
#0	constant SEEK_SET
#1	constant SEEK_CUR
#2	constant SEEK_END
#0	constant L_SET
#1	constant L_INCR
#2	constant L_XTND
#0	constant F_ULOCK
#1	constant F_LOCK
#2	constant F_TLOCK
#3	constant F_TEST

\ ------===< functions >===-------
EXTERN: "C" int access( char * __name, int __type );	( __name __type -- )
EXTERN: "C" n lseek( int __fd, n __offset, int __whence );	( __fd __offset __whence -- )
EXTERN: "C" int close( int __fd );	( __fd -- )
EXTERN: "C" n read( int __fd, void * __buf, n __nbytes );	( __fd __buf __nbytes -- )
EXTERN: "C" n write( int __fd, void * __buf, n __n );	( __fd __buf __n -- )
EXTERN: "C" n pread( int __fd, void * __buf, n __nbytes, n __offset );	( __fd __buf __nbytes __offset -- )
EXTERN: "C" n pwrite( int __fd, void * __buf, n __n, n __offset );	( __fd __buf __n __offset -- )
EXTERN: "C" int pipe( void * __pipedes );	( __pipedes -- )
EXTERN: "C" int alarm( int __seconds );	( __seconds -- )
EXTERN: "C" int sleep( int __seconds );	( __seconds -- )
EXTERN: "C" n ualarm( n __value, n __interval );	( __value __interval -- )
EXTERN: "C" int usleep( n __useconds );	( __useconds -- )
EXTERN: "C" int pause(  );	( -- )
EXTERN: "C" int chown( char * __file, n __owner, n __group );	( __file __owner __group -- )
EXTERN: "C" int fchown( int __fd, n __owner, n __group );	( __fd __owner __group -- )
EXTERN: "C" int lchown( char * __file, n __owner, n __group );	( __file __owner __group -- )
EXTERN: "C" int chdir( char * __path );	( __path -- )
EXTERN: "C" int fchdir( int __fd );	( __fd -- )
EXTERN: "C" void * getcwd( void * __buf, n __size );	( __buf __size -- )
EXTERN: "C" void * getwd( void * __buf );	( __buf -- )
EXTERN: "C" int dup( int __fd );	( __fd -- )
EXTERN: "C" int dup2( int __fd, int __fd2 );	( __fd __fd2 -- )
EXTERN: "C" int execve( char * __path, void * __argv, void * __envp );	( __path __argv __envp -- )
EXTERN: "C" int fexecve( int __fd, void * __argv, void * __envp );	( __fd __argv __envp -- )
EXTERN: "C" int execv( char * __path, void * __argv );	( __path __argv -- )
EXTERN: "C" int execle( char * __path, char * __arg, ...  );	( __path __arg <noname> -- )
EXTERN: "C" int execl( char * __path, char * __arg, ...  );	( __path __arg <noname> -- )
EXTERN: "C" int execvp( char * __file, void * __argv );	( __file __argv -- )
EXTERN: "C" int execlp( char * __file, char * __arg, ...  );	( __file __arg <noname> -- )
EXTERN: "C" int nice( int __inc );	( __inc -- )
EXTERN: "C" void _exit( int __status );	( __status -- )
EXTERN: "C" long pathconf( char * __path, int __name );	( __path __name -- )
EXTERN: "C" long fpathconf( int __fd, int __name );	( __fd __name -- )
EXTERN: "C" long sysconf( int __name );	( __name -- )
EXTERN: "C" n getpid(  );	( -- )
EXTERN: "C" n getppid(  );	( -- )
EXTERN: "C" n getpgrp(  );	( -- )
EXTERN: "C" n __getpgid( n __pid );	( __pid -- )
EXTERN: "C" n getpgid( n __pid );	( __pid -- )
EXTERN: "C" int setpgid( n __pid, n __pgid );	( __pid __pgid -- )
EXTERN: "C" int setpgrp(  );	( -- )
EXTERN: "C" n setsid(  );	( -- )
EXTERN: "C" n getsid( n __pid );	( __pid -- )
EXTERN: "C" n getuid(  );	( -- )
EXTERN: "C" n geteuid(  );	( -- )
EXTERN: "C" n getgid(  );	( -- )
EXTERN: "C" n getegid(  );	( -- )
EXTERN: "C" int getgroups( int __size, void * __list );	( __size __list -- )
EXTERN: "C" int setuid( n __uid );	( __uid -- )
EXTERN: "C" int setreuid( n __ruid, n __euid );	( __ruid __euid -- )
EXTERN: "C" int seteuid( n __uid );	( __uid -- )
EXTERN: "C" int setgid( n __gid );	( __gid -- )
EXTERN: "C" int setregid( n __rgid, n __egid );	( __rgid __egid -- )
EXTERN: "C" int setegid( n __gid );	( __gid -- )
EXTERN: "C" n fork(  );	( -- )
EXTERN: "C" n vfork(  );	( -- )
EXTERN: "C" void * ttyname( int __fd );	( __fd -- )
EXTERN: "C" int ttyname_r( int __fd, void * __buf, n __buflen );	( __fd __buf __buflen -- )
EXTERN: "C" int isatty( int __fd );	( __fd -- )
EXTERN: "C" int ttyslot(  );	( -- )
EXTERN: "C" int link( char * __from, char * __to );	( __from __to -- )
EXTERN: "C" int symlink( char * __from, char * __to );	( __from __to -- )
EXTERN: "C" n readlink( char * __path, void * __buf, n __len );	( __path __buf __len -- )
EXTERN: "C" int unlink( char * __name );	( __name -- )
EXTERN: "C" int rmdir( char * __path );	( __path -- )
EXTERN: "C" n tcgetpgrp( int __fd );	( __fd -- )
EXTERN: "C" int tcsetpgrp( int __fd, n __pgrp_id );	( __fd __pgrp_id -- )
EXTERN: "C" void * getlogin(  );	( -- )
EXTERN: "C" int setlogin( char * __name );	( __name -- )
EXTERN: "C" int gethostname( void * __name, n __len );	( __name __len -- )
EXTERN: "C" int sethostname( char * __name, n __len );	( __name __len -- )
EXTERN: "C" int sethostid( long __id );	( __id -- )
EXTERN: "C" int getdomainname( void * __name, n __len );	( __name __len -- )
EXTERN: "C" int setdomainname( char * __name, n __len );	( __name __len -- )
EXTERN: "C" int vhangup(  );	( -- )
EXTERN: "C" int revoke( char * __file );	( __file -- )
EXTERN: "C" int profil( void * __sample_buffer, n __size, n __offset, int __scale );	( __sample_buffer __size __offset __scale -- )
EXTERN: "C" int acct( char * __name );	( __name -- )
EXTERN: "C" void * getusershell(  );	( -- )
EXTERN: "C" void endusershell(  );	( -- )
EXTERN: "C" void setusershell(  );	( -- )
EXTERN: "C" int daemon( int __nochdir, int __noclose );	( __nochdir __noclose -- )
EXTERN: "C" int chroot( char * __path );	( __path -- )
EXTERN: "C" void * getpass( char * __prompt );	( __prompt -- )
EXTERN: "C" int fsync( int __fd );	( __fd -- )
EXTERN: "C" long gethostid(  );	( -- )
EXTERN: "C" void sync(  );	( -- )
EXTERN: "C" int getpagesize(  );	( -- )
EXTERN: "C" int getdtablesize(  );	( -- )
EXTERN: "C" int truncate( char * __file, n __length );	( __file __length -- )
EXTERN: "C" int ftruncate( int __fd, n __length );	( __fd __length -- )
EXTERN: "C" int brk( void * __addr );	( __addr -- )
EXTERN: "C" void * sbrk( n __delta );	( __delta -- )
EXTERN: "C" long syscall( long __sysno, ...  );	( __sysno <noname> -- )
EXTERN: "C" int lockf( int __fd, int __cmd, n __len );	( __fd __cmd __len -- )
EXTERN: "C" void * crypt( char * __key, char * __salt );	( __key __salt -- )
EXTERN: "C" void swab( void * __from, void * __to, n __n );	( __from __to __n -- )
EXTERN: "C" int getentropy( void * __buffer, n __length );	( __buffer __length -- )

\ ----===< postfix >===-----
( none )
