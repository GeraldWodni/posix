%module pthread

%insert("include")
%{
#include <pthread.h>
%}

%include "fixgcc.ih"

%include <pthread.h>
