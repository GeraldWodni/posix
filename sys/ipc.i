%module sys_ipc

%insert("include")
%{
#include <sys/ipc.h>
%}

%include "fixgcc.ih"

%include <sys/ipc.h>

/* GNU seperates the modebits into this file */
%include <bits/ipc.h>
%include <bits/ipc-perm.h>
