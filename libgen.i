%module libgen

%insert("include")
%{
#include <libgen.h>
%}

%include "fixgcc.ih"

%include <libgen.h>
