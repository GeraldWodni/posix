%module time

%insert("include")
%{
#include <time.h>
%}

%include "fixgcc.ih"

#define __USE_MISC
#define __USE_POSIX
#define __USE_POSIX199309
#define __USE_XOPEN2K
%include <time.h>

/* GNU seperates the structures and constants into extra files */

/* struct */
%include <bits/types/struct_tm.h>
