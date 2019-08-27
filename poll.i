%module poll

%insert("include")
%{
#include <poll.h>
%}

%include "fixgcc.ih"

/* poll just includes sys/poll on GNU, may need additional attention or explicit passing of the function */
%include <sys/poll.h>
