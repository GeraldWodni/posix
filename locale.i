%module locale

%insert("include")
%{
#include <locale.h>
%}

%include "fixgcc.ih"

%include <locale.h>
