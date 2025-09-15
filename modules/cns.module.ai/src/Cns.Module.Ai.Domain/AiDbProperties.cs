namespace Cns.Module.Ai;

public static class AiDbProperties
{
    public static string DbTablePrefix { get; set; } = "Ai";

    public static string? DbSchema { get; set; } = null;

    public const string ConnectionStringName = "Ai";
}
