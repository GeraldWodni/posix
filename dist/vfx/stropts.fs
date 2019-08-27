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
#1	constant _STROPTS_H
#1	constant _BITS_STROPTS_H
#21248	constant __SID
#21249	constant I_NREAD
#21250	constant I_PUSH
#21251	constant I_POP
#21252	constant I_LOOK
#21253	constant I_FLUSH
#21254	constant I_SRDOPT
#21255	constant I_GRDOPT
#21256	constant I_STR
#21257	constant I_SETSIG
#21258	constant I_GETSIG
#21259	constant I_FIND
#21260	constant I_LINK
#21261	constant I_UNLINK
#21263	constant I_PEEK
#21264	constant I_FDINSERT
#21265	constant I_SENDFD
#21262	constant I_RECVFD
#21267	constant I_SWROPT
#21268	constant I_GWROPT
#21269	constant I_LIST
#21270	constant I_PLINK
#21271	constant I_PUNLINK
#21276	constant I_FLUSHBAND
#21277	constant I_CKBAND
#21278	constant I_GETBAND
#21279	constant I_ATMARK
#21280	constant I_SETCLTIME
#21281	constant I_GETCLTIME
#21282	constant I_CANPUT
#8	constant FMNAMESZ
#1	constant FLUSHR
#2	constant FLUSHW
#3	constant FLUSHRW
#1	constant S_INPUT
#2	constant S_HIPRI
#4	constant S_OUTPUT
#8	constant S_MSG
#16	constant S_ERROR
#32	constant S_HANGUP
#64	constant S_RDNORM
#4	constant S_WRNORM
#128	constant S_RDBAND
#256	constant S_WRBAND
#512	constant S_BANDURG
#1	constant RS_HIPRI
#0	constant RNORM
#1	constant RMSGD
#2	constant RMSGN
#4	constant RPROTDAT
#8	constant RPROTDIS
#16	constant RPROTNORM
#1	constant SNDZERO
#1	constant ANYMARK
#2	constant LASTMARK
#1	constant MSG_HIPRI
#2	constant MSG_ANY
#4	constant MSG_BAND
#1	constant MORECTL
#2	constant MOREDATA

\ -------===< structs >===--------
\ bandinfo
begin-structure bandinfo
	drop 0 1 +field bandinfo-bi_pri
	drop 4 4 +field bandinfo-bi_flag
drop 8 end-structure
\ strbuf
begin-structure strbuf
	drop 4 4 +field strbuf-len
	drop 8 8 +field strbuf-buf
	drop 0 4 +field strbuf-maxlen
drop 16 end-structure
\ strpeek
begin-structure strpeek
	drop 16 16 +field strpeek-databuf
	drop 0 16 +field strpeek-ctlbuf
	drop 32 4 +field strpeek-flags
drop 40 end-structure
\ strfdinsert
begin-structure strfdinsert
	drop 16 16 +field strfdinsert-databuf
	drop 36 4 +field strfdinsert-fildes
	drop 0 16 +field strfdinsert-ctlbuf
	drop 40 4 +field strfdinsert-offset
	drop 32 4 +field strfdinsert-flags
drop 48 end-structure
\ strioctl
begin-structure strioctl
	drop 8 4 +field strioctl-ic_len
	drop 4 4 +field strioctl-ic_timout
	drop 16 8 +field strioctl-ic_dp
	drop 0 4 +field strioctl-ic_cmd
drop 24 end-structure
\ strrecvfd
begin-structure strrecvfd
	drop 0 4 +field strrecvfd-fd
	drop 4 4 +field strrecvfd-uid
	drop 8 4 +field strrecvfd-gid
	drop 12 8 +field strrecvfd-__fill
drop 20 end-structure
\ str_mlist
begin-structure str_mlist
	drop 0 9 +field str_mlist-l_name
drop 9 end-structure
\ str_list
begin-structure str_list
	drop 8 8 +field str_list-sl_modlist
	drop 0 4 +field str_list-sl_nmods
drop 16 end-structure

\ ------===< functions >===-------
EXTERN: "C" int isastream( int __fildes );	( __fildes -- )
EXTERN: "C" int getmsg( int __fildes, void * __ctlptr, void * __dataptr, void * __flagsp );	( __fildes __ctlptr __dataptr __flagsp -- )
EXTERN: "C" int getpmsg( int __fildes, void * __ctlptr, void * __dataptr, void * __bandp, void * __flagsp );	( __fildes __ctlptr __dataptr __bandp __flagsp -- )
EXTERN: "C" int ioctl( int __fd, long __request, ...  );	( __fd __request <noname> -- )
EXTERN: "C" int putmsg( int __fildes, void * __ctlptr, void * __dataptr, int __flags );	( __fildes __ctlptr __dataptr __flags -- )
EXTERN: "C" int putpmsg( int __fildes, void * __ctlptr, void * __dataptr, int __band, int __flags );	( __fildes __ctlptr __dataptr __band __flags -- )
EXTERN: "C" int fattach( int __fildes, char * __path );	( __fildes __path -- )
EXTERN: "C" int fdetach( char * __path );	( __path -- )

\ ----===< postfix >===-----
( none )
