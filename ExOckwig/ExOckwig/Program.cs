// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using ExOckwig;
internal class Program
{
    static void Main(string[] args)
    {
        String FilePath = (args.Length == 1) ? args[0] : null;
        BST SymbolTable = new BST();
        BST.LeftTraverse(SymbolTable.Root);
        LinkedList<Literal> LiteralTable; 
        ExVal expression = new ExVal(FilePath, out LiteralTable, SymbolTable);

        Console.WriteLine("Literal    Value      Size   Address");
        foreach (Literal Lit in LiteralTable)
        {
            Console.WriteLine(Lit.ToString());
        }
    }
}