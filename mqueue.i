%module mqueue

%insert("include")
%{
#include <mqueue.h>
%}

%include "fixgcc.ih"

%include <mqueue.h>

/* GNU seperates the structs into extra files */
%include <bits/mqueue.h>
