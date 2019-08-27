%module netinet_in

%insert("include")
%{
#include <netinet/in.h>
%}

%include "fixgcc.ih"

%include <netinet/in.h>
