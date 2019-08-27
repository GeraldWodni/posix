%module strings

%insert("include")
%{
#include <strings.h>
%}

%include "fixgcc.ih"

%include <strings.h>
