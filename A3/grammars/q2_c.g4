grammar q2_c;

start : rule EOF;

rule:
    ('a' | 'c')* 'b''b''b' ('a' | 'b' | 'c')*;



