%module fenv

%insert("include")
%{
#include <fenv.h>
%}

%include "fixgcc.ih"

%include <fenv.h>
