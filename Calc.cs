using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

public class Program
{
	static void Main(string[] args)
	{
		var str = CharStreams.fromStream(System.Console.OpenStandardInput());
		var lexer = new CalcLexer(str);
		var tokens = new CommonTokenStream(lexer);
		var parser = new CalcParser(tokens);
		var tree = parser.start();
		System.Console.WriteLine(tree.ToStringTree(parser));
	}
}
