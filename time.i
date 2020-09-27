%module time

%insert("include")
%{
#include <time.h>
%}

%include "fixgcc.ih"

/* add full struct definition */
#define __GLIBC_USE(X) 0
#define __USE_MISC
%include <time.h>

/* GNU seperates the structures and constants into extra files */
%include <bits/time.h>
%include <bits/types/struct_tm.h>
