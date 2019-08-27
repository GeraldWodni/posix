%module dirent

%insert("include")
%{
#include <dirent.h>
%}

%include "fixgcc.ih"

%include <dirent.h>

/* GNU seperates the structures and constants into extra files */
%include <bits/dirent.h>
