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
#1	constant _NETINET_IN_H
#4278190080	constant IN_CLASSA_NET
#24	constant IN_CLASSA_NSHIFT
#16777215	constant IN_CLASSA_HOST
#128	constant IN_CLASSA_MAX
#4294901760	constant IN_CLASSB_NET
#16	constant IN_CLASSB_NSHIFT
#65535	constant IN_CLASSB_HOST
#65536	constant IN_CLASSB_MAX
#4294967040	constant IN_CLASSC_NET
#8	constant IN_CLASSC_NSHIFT
#255	constant IN_CLASSC_HOST
#127	constant IN_LOOPBACKNET
#16	constant INET_ADDRSTRLEN
#46	constant INET6_ADDRSTRLEN

\ --------===< enums >===---------
#0	constant IPPROTO_IP
#1	constant IPPROTO_ICMP
#2	constant IPPROTO_IGMP
#4	constant IPPROTO_IPIP
#6	constant IPPROTO_TCP
#8	constant IPPROTO_EGP
#12	constant IPPROTO_PUP
#17	constant IPPROTO_UDP
#22	constant IPPROTO_IDP
#29	constant IPPROTO_TP
#33	constant IPPROTO_DCCP
#41	constant IPPROTO_IPV6
#46	constant IPPROTO_RSVP
#47	constant IPPROTO_GRE
#50	constant IPPROTO_ESP
#51	constant IPPROTO_AH
#92	constant IPPROTO_MTP
#94	constant IPPROTO_BEETPH
#98	constant IPPROTO_ENCAP
#103	constant IPPROTO_PIM
#108	constant IPPROTO_COMP
#115	constant IPPROTO_L2TP
#132	constant IPPROTO_SCTP
#136	constant IPPROTO_UDPLITE
#137	constant IPPROTO_MPLS
#143	constant IPPROTO_ETHERNET
#255	constant IPPROTO_RAW
#262	constant IPPROTO_MPTCP
#263	constant IPPROTO_MAX
#0	constant IPPROTO_HOPOPTS
#43	constant IPPROTO_ROUTING
#44	constant IPPROTO_FRAGMENT
#58	constant IPPROTO_ICMPV6
#59	constant IPPROTO_NONE
#60	constant IPPROTO_DSTOPTS
#135	constant IPPROTO_MH
#7	constant IPPORT_ECHO
#9	constant IPPORT_DISCARD
#11	constant IPPORT_SYSTAT
#13	constant IPPORT_DAYTIME
#15	constant IPPORT_NETSTAT
#21	constant IPPORT_FTP
#23	constant IPPORT_TELNET
#25	constant IPPORT_SMTP
#37	constant IPPORT_TIMESERVER
#42	constant IPPORT_NAMESERVER
#43	constant IPPORT_WHOIS
#57	constant IPPORT_MTP
#69	constant IPPORT_TFTP
#77	constant IPPORT_RJE
#79	constant IPPORT_FINGER
#87	constant IPPORT_TTYLINK
#95	constant IPPORT_SUPDUP
#512	constant IPPORT_EXECSERVER
#513	constant IPPORT_LOGINSERVER
#514	constant IPPORT_CMDSERVER
#520	constant IPPORT_EFSSERVER
#512	constant IPPORT_BIFFUDP
#513	constant IPPORT_WHOSERVER
#520	constant IPPORT_ROUTESERVER
#1024	constant IPPORT_RESERVED
#5000	constant IPPORT_USERRESERVED

\ -------===< structs >===--------
\ struct in_addr
begin-structure in_addr
	drop 0 4 +field in_addr-s_addr
drop 4 end-structure
\ struct in6_addr
begin-structure in6_addr
	drop 0 16 +field in6_addr-__in6_u
drop 16 end-structure
\ in6_addr___in6_u
begin-structure in6_addr___in6_u
	drop 0 16 +field in6_addr___in6_u-__u6_addr16
	drop 0 16 +field in6_addr___in6_u-__u6_addr8
	drop 0 16 +field in6_addr___in6_u-__u6_addr32
drop 16 end-structure
\ struct sockaddr_in
begin-structure __SOCKADDR_COMMON
drop 16 end-structure
\ struct sockaddr_in6
begin-structure __SOCKADDR_COMMON
drop 28 end-structure
\ struct ipv6_mreq
begin-structure ipv6_mreq
	drop 16 4 +field ipv6_mreq-ipv6mr_interface
	drop 0 16 +field ipv6_mreq-ipv6mr_multiaddr
drop 20 end-structure

\ ------===< functions >===-------
EXTERN: "C" long ntohl( long __netlong );	( __netlong -- )
EXTERN: "C" long ntohs( long __netshort );	( __netshort -- )
EXTERN: "C" long htonl( long __hostlong );	( __hostlong -- )
EXTERN: "C" long htons( long __hostshort );	( __hostshort -- )

\ ----===< postfix >===-----
( none )
