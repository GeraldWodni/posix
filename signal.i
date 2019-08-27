%module signal

%insert("include")
%{
#include <signal.h>
#include <asm-generic/signal-defs.h>
#pragma GCC diagnostic ignored "-Wint-conversion"
%}

%include "fixgcc.ih"

%include <signal.h>

/* GNU seperates the contants into this file */
%include <bits/signum-generic.h>
%include <bits/types/stack_t.h>

/* use helper file to parse enums mixed with definitions */
%include <helpers/signal.h>
