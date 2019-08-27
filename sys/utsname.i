%module sys_utsname

%insert("include")
%{
#include <sys/utsname.h>
%}

%include "fixgcc.ih"

%include <sys/utsname.h>
