%module setjmp

%insert("include")
%{
#include <setjmp.h>
%}

%include "fixgcc.ih"

%include <setjmp.h>
