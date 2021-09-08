from gen.JavaLexer import JavaLexer
from antlr4 import *


def main():
    input_stream = FileStream("../IO/input.java")
    lexer = JavaLexer(input_stream)
    token = lexer.nextToken()
    output = open("../IO/output.java", 'w')

    while token.type != Token.EOF:
        if token.type == lexer.LINE_COMMENT:
            output.write(token.text[2:])
        elif token.type == lexer.COMMENT:
            output.write(token.text[2:-2].rstrip("\n"))
        else:
            output.write(token.text.rstrip("\n"))

        token = lexer.nextToken()


if __name__ == "__main__":
    main()
