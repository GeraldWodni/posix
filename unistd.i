%module unistd

/* add legacy functions */
#define __USE_MISC

%insert("include")
%{
#include <unistd.h>
%}

%include "fixgcc.ih"

%include <unistd.h>
