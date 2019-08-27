%module wctype

#define __USE_POSIX
#define __USE_XOPEN2K
#define __USE_XOPEN2K8

%insert("include")
%{
#include <wctype.h>
%}

%include "fixgcc.ih"

%include <wctype.h>
