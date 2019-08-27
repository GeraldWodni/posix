%module wordexp

%insert("include")
%{
#include <wordexp.h>
%}

%include "fixgcc.ih"

%include <wordexp.h>
