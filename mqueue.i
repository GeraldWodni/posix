%module mqueue

%insert("include")
%{
#include <mqueue.h>
%}

%include "fixgcc.ih"

%include <mqueue.h>
