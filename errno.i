%module errno

%insert("include")
%{
#include <errno.h>
%}

%include "fixgcc.ih"

/* only include constants */
#define __ASSEMBLER__
%include <errno.h>

/* GNU seperates the constants into extra files */
%include <asm-generic/errno-base.h>
%include <asm-generic/errno.h>
%include <bits/errno.h>
