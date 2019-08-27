%module sys_stat


%insert("include")
%{
#include <sys/stat.h>
%}

%include "fixgcc.ih"

%include <sys/stat.h>

/* GNU seperates the modebits into this file */

/* make sure to define 64bit if available */
#undef _MKNOD_VER
#undef _STAT_VER
%include <bits/stat.h>

/* manually pull constants */
#define S_IFMT __S_IFMT
#define S_IFDIR __S_IFDIR
#define S_IFCHR __S_IFCHR
#define S_IFBLK __S_IFBLK
#define S_IFREG __S_IFREG
#define S_IFIFO __S_IFIFO
#define S_IFLNK __S_IFLNK
#define S_IFSOCK __S_IFSOCK
#define S_ISUID __S_ISUID
#define S_ISGID __S_ISGID
#define S_ISVTX __S_ISVTX
#define S_IREAD __S_IREAD
#define S_IWRITE __S_IWRITE
#define S_IEXEC __S_IEXEC
