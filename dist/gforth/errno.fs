\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library errno
s" errno" add-lib
\c #include <errno.h>

\ ----===< int constants >===-----
#1	constant _ERRNO_H
#1	constant EPERM
#2	constant ENOENT
#3	constant ESRCH
#4	constant EINTR
#5	constant EIO
#6	constant ENXIO
#7	constant E2BIG
#8	constant ENOEXEC
#9	constant EBADF
#10	constant ECHILD
#11	constant EAGAIN
#12	constant ENOMEM
#13	constant EACCES
#14	constant EFAULT
#15	constant ENOTBLK
#16	constant EBUSY
#17	constant EEXIST
#18	constant EXDEV
#19	constant ENODEV
#20	constant ENOTDIR
#21	constant EISDIR
#22	constant EINVAL
#23	constant ENFILE
#24	constant EMFILE
#25	constant ENOTTY
#26	constant ETXTBSY
#27	constant EFBIG
#28	constant ENOSPC
#29	constant ESPIPE
#30	constant EROFS
#31	constant EMLINK
#32	constant EPIPE
#33	constant EDOM
#34	constant ERANGE
#35	constant EDEADLK
#36	constant ENAMETOOLONG
#37	constant ENOLCK
#38	constant ENOSYS
#39	constant ENOTEMPTY
#40	constant ELOOP
#11	constant EWOULDBLOCK
#42	constant ENOMSG
#43	constant EIDRM
#44	constant ECHRNG
#45	constant EL2NSYNC
#46	constant EL3HLT
#47	constant EL3RST
#48	constant ELNRNG
#49	constant EUNATCH
#50	constant ENOCSI
#51	constant EL2HLT
#52	constant EBADE
#53	constant EBADR
#54	constant EXFULL
#55	constant ENOANO
#56	constant EBADRQC
#57	constant EBADSLT
#35	constant EDEADLOCK
#59	constant EBFONT
#60	constant ENOSTR
#61	constant ENODATA
#62	constant ETIME
#63	constant ENOSR
#64	constant ENONET
#65	constant ENOPKG
#66	constant EREMOTE
#67	constant ENOLINK
#68	constant EADV
#69	constant ESRMNT
#70	constant ECOMM
#71	constant EPROTO
#72	constant EMULTIHOP
#73	constant EDOTDOT
#74	constant EBADMSG
#75	constant EOVERFLOW
#76	constant ENOTUNIQ
#77	constant EBADFD
#78	constant EREMCHG
#79	constant ELIBACC
#80	constant ELIBBAD
#81	constant ELIBSCN
#82	constant ELIBMAX
#83	constant ELIBEXEC
#84	constant EILSEQ
#85	constant ERESTART
#86	constant ESTRPIPE
#87	constant EUSERS
#88	constant ENOTSOCK
#89	constant EDESTADDRREQ
#90	constant EMSGSIZE
#91	constant EPROTOTYPE
#92	constant ENOPROTOOPT
#93	constant EPROTONOSUPPORT
#94	constant ESOCKTNOSUPPORT
#95	constant EOPNOTSUPP
#96	constant EPFNOSUPPORT
#97	constant EAFNOSUPPORT
#98	constant EADDRINUSE
#99	constant EADDRNOTAVAIL
#100	constant ENETDOWN
#101	constant ENETUNREACH
#102	constant ENETRESET
#103	constant ECONNABORTED
#104	constant ECONNRESET
#105	constant ENOBUFS
#106	constant EISCONN
#107	constant ENOTCONN
#108	constant ESHUTDOWN
#109	constant ETOOMANYREFS
#110	constant ETIMEDOUT
#111	constant ECONNREFUSED
#112	constant EHOSTDOWN
#113	constant EHOSTUNREACH
#114	constant EALREADY
#115	constant EINPROGRESS
#116	constant ESTALE
#117	constant EUCLEAN
#118	constant ENOTNAM
#119	constant ENAVAIL
#120	constant EISNAM
#121	constant EREMOTEIO
#122	constant EDQUOT
#123	constant ENOMEDIUM
#124	constant EMEDIUMTYPE
#125	constant ECANCELED
#126	constant ENOKEY
#127	constant EKEYEXPIRED
#128	constant EKEYREVOKED
#129	constant EKEYREJECTED
#130	constant EOWNERDEAD
#131	constant ENOTRECOVERABLE
#132	constant ERFKILL
#133	constant EHWPOISON
#1	constant _BITS_ERRNO_H
#95	constant ENOTSUP

\ ----===< postfix >===-----
end-c-library
