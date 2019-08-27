#include <fenv.h>

enum {
    FE_INVALID = FE_INVALID,
    FE_DIVBYZERO = FE_DIVBYZERO,
    FE_OVERFLOW = FE_OVERFLOW,
    FE_UNDERFLOW = FE_UNDERFLOW,
    FE_INEXACT = FE_INEXACT
};

enum {
    FE_TONEAREST = FE_TONEAREST,
    FE_DOWNWARD = FE_DOWNWARD,
    FE_UPWARD = FE_UPWARD,
    FE_TOWARDZERO = FE_TOWARDZERO
};

/* just pull scope and define, no final value required */
//#undef FE_DFL_ENV
//#define FE_DFL_ENV 42
