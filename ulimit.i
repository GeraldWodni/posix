%module ulimit

%insert("include")
%{
#include <ulimit.h>
%}

%include "fixgcc.ih"

%include <ulimit.h>
