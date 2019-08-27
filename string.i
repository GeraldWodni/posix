%module string

%insert("include")
%{
#include <string.h>
%}

%include "fixgcc.ih"

%include <string.h>
