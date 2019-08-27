%module setjmp

%ignore _SETJMP_H;

%rename(setjmp) _setjmp;
%rename(sigsetjmp) __sigsetjmp;

%insert("include")
%{
#include <setjmp.h>
%}

%include "fixgcc.ih"

%include <setjmp.h>
