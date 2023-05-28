int valor1 = 100, valor2 = 0, total = 0;
try //Bloco onde poderá ocorrer algum erro
{
total = valor1 / valor2;
}
catch (Exception ex) //Classe responsável pelo tipo de erro
{
throw ex;
}

/* try
{
// Isto causará uma exceção
//File.OpenRead("\\teste\\ArquivoLeitura.txt");
File.OpenRead("ArquivoLeitura.txt");
}
catch (FileNotFoundException e)
{
Console.WriteLine();
Console.WriteLine("Erro pelo FileNotFoundException");
Console.WriteLine("-------------------------------------");
Console.WriteLine(e.ToString());
Console.WriteLine();
}
catch (DirectoryNotFoundException e)
{
Console.WriteLine();
Console.WriteLine("Erro pelo DirectoryNotFoundException");
Console.WriteLine("-------------------------------------");
Console.WriteLine(e.ToString());
Console.WriteLine();
}
catch (Exception e)
{
Console.WriteLine();
Console.WriteLine("Erro pelo Exception");
Console.WriteLine("-------------------------------------");
Console.WriteLine(e.ToString());
Console.WriteLine();
}
*/
System.Console.WriteLine("Termino do programa..."); 