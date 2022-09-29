/*
 *  This programm
 * 
 *
 */

ValueService.Lib.ValueServices vs = new ValueService.Lib.ValueServices();

try
{
 var test = vs.GetDecimal("20.00k");
 
 Console.WriteLine(vs.GetDisplayValue(154,2));
}
catch (NotImplementedException ex)
{
 Console.WriteLine("Methode wurde noch nicht implementiert!");
 throw;
}






 
 
 