%module wctype

%insert("include")
%{
#include <wctype.h>
%}

%include "fixgcc.ih"

%include <wctype.h>
