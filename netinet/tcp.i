%module netinet_tcp

%insert("include")
%{
#include <netinet/tcp.h>
%}

%include "fixgcc.ih"

%include <netinet/tcp.h>
