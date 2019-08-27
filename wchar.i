%module wchar

%insert("include")
%{
#undef WCHAR_MIN
#undef WCHAR_MAX
#include <wchar.h>
%}


%include "fixgcc.ih"

%include <wchar.h>

/* use helper file because of the way WCHAR_MIN is defined */
%include <helpers/wchar.h>
