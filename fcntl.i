%module fcntl

%insert("include")
%{
#include <fcntl.h>
#define HAVE_ARCH_STRUCT_FLOCK
#include <asm/fcntl.h>
%}

%include "fixgcc.ih"

%include <fcntl.h>

/* GNU seperates the constants into extra files */
#define HAVE_ARCH_STRUCT_FLOCK
%include <asm-generic/fcntl.h>
