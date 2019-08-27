%module sys_statvfs

%insert("include")
%{
#include <sys/statvfs.h>
%}

%include "fixgcc.ih"

%include <sys/statvfs.h>

/* GNU seperates the flags into this file */
%include <bits/statvfs.h>
