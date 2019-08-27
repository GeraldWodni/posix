%module math

/* HINT: extracts only constants as there are no function definitions */

/* disable ISOC99 as there is an unnamed enum which breaks swig's parser */
#define SWIG_DISABLE_ISOC99
#define __USE_MISC

%insert("include")
%{
#include <math.h>
%}

%include "fixgcc.ih"

%include <math.h>

/* use helper file because of the way enums are defined */
%include <helpers/math.h>
