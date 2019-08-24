%module stdio

%insert("include")
%{
#include <aio.h>
%}

%include "fixgcc.ih"

%include <aio.h>
