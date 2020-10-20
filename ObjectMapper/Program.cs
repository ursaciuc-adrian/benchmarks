using System.Collections.Generic;
using ObjectMapperBenchmarks.Helpers;
using ObjectMapperBenchmarks.Mappers;

namespace ObjectMapperBenchmarks
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var unis = DataGeneratorHelper.GenerateData(1000, 100, 10);
            const int times = 50;

            var mappers = new List<IMapper>
            {
                new ManualMapper(),
                new AutoMapperConf(),
                new EmitMapperConf(),
                new ExpressMapperConf(),
                new TinyMapperConf(),
                new AgileMapperConf(),
                new MapsterConf()
            };

            foreach (var mapper in mappers)
            {
                BenchHelper.Count(mapper.GetType().Name, () =>
                {
                    var unisDtos = mapper.Map(unis);
                }, times);
            }
        }
    }
}