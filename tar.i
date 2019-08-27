%module tar

%insert("include")
%{
#include <tar.h>
%}

%include "fixgcc.ih"

%include <tar.h>
