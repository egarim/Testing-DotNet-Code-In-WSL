using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Diagnostics;

namespace WslTest
{
    public class UnitTest1
    {
        [Fact]
        public async void Test1()
        {


            using ILoggerFactory loggerFactory =
                            LoggerFactory.Create(builder =>
                                builder.AddSimpleConsole(options =>
                                {
                                    options.IncludeScopes = true;
                                    options.SingleLine = true;
                                    options.TimestampFormat = "HH:mm:ss ";
                                }));

            ILogger<UnitTest1> logger = loggerFactory.CreateLogger<UnitTest1>();

           

            var result=   await "lsb_release -a".Bash(logger);

        }
    }
}