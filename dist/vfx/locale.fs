\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
( none )

\ ----===< int constants >===-----
#1	constant _LOCALE_H
#0	constant LC_CTYPE
#1	constant LC_NUMERIC
#2	constant LC_TIME
#3	constant LC_COLLATE
#4	constant LC_MONETARY
#5	constant LC_MESSAGES
#6	constant LC_ALL
#7	constant LC_PAPER
#8	constant LC_NAME
#9	constant LC_ADDRESS
#10	constant LC_TELEPHONE
#11	constant LC_MEASUREMENT
#12	constant LC_IDENTIFICATION

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
EXTERN: "C" void * setlocale( int __category, char * __locale );	( __category __locale -- )
EXTERN: "C" void * localeconv(  );	( -- )
EXTERN: "C" long newlocale( int __category_mask, char * __locale, long __base );	( __category_mask __locale __base -- )
EXTERN: "C" long duplocale( long __dataset );	( __dataset -- )
EXTERN: "C" void freelocale( long __dataset );	( __dataset -- )
EXTERN: "C" long uselocale( long __dataset );	( __dataset -- )

\ ----===< postfix >===-----
( none )
