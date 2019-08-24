%module stdio

%insert("include")
%{
#include <stdio.h>
%}

%include "fixgcc.ih"

%include <stdio.h>
