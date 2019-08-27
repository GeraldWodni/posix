%module arpa_inet

%insert("include")
%{
#include <arpa/inet.h>
%}

%include "fixgcc.ih"

%include <arpa/inet.h>

/* GNU seperates the structures into this file */
//%include <bits/stropts.h>
