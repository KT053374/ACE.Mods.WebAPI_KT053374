namespace ACE.Shared.Helpers;

public static class StringExtensions
{
    public static string Name(this CreatureVital vital) => vital switch
    {
        { Vital: PropertyAttribute2nd.MaxHealth } => "Maximum Health",
        { Vital: PropertyAttribute2nd.Health } => "Health",
        { Vital: PropertyAttribute2nd.MaxStamina } => "Maximum Stamina",
        { Vital: PropertyAttribute2nd.Stamina } => "Stamina",
        { Vital: PropertyAttribute2nd.MaxMana } => "Maximum Mana",
        { Vital: PropertyAttribute2nd.Mana } => "Mana",
        { Vital: PropertyAttribute2nd.Undef } => "Undef",
        _ => vital.ToString()
    };
    public static string Repeat(this string input, int count)
    {
        if (string.IsNullOrEmpty(input) || count <= 1)
            if (count <= 0)
                return string.Empty;

            if (string.IsNullOrEmpty(input) || count == 1)
                return input;

        var builder = new StringBuilder(input.Length * count);

        for (var i = 0; i < count; i++) builder.Append(input);

        return builder.ToString();
    }
}
