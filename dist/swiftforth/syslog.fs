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
#1	constant _SYS_SYSLOG_H
#0	constant LOG_EMERG
#1	constant LOG_ALERT
#2	constant LOG_CRIT
#3	constant LOG_ERR
#4	constant LOG_WARNING
#5	constant LOG_NOTICE
#6	constant LOG_INFO
#7	constant LOG_DEBUG
#7	constant LOG_PRIMASK
#0	constant LOG_KERN
#8	constant LOG_USER
#16	constant LOG_MAIL
#24	constant LOG_DAEMON
#32	constant LOG_AUTH
#40	constant LOG_SYSLOG
#48	constant LOG_LPR
#56	constant LOG_NEWS
#64	constant LOG_UUCP
#72	constant LOG_CRON
#80	constant LOG_AUTHPRIV
#88	constant LOG_FTP
#128	constant LOG_LOCAL0
#136	constant LOG_LOCAL1
#144	constant LOG_LOCAL2
#152	constant LOG_LOCAL3
#160	constant LOG_LOCAL4
#168	constant LOG_LOCAL5
#176	constant LOG_LOCAL6
#184	constant LOG_LOCAL7
#24	constant LOG_NFACILITIES
#1016	constant LOG_FACMASK
#1	constant LOG_PID
#2	constant LOG_CONS
#4	constant LOG_ODELAY
#8	constant LOG_NDELAY
#16	constant LOG_NOWAIT
#32	constant LOG_PERROR

\ ------===< functions >===-------
FUNCTION: closelog (  -- void )	( -- )
FUNCTION: openlog ( __ident __option __facility -- void )	( __ident __option __facility -- )
FUNCTION: setlogmask ( __mask -- n )	( __mask -- )
FUNCTION: syslog ( __pri __fmt  -- void )	( __pri __fmt <noname> -- )

\ ----===< postfix >===-----
( none )
