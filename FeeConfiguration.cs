using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using TransSurchg.Model;

namespace TransSurchg
{
    public class FeeConfiguration
    {
        public static FeeConfig GetFeeConfiguration()
        {
            var feeConfig = new FeeConfig();
            var feeConfigJson = System.IO.File.ReadAllText("./fees.config.json");
            using (var memStream = new MemoryStream(Encoding.Unicode.GetBytes(feeConfigJson)))
            {
                var deserializer = new DataContractJsonSerializer(typeof(FeeConfig));
                feeConfig = (FeeConfig)deserializer.ReadObject(memStream);
            }

            return feeConfig;
        }
    }
}
