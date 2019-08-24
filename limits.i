%module limits

%insert("include")
%{
#include <limits.h>
%}

%include "fixgcc.ih"

%include <limits.h>
