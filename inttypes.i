%module inttypes

%insert("include")
%{
#include <inttypes.h>
%}

%include "fixgcc.ih"

%include <inttypes.h>
