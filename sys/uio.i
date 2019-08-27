%module sys_uio

%insert("include")
%{
#include <sys/uio.h>
%}

%include "fixgcc.ih"

%include <sys/uio.h>

/* GNU seperates the modebits into this file */
%include <bits/types/struct_iovec.h>
