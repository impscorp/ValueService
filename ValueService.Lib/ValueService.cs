using System.ComponentModel.DataAnnotations.Schema;
using String = System.String;

namespace ValueService.Lib;

public class ValueService : IValueService
{
    public ValueService()
    {
        PostFactors  = new List<PostFactor>()
        {
            new PostFactor() { Text = "milli", TextShort = "m", Potenz = -3 },
            new PostFactor() { Text = "mikro", TextShort = "µ", Potenz = -6 },
            new PostFactor() { Text = "nano", TextShort = "n", Potenz = -9 },
            new PostFactor() { Text = "piko", TextShort = "p", Potenz = -12 },
            new PostFactor() { Text = "kilo", TextShort = "k", Potenz = 3 },
            new PostFactor() { Text = "Mega", TextShort = "M", Potenz = 6 },
            new PostFactor() { Text = "Giga", TextShort = "G", Potenz = 9 },
            new PostFactor() { Text = "Tera", TextShort = "T", Potenz = 12 },
            new PostFactor() { Text = "Peta", TextShort = "P", Potenz = 15 },
            new PostFactor() { Text = "Exa", TextShort = "E", Potenz = 18 }
        };
    }

    public readonly List<PostFactor> PostFactors; 
       
    

    public decimal GetDecimal(string value)
    {
        decimal result = 0;
        value = value.Replace('.', ',');
        string? postFactor = null;
        string[] numbers = null;
        try
        {

            foreach (var textShort in PostFactors.Where(element => value.Contains(element.TextShort)))
            {
                numbers = value.Split(textShort.TextShort);
                postFactor = textShort.TextShort;
            }
            if (numbers == null) 
            { 
                result = decimal.Parse(value);
            }
            
            if (numbers != null)
            {
                if (numbers.Count() > 2) throw new FormatException();
                if (numbers[1] != "") return Pow10PostFactor(decimal.Parse(String.Join(",", numbers)), postFactor);
                return Pow10PostFactor(decimal.Parse(String.Join("", numbers)), postFactor);

            }

        }
        catch (FormatException e)
        {
            throw new FormatException();
        }


        return Pow10PostFactor(result, postFactor);

    }
    

    public string GetDisplayValue(decimal value, int precision, string desiredpf = " ")
    {
        string postFactor = desiredpf != " " ? desiredpf : GetPostFactor(value);
        double.TryParse(Convert.ToString(GetPotenz(postFactor)), out var potenz);
        value /= (decimal)Math.Pow(10.00d, potenz);
        value = Math.Round(value, precision);
        return value + postFactor;
    }

    public decimal Pow10PostFactor(decimal number, string PostFactor)
    {
        double.TryParse(Convert.ToString(GetPotenz(PostFactor)),out double dblpotenz);
        return number * (decimal)Math.Pow(10.00d,dblpotenz);
    }

    public int? GetPotenz(string value)
    {
        if (value == "" ) return 0;
        return PostFactors.FirstOrDefault(element => element.TextShort == value) ? .Potenz;
        
        //foreach (var postfactor in PostFactors.Where(element => element.TextShort == value))
        //{
        //    return postfactor.Potenz;
        //}
    }

    public string GetPostFactor(decimal value)
    {
        var potenz = (int)Math.Floor(Math.Log10((double)value));
        var postfactor = PostFactors.FirstOrDefault(element => element.Potenz+1 == potenz ||
                                                                        element.Potenz+2 == potenz ||
                                                                        element.Potenz == potenz);
        return postfactor != null ? postfactor.TextShort : string.Empty;
    }
    
    public class PostFactor
    {
        public string Text { get; set; } = string.Empty;
        public string TextShort { get; set; } = string.Empty;
        public int Potenz { get; set; }

    }
}