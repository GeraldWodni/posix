%module sys_times

%insert("include")
%{
#include <sys/times.h>
%}

%include "fixgcc.ih"

%include <sys/times.h>

/* GNU seperates the modebits into this file */
//%include <bits/times.h>
