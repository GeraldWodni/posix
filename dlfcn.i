%module dlfcn

%insert("include")
%{
#include <dlfcn.h>
%}

%include "fixgcc.ih"

%include <dlfcn.h>
