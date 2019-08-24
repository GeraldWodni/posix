%module stdlib

%typemap(forth) size_t "u"
%insert("include")
%{
#include <stdlib.h>
%}

%include "fixgcc.ih"

%include <stdlib.h>
