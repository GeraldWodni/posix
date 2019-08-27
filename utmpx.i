%module utmpx

%insert("include")
%{
#include <utmpx.h>
%}

%include "fixgcc.ih"

%include <utmpx.h>

/* GNU seperates the structures and constants into extra files */
%include <bits/utmpx.h>
