%module time

%insert("include")
%{
#include <time.h>
%}

%include "fixgcc.ih"

/* add full struct definition */
#define __USE_MISC
%include <time.h>

/* GNU seperates the structures and constants into extra files */

/* struct */
%include <bits/types/struct_tm.h>
