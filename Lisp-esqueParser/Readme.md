Lisp-esque Parser
=================
This parser will read in strings of Polish notation equations
(http://en.wikipedia.org/wiki/Polish_notation), and output the
answer in integer format.

The accepted operators are addition ('+'), subtraction ('-'),
multiplication ('*') and division ('/'). Only integers are accepted as
operands (though changing this would not be hard).

It is done by creating a stack of the operators and operands, and then
popping them off to evaluate them recursively.