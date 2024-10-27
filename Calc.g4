grammar Calc;
start: (e (';' e)* | ) EOF;
e: e ('*'|'/') e | e ('+'|'-') e | ('+'|'-') e | '(' e ')' | INT ;
INT: [0-9]+;
WS: [ \n\r\t]+ -> channel(HIDDEN);
