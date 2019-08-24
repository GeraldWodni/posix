%module assert

%insert("include")
%{
#include <assert.h>
%}

%include "fixgcc.ih"

%include <assert.h>
