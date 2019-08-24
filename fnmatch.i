%module fnmatch

%insert("include")
%{
#include <fnmatch.h>
%}

%include "fixgcc.ih"

%include <fnmatch.h>
