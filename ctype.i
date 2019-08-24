%module ctype

%insert("include")
%{
#include <ctype.h>
%}

%include "fixgcc.ih"

%include <ctype.h>
