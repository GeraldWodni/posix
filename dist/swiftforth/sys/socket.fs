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
#0	constant PF_UNSPEC
#1	constant PF_LOCAL
#1	constant PF_UNIX
#1	constant PF_FILE
#2	constant PF_INET
#3	constant PF_AX25
#4	constant PF_IPX
#5	constant PF_APPLETALK
#6	constant PF_NETROM
#7	constant PF_BRIDGE
#8	constant PF_ATMPVC
#9	constant PF_X25
#10	constant PF_INET6
#11	constant PF_ROSE
#12	constant PF_DECnet
#13	constant PF_NETBEUI
#14	constant PF_SECURITY
#15	constant PF_KEY
#16	constant PF_NETLINK
#16	constant PF_ROUTE
#17	constant PF_PACKET
#18	constant PF_ASH
#19	constant PF_ECONET
#20	constant PF_ATMSVC
#21	constant PF_RDS
#22	constant PF_SNA
#23	constant PF_IRDA
#24	constant PF_PPPOX
#25	constant PF_WANPIPE
#26	constant PF_LLC
#27	constant PF_IB
#28	constant PF_MPLS
#29	constant PF_CAN
#30	constant PF_TIPC
#31	constant PF_BLUETOOTH
#32	constant PF_IUCV
#33	constant PF_RXRPC
#34	constant PF_ISDN
#35	constant PF_PHONET
#36	constant PF_IEEE802154
#37	constant PF_CAIF
#38	constant PF_ALG
#39	constant PF_NFC
#40	constant PF_VSOCK
#41	constant PF_KCM
#42	constant PF_QIPCRTR
#43	constant PF_SMC
#44	constant PF_XDP
#45	constant PF_MAX
#0	constant AF_UNSPEC
#1	constant AF_LOCAL
#1	constant AF_UNIX
#1	constant AF_FILE
#2	constant AF_INET
#3	constant AF_AX25
#4	constant AF_IPX
#5	constant AF_APPLETALK
#6	constant AF_NETROM
#7	constant AF_BRIDGE
#8	constant AF_ATMPVC
#9	constant AF_X25
#10	constant AF_INET6
#11	constant AF_ROSE
#12	constant AF_DECnet
#13	constant AF_NETBEUI
#14	constant AF_SECURITY
#15	constant AF_KEY
#16	constant AF_NETLINK
#16	constant AF_ROUTE
#17	constant AF_PACKET
#18	constant AF_ASH
#19	constant AF_ECONET
#20	constant AF_ATMSVC
#21	constant AF_RDS
#22	constant AF_SNA
#23	constant AF_IRDA
#24	constant AF_PPPOX
#25	constant AF_WANPIPE
#26	constant AF_LLC
#27	constant AF_IB
#28	constant AF_MPLS
#29	constant AF_CAN
#30	constant AF_TIPC
#31	constant AF_BLUETOOTH
#32	constant AF_IUCV
#33	constant AF_RXRPC
#34	constant AF_ISDN
#35	constant AF_PHONET
#36	constant AF_IEEE802154
#37	constant AF_CAIF
#38	constant AF_ALG
#39	constant AF_NFC
#40	constant AF_VSOCK
#41	constant AF_KCM
#42	constant AF_QIPCRTR
#43	constant AF_SMC
#44	constant AF_XDP
#45	constant AF_MAX
#255	constant SOL_RAW
#261	constant SOL_DECNET
#262	constant SOL_X25
#263	constant SOL_PACKET
#264	constant SOL_ATM
#265	constant SOL_AAL
#266	constant SOL_IRDA
#267	constant SOL_NETBEUI
#268	constant SOL_LLC
#269	constant SOL_DCCP
#270	constant SOL_NETLINK
#271	constant SOL_TIPC
#272	constant SOL_RXRPC
#273	constant SOL_PPPOL2TP
#274	constant SOL_BLUETOOTH
#275	constant SOL_PNPIPE
#276	constant SOL_RDS
#277	constant SOL_IUCV
#278	constant SOL_CAIF
#279	constant SOL_ALG
#280	constant SOL_NFC
#281	constant SOL_KCM
#282	constant SOL_TLS
#283	constant SOL_XDP
#4096	constant SOMAXCONN
#1	constant SO_DEBUG
#1	constant SOL_SOCKET
#2	constant SO_REUSEADDR
#3	constant SO_TYPE
#4	constant SO_ERROR
#5	constant SO_DONTROUTE
#6	constant SO_BROADCAST
#7	constant SO_SNDBUF
#8	constant SO_RCVBUF
#32	constant SO_SNDBUFFORCE
#33	constant SO_RCVBUFFORCE
#9	constant SO_KEEPALIVE
#10	constant SO_OOBINLINE
#11	constant SO_NO_CHECK
#12	constant SO_PRIORITY
#13	constant SO_LINGER
#14	constant SO_BSDCOMPAT
#15	constant SO_REUSEPORT
#16	constant SO_PASSCRED
#17	constant SO_PEERCRED
#18	constant SO_RCVLOWAT
#19	constant SO_SNDLOWAT
#20	constant SO_RCVTIMEO_OLD
#21	constant SO_SNDTIMEO_OLD
#22	constant SO_SECURITY_AUTHENTICATION
#23	constant SO_SECURITY_ENCRYPTION_TRANSPORT
#24	constant SO_SECURITY_ENCRYPTION_NETWORK
#25	constant SO_BINDTODEVICE
#26	constant SO_ATTACH_FILTER
#27	constant SO_DETACH_FILTER
#26	constant SO_GET_FILTER
#28	constant SO_PEERNAME
#30	constant SO_ACCEPTCONN
#31	constant SO_PEERSEC
#34	constant SO_PASSSEC
#36	constant SO_MARK
#38	constant SO_PROTOCOL
#39	constant SO_DOMAIN
#40	constant SO_RXQ_OVFL
#41	constant SO_WIFI_STATUS
#41	constant SCM_WIFI_STATUS
#42	constant SO_PEEK_OFF
#43	constant SO_NOFCS
#44	constant SO_LOCK_FILTER
#45	constant SO_SELECT_ERR_QUEUE
#46	constant SO_BUSY_POLL
#47	constant SO_MAX_PACING_RATE
#48	constant SO_BPF_EXTENSIONS
#49	constant SO_INCOMING_CPU
#50	constant SO_ATTACH_BPF
#27	constant SO_DETACH_BPF
#51	constant SO_ATTACH_REUSEPORT_CBPF
#52	constant SO_ATTACH_REUSEPORT_EBPF
#53	constant SO_CNX_ADVICE
#54	constant SCM_TIMESTAMPING_OPT_STATS
#55	constant SO_MEMINFO
#56	constant SO_INCOMING_NAPI_ID
#57	constant SO_COOKIE
#58	constant SCM_TIMESTAMPING_PKTINFO
#59	constant SO_PEERGROUPS
#60	constant SO_ZEROCOPY
#61	constant SO_TXTIME
#61	constant SCM_TXTIME
#62	constant SO_BINDTOIFINDEX
#29	constant SO_TIMESTAMP_OLD
#35	constant SO_TIMESTAMPNS_OLD
#37	constant SO_TIMESTAMPING_OLD
#63	constant SO_TIMESTAMP_NEW
#64	constant SO_TIMESTAMPNS_NEW
#65	constant SO_TIMESTAMPING_NEW
#66	constant SO_RCVTIMEO_NEW
#67	constant SO_SNDTIMEO_NEW
#68	constant SO_DETACH_REUSEPORT_BPF

\ --------===< enums >===---------
#0	constant SHUT_RD
#1	constant SHUT_WR
#2	constant SHUT_RDWR
#1	constant MSG_OOB
#2	constant MSG_PEEK
#4	constant MSG_DONTROUTE
#8	constant MSG_CTRUNC
#16	constant MSG_PROXY
#32	constant MSG_TRUNC
#64	constant MSG_DONTWAIT
#128	constant MSG_EOR
#256	constant MSG_WAITALL
#512	constant MSG_FIN
#1024	constant MSG_SYN
#2048	constant MSG_CONFIRM
#4096	constant MSG_RST
#8192	constant MSG_ERRQUEUE
#16384	constant MSG_NOSIGNAL
#32768	constant MSG_MORE
#65536	constant MSG_WAITFORONE
#262144	constant MSG_BATCH
#67108864	constant MSG_ZEROCOPY
#536870912	constant MSG_FASTOPEN
#1073741824	constant MSG_CMSG_CLOEXEC
#1	constant SCM_RIGHTS
#1	constant SOCK_STREAM
#2	constant SOCK_DGRAM
#3	constant SOCK_RAW
#4	constant SOCK_RDM
#5	constant SOCK_SEQPACKET
#6	constant SOCK_DCCP
#10	constant SOCK_PACKET
#524288	constant SOCK_CLOEXEC
#2048	constant SOCK_NONBLOCK

\ -------===< structs >===--------
\ msghdr
begin-structure msghdr
	drop 16 8 +field msghdr-msg_iov
	drop 24 8 +field msghdr-msg_iovlen
	drop 32 8 +field msghdr-msg_control
	drop 0 8 +field msghdr-msg_name
	drop 8 4 +field msghdr-msg_namelen
	drop 40 8 +field msghdr-msg_controllen
	drop 48 4 +field msghdr-msg_flags
drop 56 end-structure
\ cmsghdr
begin-structure cmsghdr
	drop 0 8 +field cmsghdr-cmsg_len
	drop 8 4 +field cmsghdr-cmsg_level
	drop 12 4 +field cmsghdr-cmsg_type
drop 16 end-structure
\ linger
begin-structure linger
	drop 0 4 +field linger-l_onoff
	drop 4 4 +field linger-l_linger
drop 8 end-structure

\ ------===< functions >===-------
FUNCTION: socket ( __domain __type __protocol -- n )	( __domain __type __protocol -- )
FUNCTION: socketpair ( __domain __type __protocol __fds -- n )	( __domain __type __protocol __fds -- )
FUNCTION: bind ( __fd __addr __len -- n )	( __fd __addr __len -- )
FUNCTION: getsockname ( __fd __addr __len -- n )	( __fd __addr __len -- )
FUNCTION: connect ( __fd __addr __len -- n )	( __fd __addr __len -- )
FUNCTION: getpeername ( __fd __addr __len -- n )	( __fd __addr __len -- )
FUNCTION: send ( __fd __buf __n __flags -- n )	( __fd __buf __n __flags -- )
FUNCTION: recv ( __fd __buf __n __flags -- n )	( __fd __buf __n __flags -- )
FUNCTION: sendto ( __fd __buf __n __flags __addr __addr_len -- n )	( __fd __buf __n __flags __addr __addr_len -- )
FUNCTION: recvfrom ( __fd __buf __n __flags __addr __addr_len -- n )	( __fd __buf __n __flags __addr __addr_len -- )
FUNCTION: sendmsg ( __fd __message __flags -- n )	( __fd __message __flags -- )
FUNCTION: recvmsg ( __fd __message __flags -- n )	( __fd __message __flags -- )
FUNCTION: getsockopt ( __fd __level __optname __optval __optlen -- n )	( __fd __level __optname __optval __optlen -- )
FUNCTION: setsockopt ( __fd __level __optname __optval __optlen -- n )	( __fd __level __optname __optval __optlen -- )
FUNCTION: listen ( __fd __n -- n )	( __fd __n -- )
FUNCTION: accept ( __fd __addr __addr_len -- n )	( __fd __addr __addr_len -- )
FUNCTION: shutdown ( __fd __how -- n )	( __fd __how -- )
FUNCTION: sockatmark ( __fd -- n )	( __fd -- )

\ ----===< postfix >===-----
( none )
