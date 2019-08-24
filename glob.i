%module glob

%insert("include")
%{
#include <glob.h>
%}

%include "fixgcc.ih"

%include <glob.h>
