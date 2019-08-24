%module stdio

%insert("include")
%{
#include <stdio.h>
%}

%include "../fixgcc.i"

%include <stdio.h>
