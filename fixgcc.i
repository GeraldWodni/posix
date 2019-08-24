
/* add types */
%typemap(forth) size_t "u"
%typemap(forth) __ssize_t "n"

/* The following declarations fix gcc-isms which cannot be parsed by SWIG otherwise */

#define __BEGIN_DECLS
#define __END_DECLS
#define __THROW
#define __THROWNL
#define __attribute__(X)
#define __attribute_malloc__
#define __attribute_pure__
#define __attribute_warn_unused_result__
#define __nonnull(X)
#define __noreturn__
#define __restrict
#define __wur
