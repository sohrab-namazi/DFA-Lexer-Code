grammar q2_b;

start : rule EOF;

rule:
    (('b' | 'c')* 'a' ('b' | 'c')* 'a' ('b' | 'c')*  'a' ('b' | 'c')*)*;


