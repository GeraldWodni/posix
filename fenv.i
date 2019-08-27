%module fenv

%insert("include")
%{
#include <fenv.h>
%}

%include "fixgcc.ih"

%include <fenv.h>

/* use helper file to parse enums mixed with definitions */
%include <helpers/fenv.h>
