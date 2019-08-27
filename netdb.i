%module netdb

%insert("include")
%{
#include <netdb.h>
%}

%include "fixgcc.ih"

%include <netdb.h>
