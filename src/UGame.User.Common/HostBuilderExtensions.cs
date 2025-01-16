using Microsoft.Extensions.DependencyInjection;
using UGame.User.Common;

namespace Microsoft.Extensions.Hosting
{
    public static class XxyyHostBuilderExtensions
    {
        public static IHostBuilder UseXxyyCommonServer<TSection>(this IHostBuilder builder)
            where TSection : AppSectionBase, new()
        {
            var section = ConfigUtil.GetSection<TSection>();
            if (section == null)
                throw new Exception("配置AppOptions不存在");
            builder.ConfigureServices(services => {
                services.AddSingleton<AppSectionBase>(section);
                services.AddSingleton(section);
            });
            return builder;
        }
    }
}
