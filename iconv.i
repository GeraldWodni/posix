%module iconv

%insert("include")
%{
#include <iconv.h>
%}

%include "fixgcc.ih"

%include <iconv.h>
