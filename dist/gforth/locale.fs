\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library locale
s" locale" add-lib
\c #include <locale.h>

\ ----===< int constants >===-----
#1	constant _LOCALE_H

\ -------===< structs >===--------
\ lconv
begin-structure lconv
	drop 32 8 +field lconv-currency_symbol
	drop 24 8 +field lconv-int_curr_symbol
	drop 82 1 +field lconv-p_cs_precedes
	drop 40 8 +field lconv-mon_decimal_point
	drop 0 8 +field lconv-decimal_point
	drop 84 1 +field lconv-n_cs_precedes
	drop 86 1 +field lconv-p_sign_posn
	drop 87 1 +field lconv-n_sign_posn
	drop 88 1 +field lconv-int_p_cs_precedes
	drop 90 1 +field lconv-int_n_cs_precedes
	drop 92 1 +field lconv-int_p_sign_posn
	drop 93 1 +field lconv-int_n_sign_posn
	drop 83 1 +field lconv-p_sep_by_space
	drop 48 8 +field lconv-mon_thousands_sep
	drop 8 8 +field lconv-thousands_sep
	drop 85 1 +field lconv-n_sep_by_space
	drop 89 1 +field lconv-int_p_sep_by_space
	drop 91 1 +field lconv-int_n_sep_by_space
	drop 81 1 +field lconv-frac_digits
	drop 80 1 +field lconv-int_frac_digits
	drop 72 8 +field lconv-negative_sign
	drop 64 8 +field lconv-positive_sign
	drop 56 8 +field lconv-mon_grouping
	drop 16 8 +field lconv-grouping
drop 96 end-structure

\ ------===< functions >===-------
c-function setlocale setlocale n s -- a	( __category __locale -- )
c-function localeconv localeconv  -- a	( -- )
c-function newlocale newlocale n s n -- n	( __category_mask __locale __base -- )
c-function duplocale duplocale n -- n	( __dataset -- )
c-function freelocale freelocale n -- void	( __dataset -- )
c-function uselocale uselocale n -- n	( __dataset -- )

\ ----===< postfix >===-----
end-c-library
