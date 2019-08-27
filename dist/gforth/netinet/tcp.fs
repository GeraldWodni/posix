\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library netinet_tcp
s" netinet_tcp" add-lib
\c #include <netinet/tcp.h>

\ ----===< int constants >===-----
#1	constant _NETINET_TCP_H
#1	constant TCP_NODELAY
#2	constant TCP_MAXSEG
#3	constant TCP_CORK
#4	constant TCP_KEEPIDLE
#5	constant TCP_KEEPINTVL
#6	constant TCP_KEEPCNT
#7	constant TCP_SYNCNT
#8	constant TCP_LINGER2
#9	constant TCP_DEFER_ACCEPT
#10	constant TCP_WINDOW_CLAMP
#11	constant TCP_INFO
#12	constant TCP_QUICKACK
#13	constant TCP_CONGESTION
#14	constant TCP_MD5SIG
#15	constant TCP_COOKIE_TRANSACTIONS
#16	constant TCP_THIN_LINEAR_TIMEOUTS
#17	constant TCP_THIN_DUPACK
#18	constant TCP_USER_TIMEOUT
#19	constant TCP_REPAIR
#20	constant TCP_REPAIR_QUEUE
#21	constant TCP_QUEUE_SEQ
#22	constant TCP_REPAIR_OPTIONS
#23	constant TCP_FASTOPEN
#24	constant TCP_TIMESTAMP
#25	constant TCP_NOTSENT_LOWAT
#26	constant TCP_CC_INFO
#27	constant TCP_SAVE_SYN
#28	constant TCP_SAVED_SYN
#29	constant TCP_REPAIR_WINDOW
#30	constant TCP_FASTOPEN_CONNECT
#31	constant TCP_ULP
#32	constant TCP_MD5SIG_EXT
#33	constant TCP_FASTOPEN_KEY
#34	constant TCP_FASTOPEN_NO_COOKIE
#35	constant TCP_ZEROCOPY_RECEIVE
#36	constant TCP_INQ
#36	constant TCP_CM_INQ
#1	constant TCP_REPAIR_ON
#0	constant TCP_REPAIR_OFF
#-1	constant TCP_REPAIR_OFF_NO_WP

\ ----===< postfix >===-----
end-c-library
