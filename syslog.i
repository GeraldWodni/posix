%module syslog

%insert("include")
%{
#include <syslog.h>
%}

%include "fixgcc.ih"

/* GNU has moved this header */
%include <sys/syslog.h>
