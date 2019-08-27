\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library termios
s" termios" add-lib
\c #include <termios.h>

\ ----===< int constants >===-----
#1	constant _TERMIOS_H
#32	constant NCCS
#1	constant _HAVE_STRUCT_TERMIOS_C_ISPEED
#1	constant _HAVE_STRUCT_TERMIOS_C_OSPEED
#0	constant B0
#1	constant B50
#2	constant B75
#3	constant B110
#4	constant B134
#5	constant B150
#6	constant B200
#7	constant B300
#8	constant B600
#9	constant B1200
#10	constant B1800
#11	constant B2400
#12	constant B4800
#13	constant B9600
#14	constant B19200
#15	constant B38400
#14	constant EXTA
#15	constant EXTB
#1	constant TIOCSER_TEMT
#0	constant TCOOFF
#1	constant TCOON
#2	constant TCIOFF
#3	constant TCION
#0	constant TCIFLUSH
#1	constant TCOFLUSH
#2	constant TCIOFLUSH
#0	constant VINTR
#1	constant VQUIT
#2	constant VERASE
#3	constant VKILL
#4	constant VEOF
#5	constant VTIME
#6	constant VMIN
#7	constant VSWTC
#8	constant VSTART
#9	constant VSTOP
#10	constant VSUSP
#11	constant VEOL
#12	constant VREPRINT
#13	constant VDISCARD
#14	constant VWERASE
#15	constant VLNEXT
#16	constant VEOL2
#1	constant IGNBRK
#2	constant BRKINT
#4	constant IGNPAR
#8	constant PARMRK
#16	constant INPCK
#32	constant ISTRIP
#64	constant INLCR
#128	constant IGNCR
#256	constant ICRNL
#512	constant IUCLC
#1024	constant IXON
#2048	constant IXANY
#4096	constant IXOFF
#8192	constant IMAXBEL
#16384	constant IUTF8
#1	constant OPOST
#2	constant OLCUC
#4	constant ONLCR
#8	constant OCRNL
#16	constant ONOCR
#32	constant ONLRET
#64	constant OFILL
#128	constant OFDEL
#256	constant NLDLY
#0	constant NL0
#256	constant NL1
#1536	constant CRDLY
#0	constant CR0
#512	constant CR1
#1024	constant CR2
#1536	constant CR3
#6144	constant TABDLY
#0	constant TAB0
#2048	constant TAB1
#4096	constant TAB2
#6144	constant TAB3
#8192	constant BSDLY
#0	constant BS0
#8192	constant BS1
#32768	constant FFDLY
#0	constant FF0
#32768	constant FF1
#16384	constant VTDLY
#0	constant VT0
#16384	constant VT1
#6144	constant XTABS
#48	constant CSIZE
#0	constant CS5
#16	constant CS6
#32	constant CS7
#48	constant CS8
#64	constant CSTOPB
#128	constant CREAD
#256	constant PARENB
#512	constant PARODD
#1024	constant HUPCL
#2048	constant CLOCAL
#1	constant ISIG
#2	constant ICANON
#4	constant XCASE
#8	constant ECHO
#16	constant ECHOE
#32	constant ECHOK
#64	constant ECHONL
#128	constant NOFLSH
#256	constant TOSTOP
#512	constant ECHOCTL
#1024	constant ECHOPRT
#2048	constant ECHOKE
#4096	constant FLUSHO
#16384	constant PENDIN
#32768	constant IEXTEN
#65536	constant EXTPROC
#0	constant TCSANOW
#1	constant TCSADRAIN
#2	constant TCSAFLUSH

\ -------===< structs >===--------
\ termios
begin-structure termios
	drop 12 4 +field termios-c_lflag
	drop 16 1 +field termios-c_line
	drop 17 32 +field termios-c_cc
	drop 52 4 +field termios-c_ispeed
	drop 0 4 +field termios-c_iflag
	drop 4 4 +field termios-c_oflag
	drop 8 4 +field termios-c_cflag
	drop 56 4 +field termios-c_ospeed
drop 60 end-structure

\ ------===< functions >===-------
c-function cfgetospeed cfgetospeed a -- u	( __termios_p -- )
c-function cfgetispeed cfgetispeed a -- u	( __termios_p -- )
c-function cfsetospeed cfsetospeed a u -- n	( __termios_p __speed -- )
c-function cfsetispeed cfsetispeed a u -- n	( __termios_p __speed -- )
c-function tcgetattr tcgetattr n a -- n	( __fd __termios_p -- )
c-function tcsetattr tcsetattr n n a -- n	( __fd __optional_actions __termios_p -- )
c-function tcsendbreak tcsendbreak n n -- n	( __fd __duration -- )
c-function tcdrain tcdrain n -- n	( __fd -- )
c-function tcflush tcflush n n -- n	( __fd __queue_selector -- )
c-function tcflow tcflow n n -- n	( __fd __action -- )
c-function tcgetsid tcgetsid n -- n	( __fd -- )

\ ----===< postfix >===-----
end-c-library
