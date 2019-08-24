%module grp

%insert("include")
%{
#include <grp.h>
%}

%include "fixgcc.ih"

%include <grp.h>
