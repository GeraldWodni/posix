%module ftw

%insert("include")
%{
#define __USE_XOPEN_EXTENDED
#include <ftw.h>
%}

%include "fixgcc.ih"

#define __USE_XOPEN_EXTENDED
%include <ftw.h>
