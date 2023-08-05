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
FUNCTION: access ( __name __type -- n )	( __name __type -- )
FUNCTION: lseek ( __fd __offset __whence -- n )	( __fd __offset __whence -- )
FUNCTION: close ( __fd -- n )	( __fd -- )
FUNCTION: closefrom ( __lowfd -- void )	( __lowfd -- )
FUNCTION: read ( __fd __buf __nbytes -- n )	( __fd __buf __nbytes -- )
FUNCTION: write ( __fd __buf __n -- n )	( __fd __buf __n -- )
FUNCTION: pread ( __fd __buf __nbytes __offset -- n )	( __fd __buf __nbytes __offset -- )
FUNCTION: pwrite ( __fd __buf __n __offset -- n )	( __fd __buf __n __offset -- )
FUNCTION: pipe ( __pipedes -- n )	( __pipedes -- )
FUNCTION: alarm ( __seconds -- u )	( __seconds -- )
FUNCTION: sleep ( __seconds -- u )	( __seconds -- )
FUNCTION: ualarm ( __value __interval -- n )	( __value __interval -- )
FUNCTION: usleep ( __useconds -- n )	( __useconds -- )
FUNCTION: pause (  -- n )	( -- )
FUNCTION: chown ( __file __owner __group -- n )	( __file __owner __group -- )
FUNCTION: fchown ( __fd __owner __group -- n )	( __fd __owner __group -- )
FUNCTION: lchown ( __file __owner __group -- n )	( __file __owner __group -- )
FUNCTION: chdir ( __path -- n )	( __path -- )
FUNCTION: fchdir ( __fd -- n )	( __fd -- )
FUNCTION: getcwd ( __buf __size -- a )	( __buf __size -- )
FUNCTION: getwd ( __buf -- a )	( __buf -- )
FUNCTION: dup ( __fd -- n )	( __fd -- )
FUNCTION: dup2 ( __fd __fd2 -- n )	( __fd __fd2 -- )
FUNCTION: execve ( __path __argv __envp -- n )	( __path __argv __envp -- )
FUNCTION: fexecve ( __fd __argv __envp -- n )	( __fd __argv __envp -- )
FUNCTION: execv ( __path __argv -- n )	( __path __argv -- )
FUNCTION: execle ( __path __arg  -- n )	( __path __arg <noname> -- )
FUNCTION: execl ( __path __arg  -- n )	( __path __arg <noname> -- )
FUNCTION: execvp ( __file __argv -- n )	( __file __argv -- )
FUNCTION: execlp ( __file __arg  -- n )	( __file __arg <noname> -- )
FUNCTION: nice ( __inc -- n )	( __inc -- )
FUNCTION: _exit ( __status -- void )	( __status -- )
FUNCTION: pathconf ( __path __name -- n )	( __path __name -- )
FUNCTION: fpathconf ( __fd __name -- n )	( __fd __name -- )
FUNCTION: sysconf ( __name -- n )	( __name -- )
FUNCTION: getpid (  -- n )	( -- )
FUNCTION: getppid (  -- n )	( -- )
FUNCTION: getpgrp (  -- n )	( -- )
FUNCTION: __getpgid ( __pid -- n )	( __pid -- )
FUNCTION: getpgid ( __pid -- n )	( __pid -- )
FUNCTION: setpgid ( __pid __pgid -- n )	( __pid __pgid -- )
FUNCTION: setpgrp (  -- n )	( -- )
FUNCTION: setsid (  -- n )	( -- )
FUNCTION: getsid ( __pid -- n )	( __pid -- )
FUNCTION: getuid (  -- n )	( -- )
FUNCTION: geteuid (  -- n )	( -- )
FUNCTION: getgid (  -- n )	( -- )
FUNCTION: getegid (  -- n )	( -- )
FUNCTION: getgroups ( __size __list -- n )	( __size __list -- )
FUNCTION: setuid ( __uid -- n )	( __uid -- )
FUNCTION: setreuid ( __ruid __euid -- n )	( __ruid __euid -- )
FUNCTION: seteuid ( __uid -- n )	( __uid -- )
FUNCTION: setgid ( __gid -- n )	( __gid -- )
FUNCTION: setregid ( __rgid __egid -- n )	( __rgid __egid -- )
FUNCTION: setegid ( __gid -- n )	( __gid -- )
FUNCTION: fork (  -- n )	( -- )
FUNCTION: vfork (  -- n )	( -- )
FUNCTION: ttyname ( __fd -- a )	( __fd -- )
FUNCTION: ttyname_r ( __fd __buf __buflen -- n )	( __fd __buf __buflen -- )
FUNCTION: isatty ( __fd -- n )	( __fd -- )
FUNCTION: ttyslot (  -- n )	( -- )
FUNCTION: link ( __from __to -- n )	( __from __to -- )
FUNCTION: symlink ( __from __to -- n )	( __from __to -- )
FUNCTION: readlink ( __path __buf __len -- n )	( __path __buf __len -- )
FUNCTION: unlink ( __name -- n )	( __name -- )
FUNCTION: rmdir ( __path -- n )	( __path -- )
FUNCTION: tcgetpgrp ( __fd -- n )	( __fd -- )
FUNCTION: tcsetpgrp ( __fd __pgrp_id -- n )	( __fd __pgrp_id -- )
FUNCTION: getlogin (  -- a )	( -- )
FUNCTION: setlogin ( __name -- n )	( __name -- )
FUNCTION: gethostname ( __name __len -- n )	( __name __len -- )
FUNCTION: sethostname ( __name __len -- n )	( __name __len -- )
FUNCTION: sethostid ( __id -- n )	( __id -- )
FUNCTION: getdomainname ( __name __len -- n )	( __name __len -- )
FUNCTION: setdomainname ( __name __len -- n )	( __name __len -- )
FUNCTION: vhangup (  -- n )	( -- )
FUNCTION: revoke ( __file -- n )	( __file -- )
FUNCTION: profil ( __sample_buffer __size __offset __scale -- n )	( __sample_buffer __size __offset __scale -- )
FUNCTION: acct ( __name -- n )	( __name -- )
FUNCTION: getusershell (  -- a )	( -- )
FUNCTION: endusershell (  -- void )	( -- )
FUNCTION: setusershell (  -- void )	( -- )
FUNCTION: daemon ( __nochdir __noclose -- n )	( __nochdir __noclose -- )
FUNCTION: chroot ( __path -- n )	( __path -- )
FUNCTION: getpass ( __prompt -- a )	( __prompt -- )
FUNCTION: fsync ( __fd -- n )	( __fd -- )
FUNCTION: gethostid (  -- n )	( -- )
FUNCTION: sync (  -- void )	( -- )
FUNCTION: getpagesize (  -- n )	( -- )
FUNCTION: getdtablesize (  -- n )	( -- )
FUNCTION: truncate ( __file __length -- n )	( __file __length -- )
FUNCTION: ftruncate ( __fd __length -- n )	( __fd __length -- )
FUNCTION: brk ( __addr -- n )	( __addr -- )
FUNCTION: sbrk ( __delta -- a )	( __delta -- )
FUNCTION: syscall ( __sysno  -- n )	( __sysno <noname> -- )
FUNCTION: lockf ( __fd __cmd __len -- n )	( __fd __cmd __len -- )
FUNCTION: fdatasync ( __fildes -- n )	( __fildes -- )
FUNCTION: crypt ( __key __salt -- a )	( __key __salt -- )
FUNCTION: getentropy ( __buffer __length -- n )	( __buffer __length -- )

\ ----===< postfix >===-----
( none )
