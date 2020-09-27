%module sys_sem

%insert("include")
%{
#include <sys/sem.h>
%}

%include "fixgcc.ih"

%include <sys/sem.h>

/* GNU seperates the modebits into this file */
%include <bits/sem.h>
%include <bits/types/struct_semid_ds.h>
