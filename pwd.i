%module pwd

%insert("include")
%{
#include <pwd.h>
%}

%include "fixgcc.ih"

%include <pwd.h>
