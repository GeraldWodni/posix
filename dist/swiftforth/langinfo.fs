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
#1	constant _LANGINFO_H

\ --------===< enums >===---------
#131072	constant ABDAY_1
#131073	constant ABDAY_2
#131074	constant ABDAY_3
#131075	constant ABDAY_4
#131076	constant ABDAY_5
#131077	constant ABDAY_6
#131078	constant ABDAY_7
#131079	constant DAY_1
#131080	constant DAY_2
#131081	constant DAY_3
#131082	constant DAY_4
#131083	constant DAY_5
#131084	constant DAY_6
#131085	constant DAY_7
#131086	constant ABMON_1
#131087	constant ABMON_2
#131088	constant ABMON_3
#131089	constant ABMON_4
#131090	constant ABMON_5
#131091	constant ABMON_6
#131092	constant ABMON_7
#131093	constant ABMON_8
#131094	constant ABMON_9
#131095	constant ABMON_10
#131096	constant ABMON_11
#131097	constant ABMON_12
#131098	constant MON_1
#131099	constant MON_2
#131100	constant MON_3
#131101	constant MON_4
#131102	constant MON_5
#131103	constant MON_6
#131104	constant MON_7
#131105	constant MON_8
#131106	constant MON_9
#131107	constant MON_10
#131108	constant MON_11
#131109	constant MON_12
#131110	constant AM_STR
#131111	constant PM_STR
#131112	constant D_T_FMT
#131113	constant D_FMT
#131114	constant T_FMT
#131115	constant T_FMT_AMPM
#131116	constant ERA
#131117	constant __ERA_YEAR
#131118	constant ERA_D_FMT
#131119	constant ALT_DIGITS
#131120	constant ERA_D_T_FMT
#131121	constant ERA_T_FMT
#131122	constant _NL_TIME_ERA_NUM_ENTRIES
#131123	constant _NL_TIME_ERA_ENTRIES
#131124	constant _NL_WABDAY_1
#131125	constant _NL_WABDAY_2
#131126	constant _NL_WABDAY_3
#131127	constant _NL_WABDAY_4
#131128	constant _NL_WABDAY_5
#131129	constant _NL_WABDAY_6
#131130	constant _NL_WABDAY_7
#131131	constant _NL_WDAY_1
#131132	constant _NL_WDAY_2
#131133	constant _NL_WDAY_3
#131134	constant _NL_WDAY_4
#131135	constant _NL_WDAY_5
#131136	constant _NL_WDAY_6
#131137	constant _NL_WDAY_7
#131138	constant _NL_WABMON_1
#131139	constant _NL_WABMON_2
#131140	constant _NL_WABMON_3
#131141	constant _NL_WABMON_4
#131142	constant _NL_WABMON_5
#131143	constant _NL_WABMON_6
#131144	constant _NL_WABMON_7
#131145	constant _NL_WABMON_8
#131146	constant _NL_WABMON_9
#131147	constant _NL_WABMON_10
#131148	constant _NL_WABMON_11
#131149	constant _NL_WABMON_12
#131150	constant _NL_WMON_1
#131151	constant _NL_WMON_2
#131152	constant _NL_WMON_3
#131153	constant _NL_WMON_4
#131154	constant _NL_WMON_5
#131155	constant _NL_WMON_6
#131156	constant _NL_WMON_7
#131157	constant _NL_WMON_8
#131158	constant _NL_WMON_9
#131159	constant _NL_WMON_10
#131160	constant _NL_WMON_11
#131161	constant _NL_WMON_12
#131162	constant _NL_WAM_STR
#131163	constant _NL_WPM_STR
#131164	constant _NL_WD_T_FMT
#131165	constant _NL_WD_FMT
#131166	constant _NL_WT_FMT
#131167	constant _NL_WT_FMT_AMPM
#131168	constant _NL_WERA_YEAR
#131169	constant _NL_WERA_D_FMT
#131170	constant _NL_WALT_DIGITS
#131171	constant _NL_WERA_D_T_FMT
#131172	constant _NL_WERA_T_FMT
#131173	constant _NL_TIME_WEEK_NDAYS
#131174	constant _NL_TIME_WEEK_1STDAY
#131175	constant _NL_TIME_WEEK_1STWEEK
#131176	constant _NL_TIME_FIRST_WEEKDAY
#131177	constant _NL_TIME_FIRST_WORKDAY
#131178	constant _NL_TIME_CAL_DIRECTION
#131179	constant _NL_TIME_TIMEZONE
#131180	constant _DATE_FMT
#131181	constant _NL_W_DATE_FMT
#131182	constant _NL_TIME_CODESET
#131183	constant __ALTMON_1
#131184	constant __ALTMON_2
#131185	constant __ALTMON_3
#131186	constant __ALTMON_4
#131187	constant __ALTMON_5
#131188	constant __ALTMON_6
#131189	constant __ALTMON_7
#131190	constant __ALTMON_8
#131191	constant __ALTMON_9
#131192	constant __ALTMON_10
#131193	constant __ALTMON_11
#131194	constant __ALTMON_12
#131195	constant _NL_WALTMON_1
#131196	constant _NL_WALTMON_2
#131197	constant _NL_WALTMON_3
#131198	constant _NL_WALTMON_4
#131199	constant _NL_WALTMON_5
#131200	constant _NL_WALTMON_6
#131201	constant _NL_WALTMON_7
#131202	constant _NL_WALTMON_8
#131203	constant _NL_WALTMON_9
#131204	constant _NL_WALTMON_10
#131205	constant _NL_WALTMON_11
#131206	constant _NL_WALTMON_12
#131207	constant _NL_ABALTMON_1
#131208	constant _NL_ABALTMON_2
#131209	constant _NL_ABALTMON_3
#131210	constant _NL_ABALTMON_4
#131211	constant _NL_ABALTMON_5
#131212	constant _NL_ABALTMON_6
#131213	constant _NL_ABALTMON_7
#131214	constant _NL_ABALTMON_8
#131215	constant _NL_ABALTMON_9
#131216	constant _NL_ABALTMON_10
#131217	constant _NL_ABALTMON_11
#131218	constant _NL_ABALTMON_12
#131219	constant _NL_WABALTMON_1
#131220	constant _NL_WABALTMON_2
#131221	constant _NL_WABALTMON_3
#131222	constant _NL_WABALTMON_4
#131223	constant _NL_WABALTMON_5
#131224	constant _NL_WABALTMON_6
#131225	constant _NL_WABALTMON_7
#131226	constant _NL_WABALTMON_8
#131227	constant _NL_WABALTMON_9
#131228	constant _NL_WABALTMON_10
#131229	constant _NL_WABALTMON_11
#131230	constant _NL_WABALTMON_12
#131231	constant _NL_NUM_LC_TIME
#196608	constant _NL_COLLATE_NRULES
#196609	constant _NL_COLLATE_RULESETS
#196610	constant _NL_COLLATE_TABLEMB
#196611	constant _NL_COLLATE_WEIGHTMB
#196612	constant _NL_COLLATE_EXTRAMB
#196613	constant _NL_COLLATE_INDIRECTMB
#196614	constant _NL_COLLATE_GAP1
#196615	constant _NL_COLLATE_GAP2
#196616	constant _NL_COLLATE_GAP3
#196617	constant _NL_COLLATE_TABLEWC
#196618	constant _NL_COLLATE_WEIGHTWC
#196619	constant _NL_COLLATE_EXTRAWC
#196620	constant _NL_COLLATE_INDIRECTWC
#196621	constant _NL_COLLATE_SYMB_HASH_SIZEMB
#196622	constant _NL_COLLATE_SYMB_TABLEMB
#196623	constant _NL_COLLATE_SYMB_EXTRAMB
#196624	constant _NL_COLLATE_COLLSEQMB
#196625	constant _NL_COLLATE_COLLSEQWC
#196626	constant _NL_COLLATE_CODESET
#196627	constant _NL_NUM_LC_COLLATE
#0	constant _NL_CTYPE_CLASS
#1	constant _NL_CTYPE_TOUPPER
#2	constant _NL_CTYPE_GAP1
#3	constant _NL_CTYPE_TOLOWER
#4	constant _NL_CTYPE_GAP2
#5	constant _NL_CTYPE_CLASS32
#6	constant _NL_CTYPE_GAP3
#7	constant _NL_CTYPE_GAP4
#8	constant _NL_CTYPE_GAP5
#9	constant _NL_CTYPE_GAP6
#10	constant _NL_CTYPE_CLASS_NAMES
#11	constant _NL_CTYPE_MAP_NAMES
#12	constant _NL_CTYPE_WIDTH
#13	constant _NL_CTYPE_MB_CUR_MAX
#14	constant _NL_CTYPE_CODESET_NAME
#14	constant CODESET
#15	constant _NL_CTYPE_TOUPPER32
#16	constant _NL_CTYPE_TOLOWER32
#17	constant _NL_CTYPE_CLASS_OFFSET
#18	constant _NL_CTYPE_MAP_OFFSET
#19	constant _NL_CTYPE_INDIGITS_MB_LEN
#20	constant _NL_CTYPE_INDIGITS0_MB
#21	constant _NL_CTYPE_INDIGITS1_MB
#22	constant _NL_CTYPE_INDIGITS2_MB
#23	constant _NL_CTYPE_INDIGITS3_MB
#24	constant _NL_CTYPE_INDIGITS4_MB
#25	constant _NL_CTYPE_INDIGITS5_MB
#26	constant _NL_CTYPE_INDIGITS6_MB
#27	constant _NL_CTYPE_INDIGITS7_MB
#28	constant _NL_CTYPE_INDIGITS8_MB
#29	constant _NL_CTYPE_INDIGITS9_MB
#30	constant _NL_CTYPE_INDIGITS_WC_LEN
#31	constant _NL_CTYPE_INDIGITS0_WC
#32	constant _NL_CTYPE_INDIGITS1_WC
#33	constant _NL_CTYPE_INDIGITS2_WC
#34	constant _NL_CTYPE_INDIGITS3_WC
#35	constant _NL_CTYPE_INDIGITS4_WC
#36	constant _NL_CTYPE_INDIGITS5_WC
#37	constant _NL_CTYPE_INDIGITS6_WC
#38	constant _NL_CTYPE_INDIGITS7_WC
#39	constant _NL_CTYPE_INDIGITS8_WC
#40	constant _NL_CTYPE_INDIGITS9_WC
#41	constant _NL_CTYPE_OUTDIGIT0_MB
#42	constant _NL_CTYPE_OUTDIGIT1_MB
#43	constant _NL_CTYPE_OUTDIGIT2_MB
#44	constant _NL_CTYPE_OUTDIGIT3_MB
#45	constant _NL_CTYPE_OUTDIGIT4_MB
#46	constant _NL_CTYPE_OUTDIGIT5_MB
#47	constant _NL_CTYPE_OUTDIGIT6_MB
#48	constant _NL_CTYPE_OUTDIGIT7_MB
#49	constant _NL_CTYPE_OUTDIGIT8_MB
#50	constant _NL_CTYPE_OUTDIGIT9_MB
#51	constant _NL_CTYPE_OUTDIGIT0_WC
#52	constant _NL_CTYPE_OUTDIGIT1_WC
#53	constant _NL_CTYPE_OUTDIGIT2_WC
#54	constant _NL_CTYPE_OUTDIGIT3_WC
#55	constant _NL_CTYPE_OUTDIGIT4_WC
#56	constant _NL_CTYPE_OUTDIGIT5_WC
#57	constant _NL_CTYPE_OUTDIGIT6_WC
#58	constant _NL_CTYPE_OUTDIGIT7_WC
#59	constant _NL_CTYPE_OUTDIGIT8_WC
#60	constant _NL_CTYPE_OUTDIGIT9_WC
#61	constant _NL_CTYPE_TRANSLIT_TAB_SIZE
#62	constant _NL_CTYPE_TRANSLIT_FROM_IDX
#63	constant _NL_CTYPE_TRANSLIT_FROM_TBL
#64	constant _NL_CTYPE_TRANSLIT_TO_IDX
#65	constant _NL_CTYPE_TRANSLIT_TO_TBL
#66	constant _NL_CTYPE_TRANSLIT_DEFAULT_MISSING_LEN
#67	constant _NL_CTYPE_TRANSLIT_DEFAULT_MISSING
#68	constant _NL_CTYPE_TRANSLIT_IGNORE_LEN
#69	constant _NL_CTYPE_TRANSLIT_IGNORE
#70	constant _NL_CTYPE_MAP_TO_NONASCII
#71	constant _NL_CTYPE_NONASCII_CASE
#72	constant _NL_CTYPE_EXTRA_MAP_1
#73	constant _NL_CTYPE_EXTRA_MAP_2
#74	constant _NL_CTYPE_EXTRA_MAP_3
#75	constant _NL_CTYPE_EXTRA_MAP_4
#76	constant _NL_CTYPE_EXTRA_MAP_5
#77	constant _NL_CTYPE_EXTRA_MAP_6
#78	constant _NL_CTYPE_EXTRA_MAP_7
#79	constant _NL_CTYPE_EXTRA_MAP_8
#80	constant _NL_CTYPE_EXTRA_MAP_9
#81	constant _NL_CTYPE_EXTRA_MAP_10
#82	constant _NL_CTYPE_EXTRA_MAP_11
#83	constant _NL_CTYPE_EXTRA_MAP_12
#84	constant _NL_CTYPE_EXTRA_MAP_13
#85	constant _NL_CTYPE_EXTRA_MAP_14
#86	constant _NL_NUM_LC_CTYPE
#262144	constant __INT_CURR_SYMBOL
#262145	constant __CURRENCY_SYMBOL
#262146	constant __MON_DECIMAL_POINT
#262147	constant __MON_THOUSANDS_SEP
#262148	constant __MON_GROUPING
#262149	constant __POSITIVE_SIGN
#262150	constant __NEGATIVE_SIGN
#262151	constant __INT_FRAC_DIGITS
#262152	constant __FRAC_DIGITS
#262153	constant __P_CS_PRECEDES
#262154	constant __P_SEP_BY_SPACE
#262155	constant __N_CS_PRECEDES
#262156	constant __N_SEP_BY_SPACE
#262157	constant __P_SIGN_POSN
#262158	constant __N_SIGN_POSN
#262159	constant _NL_MONETARY_CRNCYSTR
#262160	constant __INT_P_CS_PRECEDES
#262161	constant __INT_P_SEP_BY_SPACE
#262162	constant __INT_N_CS_PRECEDES
#262163	constant __INT_N_SEP_BY_SPACE
#262164	constant __INT_P_SIGN_POSN
#262165	constant __INT_N_SIGN_POSN
#262166	constant _NL_MONETARY_DUO_INT_CURR_SYMBOL
#262167	constant _NL_MONETARY_DUO_CURRENCY_SYMBOL
#262168	constant _NL_MONETARY_DUO_INT_FRAC_DIGITS
#262169	constant _NL_MONETARY_DUO_FRAC_DIGITS
#262170	constant _NL_MONETARY_DUO_P_CS_PRECEDES
#262171	constant _NL_MONETARY_DUO_P_SEP_BY_SPACE
#262172	constant _NL_MONETARY_DUO_N_CS_PRECEDES
#262173	constant _NL_MONETARY_DUO_N_SEP_BY_SPACE
#262174	constant _NL_MONETARY_DUO_INT_P_CS_PRECEDES
#262175	constant _NL_MONETARY_DUO_INT_P_SEP_BY_SPACE
#262176	constant _NL_MONETARY_DUO_INT_N_CS_PRECEDES
#262177	constant _NL_MONETARY_DUO_INT_N_SEP_BY_SPACE
#262178	constant _NL_MONETARY_DUO_P_SIGN_POSN
#262179	constant _NL_MONETARY_DUO_N_SIGN_POSN
#262180	constant _NL_MONETARY_DUO_INT_P_SIGN_POSN
#262181	constant _NL_MONETARY_DUO_INT_N_SIGN_POSN
#262182	constant _NL_MONETARY_UNO_VALID_FROM
#262183	constant _NL_MONETARY_UNO_VALID_TO
#262184	constant _NL_MONETARY_DUO_VALID_FROM
#262185	constant _NL_MONETARY_DUO_VALID_TO
#262186	constant _NL_MONETARY_CONVERSION_RATE
#262187	constant _NL_MONETARY_DECIMAL_POINT_WC
#262188	constant _NL_MONETARY_THOUSANDS_SEP_WC
#262189	constant _NL_MONETARY_CODESET
#262190	constant _NL_NUM_LC_MONETARY
#65536	constant __DECIMAL_POINT
#65536	constant RADIXCHAR
#65537	constant __THOUSANDS_SEP
#65537	constant THOUSEP
#65538	constant __GROUPING
#65539	constant _NL_NUMERIC_DECIMAL_POINT_WC
#65540	constant _NL_NUMERIC_THOUSANDS_SEP_WC
#65541	constant _NL_NUMERIC_CODESET
#65542	constant _NL_NUM_LC_NUMERIC
#327680	constant __YESEXPR
#327681	constant __NOEXPR
#327682	constant __YESSTR
#327683	constant __NOSTR
#327684	constant _NL_MESSAGES_CODESET
#327685	constant _NL_NUM_LC_MESSAGES
#458752	constant _NL_PAPER_HEIGHT
#458753	constant _NL_PAPER_WIDTH
#458754	constant _NL_PAPER_CODESET
#458755	constant _NL_NUM_LC_PAPER
#524288	constant _NL_NAME_NAME_FMT
#524289	constant _NL_NAME_NAME_GEN
#524290	constant _NL_NAME_NAME_MR
#524291	constant _NL_NAME_NAME_MRS
#524292	constant _NL_NAME_NAME_MISS
#524293	constant _NL_NAME_NAME_MS
#524294	constant _NL_NAME_CODESET
#524295	constant _NL_NUM_LC_NAME
#589824	constant _NL_ADDRESS_POSTAL_FMT
#589825	constant _NL_ADDRESS_COUNTRY_NAME
#589826	constant _NL_ADDRESS_COUNTRY_POST
#589827	constant _NL_ADDRESS_COUNTRY_AB2
#589828	constant _NL_ADDRESS_COUNTRY_AB3
#589829	constant _NL_ADDRESS_COUNTRY_CAR
#589830	constant _NL_ADDRESS_COUNTRY_NUM
#589831	constant _NL_ADDRESS_COUNTRY_ISBN
#589832	constant _NL_ADDRESS_LANG_NAME
#589833	constant _NL_ADDRESS_LANG_AB
#589834	constant _NL_ADDRESS_LANG_TERM
#589835	constant _NL_ADDRESS_LANG_LIB
#589836	constant _NL_ADDRESS_CODESET
#589837	constant _NL_NUM_LC_ADDRESS
#655360	constant _NL_TELEPHONE_TEL_INT_FMT
#655361	constant _NL_TELEPHONE_TEL_DOM_FMT
#655362	constant _NL_TELEPHONE_INT_SELECT
#655363	constant _NL_TELEPHONE_INT_PREFIX
#655364	constant _NL_TELEPHONE_CODESET
#655365	constant _NL_NUM_LC_TELEPHONE
#720896	constant _NL_MEASUREMENT_MEASUREMENT
#720897	constant _NL_MEASUREMENT_CODESET
#720898	constant _NL_NUM_LC_MEASUREMENT
#786432	constant _NL_IDENTIFICATION_TITLE
#786433	constant _NL_IDENTIFICATION_SOURCE
#786434	constant _NL_IDENTIFICATION_ADDRESS
#786435	constant _NL_IDENTIFICATION_CONTACT
#786436	constant _NL_IDENTIFICATION_EMAIL
#786437	constant _NL_IDENTIFICATION_TEL
#786438	constant _NL_IDENTIFICATION_FAX
#786439	constant _NL_IDENTIFICATION_LANGUAGE
#786440	constant _NL_IDENTIFICATION_TERRITORY
#786441	constant _NL_IDENTIFICATION_AUDIENCE
#786442	constant _NL_IDENTIFICATION_APPLICATION
#786443	constant _NL_IDENTIFICATION_ABBREVIATION
#786444	constant _NL_IDENTIFICATION_REVISION
#786445	constant _NL_IDENTIFICATION_DATE
#786446	constant _NL_IDENTIFICATION_CATEGORY
#786447	constant _NL_IDENTIFICATION_CODESET
#786448	constant _NL_NUM_LC_IDENTIFICATION
#786449	constant _NL_NUM

\ ------===< functions >===-------
FUNCTION: nl_langinfo ( __item -- a )	( __item -- )
FUNCTION: nl_langinfo_l ( __item __l -- a )	( __item __l -- )

\ ----===< postfix >===-----
( none )
