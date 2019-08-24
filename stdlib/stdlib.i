%module stdlib

%typemap(forth) size_t "u"
%insert("include")
%{
#include <stdlib.h>
%}

%include "../fixgcc.i"

%include <stdlib.h>
