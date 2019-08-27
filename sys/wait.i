%module sys_wait

%insert("include")
%{
#include <sys/wait.h>
%}

%include "fixgcc.ih"

#define __USE_XOPEN_EXTENDED
%include <sys/wait.h>

/* GNU seperates the constants into this file */
%include <bits/waitflags.h>

%include <bits/waitstatus.h>
