%module sys_msg

%insert("include")
%{
#include <sys/msg.h>
%}

%include "fixgcc.ih"

%include <sys/msg.h>

/* GNU seperates the modebits into this file */
%include <bits/msq.h>
%include <bits/types/struct_msqid_ds.h>
