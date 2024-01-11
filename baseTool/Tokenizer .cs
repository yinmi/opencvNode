using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opencvNode.BaseTool
{
    /// <summary>
    /// 表达式词法分析
    /// </summary>
   public  enum TokenType
   {
        variable,
        figure,

        leftParen,
        rightParen,
        //算数运算
        add,
        subtract,
        multiply,
        divide,
        power,
        //二元关系
        equal,
        notEqual,
        less,
        lessOrEqual,
        greater,
        greaterOrEqual,
        //逻辑运算符
        and,
        or,
        not,
        //包含
        cover,

        error
        
    }
   public  class Token
    {
        public TokenType Type;
        public string Value;

    }
   public class Tokenizer
{
        List<Token> tokens;

        public  Tokenizer()
        {
            tokens = new List<Token>();
        }

        public List<Token> TokenArithmetic(string arg)
        {
            int charPosition = 0;
            while(charPosition<arg.Length)
            {
                switch (arg.ElementAt(charPosition))
                {
                    case ' ':
                        charPosition++;
                        break;

                    case '+':
                        tokens.Add(new Token() { Type = TokenType.add, Value = "+" });
                        charPosition++;
                        break;
                    case '-':
                        tokens.Add(new Token() { Type = TokenType.subtract, Value = "-" });
                        charPosition++;
                        break;
                    case '*':
                        tokens.Add(new Token() { Type = TokenType.multiply, Value = "*" });
                        charPosition++;
                        break;
                    case '/':
                        tokens.Add(new Token() { Type = TokenType.divide, Value = "/" });
                        charPosition++;
                        break;
                    case '^':
                        tokens.Add(new Token() { Type = TokenType.power, Value = "^" });
                        charPosition++;
                        break;
                    case '=':
                        tokens.Add(new Token() { Type = TokenType.equal, Value = "=" });
                        charPosition++;
                        break;
                    case '!':
                        if (charPosition + 1 < arg.Length && arg.ElementAt(charPosition + 1) == '=')
                        {
                            tokens.Add(new Token() { Type = TokenType.notEqual, Value = "!=" });
                            charPosition=+2;
                        }
                        else
                            tokens.Add(new Token() { Type = TokenType.not, Value = "!" });
                        charPosition++;
                        break;
                    case '>':
                        if (charPosition + 1 < arg.Length && arg.ElementAt(charPosition + 1) == '=')
                        {
                            tokens.Add(new Token() { Type = TokenType.greaterOrEqual, Value = ">=" });
                            charPosition=+2;
                        }
                        else
                            tokens.Add(new Token() { Type = TokenType.greater, Value = ">" });
                        charPosition++;
                        break;
                    case '<':
                        if (charPosition + 1 < arg.Length && arg.ElementAt(charPosition + 1) == '=')
                        {
                            tokens.Add(new Token() { Type = TokenType.lessOrEqual, Value = "<=" });
                            charPosition=+2;
                        }
                        else
                            tokens.Add(new Token() { Type = TokenType.less, Value = "<" });
                        charPosition++;
                        break;
                    case '&':
                        tokens.Add(new Token() { Type = TokenType.and, Value = "&" });
                        charPosition++;
                        break;

                    case '|':
                        tokens.Add(new Token() { Type = TokenType.or, Value = "|" });
                        charPosition++;
                        break;
                    case '.':
                        tokens.Add(new Token() { Type = TokenType.cover, Value = "." });
                        charPosition++;
                        break;

                    default:
                        {
                            if (arg.ElementAt(charPosition) >= 'a' && arg.ElementAt(charPosition) <= 'z' || arg.ElementAt(charPosition) >= 'A' && arg.ElementAt(charPosition) <= 'Z')
                            {
                                string name = "";
                                name = name + arg.ElementAt(charPosition);
                                charPosition++;

                                while( charPosition < arg.Length &&(arg.ElementAt(charPosition) >= 'a' && arg.ElementAt(charPosition) <= 'z' || arg.ElementAt(charPosition) >= 'A' && arg.ElementAt(charPosition) <= 'Z'|| arg.ElementAt(charPosition) >= '0' && arg.ElementAt(charPosition) <= '9'))
                                {
                                    name = name + arg.ElementAt(charPosition);
                                    charPosition++;
                                }

                                tokens.Add(new Token() { Type = TokenType.variable, Value = name });
                            }else if (arg.ElementAt(charPosition) >= '0' && arg.ElementAt(charPosition) <= '9' )
                            {
                                string name = "";
                                name = name + arg.ElementAt(charPosition);
                                charPosition++;

                                while (charPosition < arg.Length &&(arg.ElementAt(charPosition) >= '0' && arg.ElementAt(charPosition) <= '9'|| arg.ElementAt(charPosition)=='.'))
                                {
                                    name = name + arg.ElementAt(charPosition);
                                    charPosition++;
                                }

                                tokens.Add(new Token() { Type = TokenType.figure, Value = name });
                            } else
                            {
                                tokens.Add(new Token() { Type = TokenType.error, Value = arg.ElementAt(charPosition).ToString() });
                            }



                            break;
                        }
                }



            }




            return tokens;
        }




    }
}
