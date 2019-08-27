%module sched

%insert("include")
%{
#include <sched.h>
%}

%include "fixgcc.ih"

%include <sched.h>
