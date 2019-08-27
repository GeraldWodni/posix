%module stropts

%insert("include")
%{
#include <stropts.h>
%}

%include "fixgcc.ih"

%include <stropts.h>

/* GNU seperates the structures into this file */
%include <bits/stropts.h>
