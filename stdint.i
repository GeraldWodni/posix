%module stdint

%insert("include")
%{
#include <stdint.h>
%}

%include "fixgcc.ih"

%include <stdint.h>
