%module fcntl

%insert("include")
%{
#include <fcntl.h>
%}

%include "fixgcc.ih"

%include <fcntl.h>
