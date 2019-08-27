%module dlfcn

%insert("include")
%{
#include <dlfcn.h>
%}

%include "fixgcc.ih"

%include <dlfcn.h>

/* GNU seperates the structures and constants into extra files */
%include <bits/dlfcn.h>
