namespace roblox.fps.booster.Tests;

public class OptimizerEngineTests
{
    [Fact]
    public void Run_ReturnsCompletedReport()
    {
        var engine = new roblox.fps.booster.Core.OptimizerEngine();
        var report = engine.Run(roblox.fps.booster.Core.OptimizationProfile.Balanced);
        Assert.NotEmpty(report.Steps);
    }
}
