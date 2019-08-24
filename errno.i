%module errno

%insert("include")
%{
#include <errno.h>
%}

%include "fixgcc.ih"

%include <errno.h>
