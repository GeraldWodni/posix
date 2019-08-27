%module sys_resource

%insert("include")
%{
#include <sys/resource.h>
%}

%include "fixgcc.ih"

%include <sys/resource.h>

/* GNU seperates the modebits into this file */
%include <bits/resource.h>
