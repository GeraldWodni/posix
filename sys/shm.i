%module sys_shm

%insert("include")
%{
#include <sys/shm.h>
%}

%include "fixgcc.ih"

%include <sys/shm.h>

/* GNU seperates the modebits into this file */
%include <bits/shm.h>
