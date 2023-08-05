\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library unistd
s" unistd" add-lib
\c #include <unistd.h>

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
c-function access access s n -- n	( __name __type -- )
c-function lseek lseek n n n -- n	( __fd __offset __whence -- )
c-function close close n -- n	( __fd -- )
c-function closefrom closefrom n -- void	( __lowfd -- )
c-function read read n a u -- n	( __fd __buf __nbytes -- )
c-function write write n a u -- n	( __fd __buf __n -- )
c-function pread pread n a u n -- n	( __fd __buf __nbytes __offset -- )
c-function pwrite pwrite n a u n -- n	( __fd __buf __n __offset -- )
c-function pipe pipe a -- n	( __pipedes -- )
c-function alarm alarm u -- u	( __seconds -- )
c-function sleep sleep u -- u	( __seconds -- )
c-function ualarm ualarm n n -- n	( __value __interval -- )
c-function usleep usleep n -- n	( __useconds -- )
c-function pause pause  -- n	( -- )
c-function chown chown s n n -- n	( __file __owner __group -- )
c-function fchown fchown n n n -- n	( __fd __owner __group -- )
c-function lchown lchown s n n -- n	( __file __owner __group -- )
c-function chdir chdir s -- n	( __path -- )
c-function fchdir fchdir n -- n	( __fd -- )
c-function getcwd getcwd a u -- a	( __buf __size -- )
c-function getwd getwd a -- a	( __buf -- )
c-function dup dup n -- n	( __fd -- )
c-function dup2 dup2 n n -- n	( __fd __fd2 -- )
c-function execve execve s a a -- n	( __path __argv __envp -- )
c-function fexecve fexecve n a a -- n	( __fd __argv __envp -- )
c-function execv execv s a -- n	( __path __argv -- )
c-function execle execle s s ... -- n	( __path __arg <noname> -- )
c-function execl execl s s ... -- n	( __path __arg <noname> -- )
c-function execvp execvp s a -- n	( __file __argv -- )
c-function execlp execlp s s ... -- n	( __file __arg <noname> -- )
c-function nice nice n -- n	( __inc -- )
c-function _exit _exit n -- void	( __status -- )
c-function pathconf pathconf s n -- n	( __path __name -- )
c-function fpathconf fpathconf n n -- n	( __fd __name -- )
c-function sysconf sysconf n -- n	( __name -- )
c-function getpid getpid  -- n	( -- )
c-function getppid getppid  -- n	( -- )
c-function getpgrp getpgrp  -- n	( -- )
c-function __getpgid __getpgid n -- n	( __pid -- )
c-function getpgid getpgid n -- n	( __pid -- )
c-function setpgid setpgid n n -- n	( __pid __pgid -- )
c-function setpgrp setpgrp  -- n	( -- )
c-function setsid setsid  -- n	( -- )
c-function getsid getsid n -- n	( __pid -- )
c-function getuid getuid  -- n	( -- )
c-function geteuid geteuid  -- n	( -- )
c-function getgid getgid  -- n	( -- )
c-function getegid getegid  -- n	( -- )
c-function getgroups getgroups n a -- n	( __size __list -- )
c-function setuid setuid n -- n	( __uid -- )
c-function setreuid setreuid n n -- n	( __ruid __euid -- )
c-function seteuid seteuid n -- n	( __uid -- )
c-function setgid setgid n -- n	( __gid -- )
c-function setregid setregid n n -- n	( __rgid __egid -- )
c-function setegid setegid n -- n	( __gid -- )
c-function fork fork  -- n	( -- )
c-function vfork vfork  -- n	( -- )
c-function ttyname ttyname n -- a	( __fd -- )
c-function ttyname_r ttyname_r n a u -- n	( __fd __buf __buflen -- )
c-function isatty isatty n -- n	( __fd -- )
c-function ttyslot ttyslot  -- n	( -- )
c-function link link s s -- n	( __from __to -- )
c-function symlink symlink s s -- n	( __from __to -- )
c-function readlink readlink s a u -- n	( __path __buf __len -- )
c-function unlink unlink s -- n	( __name -- )
c-function rmdir rmdir s -- n	( __path -- )
c-function tcgetpgrp tcgetpgrp n -- n	( __fd -- )
c-function tcsetpgrp tcsetpgrp n n -- n	( __fd __pgrp_id -- )
c-function getlogin getlogin  -- a	( -- )
c-function setlogin setlogin s -- n	( __name -- )
c-function gethostname gethostname a u -- n	( __name __len -- )
c-function sethostname sethostname s u -- n	( __name __len -- )
c-function sethostid sethostid n -- n	( __id -- )
c-function getdomainname getdomainname a u -- n	( __name __len -- )
c-function setdomainname setdomainname s u -- n	( __name __len -- )
c-function vhangup vhangup  -- n	( -- )
c-function revoke revoke s -- n	( __file -- )
c-function profil profil a u u u -- n	( __sample_buffer __size __offset __scale -- )
c-function acct acct s -- n	( __name -- )
c-function getusershell getusershell  -- a	( -- )
c-function endusershell endusershell  -- void	( -- )
c-function setusershell setusershell  -- void	( -- )
c-function daemon daemon n n -- n	( __nochdir __noclose -- )
c-function chroot chroot s -- n	( __path -- )
c-function getpass getpass s -- a	( __prompt -- )
c-function fsync fsync n -- n	( __fd -- )
c-function gethostid gethostid  -- n	( -- )
c-function sync sync  -- void	( -- )
c-function getpagesize getpagesize  -- n	( -- )
c-function getdtablesize getdtablesize  -- n	( -- )
c-function truncate truncate s n -- n	( __file __length -- )
c-function ftruncate ftruncate n n -- n	( __fd __length -- )
c-function brk brk a -- n	( __addr -- )
c-function sbrk sbrk n -- a	( __delta -- )
c-function syscall syscall n ... -- n	( __sysno <noname> -- )
c-function lockf lockf n n n -- n	( __fd __cmd __len -- )
c-function fdatasync fdatasync n -- n	( __fildes -- )
c-function crypt crypt s s -- a	( __key __salt -- )
c-function getentropy getentropy a u -- n	( __buffer __length -- )

\ ----===< postfix >===-----
end-c-library
