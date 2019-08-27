%module sys_time

%insert("include")
%{
#include <sys/time.h>
%}

%include "fixgcc.ih"

%include <sys/time.h>

/* GNU seperates the modebits into this file */
%include <bits/time.h>
