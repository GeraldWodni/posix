%module grp

%insert("include")
%{
#define __USE_XOPEN_EXTENDED
#include <grp.h>
%}

%include "fixgcc.ih"

#define __USE_XOPEN_EXTENDED
%include <grp.h>
