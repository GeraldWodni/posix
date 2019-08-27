%module sys_socket

/* ignores */
%rename("$ignore", regexmatch$name="^_") "";
%rename("socket_type") "__socket_type";

%insert("include")
%{
#include <sys/socket.h>
%}

%include "fixgcc.ih"

%include <sys/socket.h>

/* GNU seperates the constants and structures into these files */
%include <bits/socket.h>
%include <bits/socket_type.h>
%include <asm-generic/socket.h>
