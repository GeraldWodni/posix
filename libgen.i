%module libgen

%insert("include")
%{
#include <libgen.h>
%}

/* __xpg_basename gets renamed by define, so explicit declaration is required */
extern char *dirname  (char *__path);
extern char *basename (char *__path);
