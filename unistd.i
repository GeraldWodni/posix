%module unistd

#define __USE_MISC
#define __USE_XOPEN
#define __USE_XOPEN2K
#define __USE_XOPEN2K8

%insert("include")
%{
#include <unistd.h>
%}

%include "fixgcc.ih"

%include <unistd.h>
