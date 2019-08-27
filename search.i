%module search

%insert("include")
%{
#define __USE_MISC
#include <search.h>
%}

%include "fixgcc.ih"

/* Struct redefined, manual definition required */
typedef struct {
    char *key;
    void *data;
} ENTRY;

#define __USE_MISC
%include <search.h>
