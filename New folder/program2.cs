using System;

public class BandNamer {
    public static string GetBandName(string noun) {
        string bandName;
        if (noun[0] == noun[noun.Length-1]) {
            bandName = noun.Substring(0,1).ToUpper() + noun.Substring(1) + noun.Substring(1);
        }
        else {
            bandName = "The " + noun.Substring(0,1).ToUpper() + noun.Substring(1);
        }
        return bandName;
    }
}

public class Program {
    public static void Main() {
        string noun1 = "dolphin";
        string noun2 = "alaska";
        Console.WriteLine(BandNamer.GetBandName(noun1)); // Output: "The Dolphin"
        Console.WriteLine(BandNamer.GetBandName(noun2)); // Output: "Alaskalaska"
    }
}
