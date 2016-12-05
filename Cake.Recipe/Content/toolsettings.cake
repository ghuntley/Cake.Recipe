public static class ToolSettings
{
    public static string[] DupFinderExcludePattern { get; private set; }
    public static string TestCoverageFilter { get; private set; }
    public static string TestCoverageExcludeByAttribute { get; private set; }
    public static string TestCoverageExcludeByFile { get; private set; }

    public static void SetToolSettings(
        ICakeContext context,
        string[] dupFinderExcludePattern = null,
        string testCoverageFilter = null,
        string testCoverageExcludeByAttribute = null,
        string testCoverageExcludeByFile = null
    )
    {
        // TODO: Remove hard coding of Cake.Example.Tests
        DupFinderExcludePattern = dupFinderExcludePattern ?? new string[] { context.MakeAbsolute(context.Environment.WorkingDirectory) + "/src/Cake.Example.Tests/*.cs" };
        TestCoverageFilter = testCoverageFilter ?? "+[*]* -[xunit.*]* -[Cake.Core]* -[Cake.Testing]* -[*.Tests]*";
        TestCoverageExcludeByAttribute = testCoverageExcludeByAttribute ?? "*.ExcludeFromCodeCoverage*";
        TestCoverageExcludeByFile = testCoverageExcludeByFile ?? "*/*Designer.cs;*/*.g.cs;*/*.g.i.cs";
    }
}