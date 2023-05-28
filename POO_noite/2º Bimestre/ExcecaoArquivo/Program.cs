try
{
// Isto causará uma exceção
File.OpenRead("\\teste\\ArquivoLeitura.txt");
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