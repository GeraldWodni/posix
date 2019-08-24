%module langinfo

%insert("include")
%{
#include <langinfo.h>
%}

%include "fixgcc.ih"

%include <langinfo.h>
