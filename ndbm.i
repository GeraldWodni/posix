%module ndbm

%insert("include")
%{
#include <ndbm.h>
%}

%include "fixgcc.ih"

%include <ndbm.h>

/* GNU seperates part of the definition into gdbm */
%include <gdbm.h>
