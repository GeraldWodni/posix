%module stdio

%insert("include")
%{
#include <aio.h>
%}

%include "../fixgcc.i"

%include <aio.h>
