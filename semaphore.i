%module semaphore

%insert("include")
%{
#include <semaphore.h>
%}

%include "fixgcc.ih"

%include <semaphore.h>
