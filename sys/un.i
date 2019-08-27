%module sys_un

%insert("include")
%{
#include <sys/un.h>
%}

%include "fixgcc.ih"

/* SWIG does not parse the structure of sockaddr_un, so we just rebuild it here using macros */
%include <bits/sockaddr.h>

struct sockaddr_un {
    __SOCKADDR_COMMON (sun_);
    char sun_path[108];
};
