%module locale

%insert("include")
%{
#include <locale.h>
%}

%include "fixgcc.ih"

%include <locale.h>

/* use helper file to get unprefixed constants */
%include <helpers/locale.h>
