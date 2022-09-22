namespace ValueService.Lib;

public interface IValueService
{
    /// <summary>
    /// Converts the given number to a decimal
    /// </summary>
    /// <param name="value">String of the number to convert can contain - ; . postfactor.</param>
    /// <returns>Decimal represantation of the string number without power and postfactor</returns>
    decimal GetDecimal(string value);

    /// <summary>
    /// Converts the decimal input value to string including postfactor and a specific number of postcomma digits
    /// </summary>
    /// <param name="value">decimal value to be convertet</param>
    /// <param name="precision">number of postcomma digits (rounded)</param>
    /// <returns>string representation to use at UIs</returns>
    public string GetDisplayValue(decimal value, int precision, string desiredpf = " ");

    /// <summary>
    /// Calculate a decimal number out of a number its postfactor (eg 100k = 100000)
    /// </summary>
    /// <param name="number">decimal number to multiply the postfactor to</param>
    /// <param name="PostFactor">string of the postfactor</param>
    /// <returns></returns>
    decimal Pow10PostFactor(decimal number, string PostFactor);

    /// <summary>
    /// determines the power (10^x) from the list
    /// </summary>
    /// <param name="value">postfactor to be searched</param>
    /// <returns>power x (10^x) as signed int. null if not positive</returns>
    int? GetPotenz(string value);

    /// <summary>
    /// determines the Postfactor from given value. The optimized factor is found, when the value is >0 and <1000
    /// </summary>
    /// <param name="value">decimal value without postfactor</param>
    /// <returns>optimal postfactor for the value (1 char)</returns>
    string GetPostFactor(decimal value);
    
}