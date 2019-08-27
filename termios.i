%module termios

%insert("include")
%{
#include <termios.h>
%}

%include "fixgcc.ih"

%include <termios.h>

/* GNU seperates the structures and constants into extra files */

/* struct */
%include <bits/termios-struct.h>

/* constants */
#define __USE_MISC
/* full list at:  */
/* Line Control, Baud Rate Selection http://pubs.opengroup.org/onlinepubs/9699919799/ */
%include <bits/termios.h>
%include <bits/termios-c_cc.h>
/* Input Modes */
%include <bits/termios-c_iflag.h>
/* Output Modes */
%include <bits/termios-c_oflag.h>
/* Control Modes */
%include <bits/termios-c_cflag.h>
/* Local Modes */
%include <bits/termios-c_lflag.h>
/* Attribute Selection */
%include <bits/termios-tcflow.h>
