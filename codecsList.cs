using System.Collections.Generic;

public class CodecList
{
    public Dictionary<string, Dictionary<string, byte[]>> CodecData { get; private set; }

    public CodecList()
    {
        CodecData = new Dictionary<string, Dictionary<string, byte[]>>
        {
            {"A8_UNORM", new Dictionary<string, byte[]>
                {
                    {"bpp", new byte[] {0x08, 0x00, 0x00, 0x00}},
                    {"codec", new byte[] {0x00, 0x00, 0x00, 0x00}},
                    {"flags", new byte[] {0x02, 0x00, 0x00, 0x00}},
                    {"head_flg", new byte[] {0x0f, 0x10, 0x02, 0x00}},
                    {"rgb_mask", new byte[] {0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xff, 0x00, 0x00, 0x00}}
                }
            },
            {"AYUV", new Dictionary<string, byte[]>
                {
                    {"bpp", new byte[] {0x00, 0x00, 0x00, 0x00}},
                    {"codec", new byte[] {0x44, 0x58, 0x31, 0x30}},
                    {"flags", new byte[] {0x04, 0x00, 0x00, 0x00}},
                    {"head_flg", new byte[] {0x0f, 0x10, 0x02, 0x00}},
                    {"rgb_mask", new byte[] {0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00}}
                }
            },
            // Add other codec data here
        };
    }

    // Optionally, add methods to access and retrieve specific codec information
    public byte[] GetBpp(string codecName)
    {
        if (CodecData.TryGetValue(codecName, out var codecProperties) && codecProperties.TryGetValue("bpp", out var bppData))
        {
            return bppData;
        }

        // If codec not found, return null or throw an exception, depending on your requirements.
        return null;
    }

    // Add other methods as needed
}
