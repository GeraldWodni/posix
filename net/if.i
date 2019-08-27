%module net_if

%insert("include")
%{
#include <net/if.h>
%}

%include "fixgcc.ih"

%include <net/if.h>
