%module sys_mman

%insert("include")
%{
#include <sys/mman.h>
%}

%include "fixgcc.ih"

%include <sys/mman.h>

/* GNU seperates the modebits into this file */
%include <bits/mman-linux.h>
