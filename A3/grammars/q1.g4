grammar q1;

start: (BeforeA | AtoB | BtoC | AfterC) EOF;

// from 0.0.0.0 to 9.255.255.255
BeforeA:
    [0-9] Dot Octet Dot Octet Dot Octet;

// from 11.0.0.0 to 172.15.255.255 :
AtoB:
    Interval1 | Interval3;

// from 11.0.0.0 to 171.255.255.255
Interval1:
    Interval2 Dot Octet Dot Octet Dot Octet;

// from 11 to 171
Interval2:
    '1' [1-9] |
    [2-9][0-9] |
    '1' [0-6] [0-9] |
    '1' '7' [0-1];

// from 172.0.0.0 to 172.15.255.255
Interval3:
    '1' '7' '2' Dot Interval4 Dot Octet Dot Octet;

// from 0 to 15
Interval4:
    [0-9] |
    '1' [0-5];

// from 172.32.0.0 to 192.167.255.255
BtoC:
    Interval5 | Interval7 | Interval9;

// from 172.32.0.0 to 172.255.255.255
Interval5:
    '1' '7' '2' Dot Interval6 Dot Octet Dot Octet;

// from 32 to 255
Interval6:
    '3' [2-9] |
    [4-9] [0-9] |
    '1' [0-9] [0-9]
    '2' [0-4] [0-9]
    '2' '5' [0-5];

// from 173.0.0.0 to 191.255.255.255
Interval7:
    Interval8 Dot Octet Dot Octet Dot Octet;

// from 173 to 191
Interval8:
    '1' '7' [3-9] |
    '1' '8' [0-9] |
    '1' '9' [0-1];

// from 192.0.0.0 to 192.167.255.255
Interval9:
    '1' '9' '2' Dot Interval10 Dot Octet Dot Octet;

// from 0 to 167
Interval10:
    [0-9]?[0-9] |
    '1' [0-5] [0-9] |
    '1' '6' [0-7];

// from 192.169.0.0 to 255.255.255.255
AfterC:
    Interval11 | Interval12;

// from 192.169.0.0 to 192.255.255.255
Interval11:
    '1' '9' '2' Dot Interval13 Dot Octet Dot Octet;

// from 169 to 255
Interval13:
    '1' '6' '9' |
    '1' [7-9] [0-9]
    '2' [0-4] [0-9]
    '2' '5' [0-5];

// from 193.0.0.0 to 255.255.255.255
Interval12:
    Interval14 Dot Octet Dot Octet Dot Octet;


// from 193 to 255
Interval14:
    '1' '9' [3-9] |
    '2' [0-4] [0-9] |
    '2' '5' [0-5];

Octet:
   [0-9]?[0-9] |
   '1'[0-9][0-9] |
   '2''5'[0-5] |
   '2'[0-4][0-9];

Dot:
    '.';
