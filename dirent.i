%module dirent

%insert("include")
%{
#include <dirent.h>
%}

%include "fixgcc.ih"

%include <dirent.h>
