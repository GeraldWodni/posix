%module sched

%insert("include")
%{
#include <sched.h>
%}

%include "fixgcc.ih"

%include <sched.h>

/* GNU seperates the constants and structs into extra files */
%include <bits/sched.h>
%include <bits/types/struct_sched_param.h>
