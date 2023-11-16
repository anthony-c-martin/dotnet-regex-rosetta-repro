using System.Text.RegularExpressions;
					
public class Program
{
    private const string TypeSegmentPattern = "[a-z0-9][a-z0-9-.]*";
    private const string VersionPattern = "[a-z0-9][a-z0-9-]+";

    private const RegexOptions PatternRegexOptions = RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture | RegexOptions.Compiled | RegexOptions.CultureInvariant;
    private static readonly Regex ResourceTypePattern = new Regex(@$"^(?<type>{TypeSegmentPattern})(/(?<type>{TypeSegmentPattern}))*(@(?<version>{VersionPattern}))?$", PatternRegexOptions);
	
    public static void Main()
    {
        ResourceTypePattern.Match("Microsoft.Compute/virtualMachines@2022-01-01");
        Console.WriteLine("Success!");
    }
}