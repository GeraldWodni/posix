%module sys_select

/* we also want pselect */
#define __USE_XOPEN2K

%insert("include")
%{
#include <sys/select.h>
%}

%include "fixgcc.ih"

%include <sys/select.h>
