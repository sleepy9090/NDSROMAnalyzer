using System;
using System.IO;
using System.Linq;

namespace NDSROMAnalyzer
{
    public class NDSROMInfo
    {
        string path;

        public NDSROMInfo(string gamePath)
        {
            path = gamePath;
        }

        public string GetGameTitle()
        {
            return ConvertHexToAscii(GetHexStringFromFile(0x000, 0xC));
        }

        public string GetGameCode()
        {
            return ConvertHexToAscii(GetHexStringFromFile(0x00C, 0x4));
        }

        public string GetMakerCode()
        {
            return ConvertHexToAscii(GetHexStringFromFile(0x010, 0x2));
        }

        public string GetUnitCode()
        {
            return GetHexStringFromFile(0x012, 0x1);
        }

        public string GetEncryptionSeedSelect()
        {
            return GetHexStringFromFile(0x013, 0x1);
        }

        public string GetDeviceCapacity()
        {
            return GetHexStringFromFile(0x014, 0x1);
        }

        public string GetReserved()
        {
            return GetHexStringFromFile(0x015, 0x7);
        }

        public string GetGameRevision()
        {
            return GetHexStringFromFile(0x01C, 0x2);
        }

        public string GetROMVersion()
        {
            return GetHexStringFromFile(0x01E, 0x1);
        }

        public string GetInternalFlags()
        {
            return GetHexStringFromFile(0x01F, 0x1);
        }

        public string GetARM9ROMOffset()
        {
            return GetHexStringFromFile(0x020, 0x4);
        }

        public string GetARM9EntryAddress()
        {
            return GetHexStringFromFile(0x024, 0x4);
        }

        public string GetARM9LoadAddress()
        {
            return GetHexStringFromFile(0x028, 0x4);
        }

        public string GetARM9Size()
        {
            return GetHexStringFromFile(0x02C, 0x4);
        }

        public string GetARM7RomOffset()
        {
            return GetHexStringFromFile(0x030, 0x4);
        }

        public string GetARM7EntryAddress()
        {
            return GetHexStringFromFile(0x034, 0x4);
        }

        public string GetARM7LoadAddress()
        {
            return GetHexStringFromFile(0x038, 0x4);
        }

        public string GetARM7Size()
        {
            return GetHexStringFromFile(0x03C, 0x4);
        }

        public string GetFileNameTableOffset()
        {
            return GetHexStringFromFile(0x040, 0x4);
        }

        public string GetFileNameTableLength()
        {
            return GetHexStringFromFile(0x044, 0x4);
        }

        public string GetFileAllocationTableOffset()
        {
            return GetHexStringFromFile(0x048, 0x4);
        }

        public string GetFileAllocationTableLength()
        {
            return GetHexStringFromFile(0x04C, 0x4);
        }

        public string GetARM9OverlayOffset()
        {
            return GetHexStringFromFile(0x050, 0x4);
        }

        public string GetARM9OverlayLength()
        {
            return GetHexStringFromFile(0x054, 0x4);
        }

        public string GetARM7OverlayOffset()
        {
            return GetHexStringFromFile(0x058, 0x4);
        }

        public string GetARM7OverlayLength()
        {
            return GetHexStringFromFile(0x05C, 0x4);
        }

        public string GetNormalCardControlRegisterSettings()
        {
            return GetHexStringFromFile(0x060, 0x4);
        }

        public string GetSecureCardControlRegisterSettings()
        {
            return GetHexStringFromFile(0x064, 0x4);
        }

        public string GetIconBannerOffset()
        {
            return GetHexStringFromFile(0x068, 0x4);
        }

        public string GetSecureArea2KCRC()
        {
            return GetHexStringFromFile(0x06C, 0x2);
        }

        public string GetSecureTransferTimeout()
        {
            return GetHexStringFromFile(0x06E, 0x2);
        }

        public string GetARM9Autload()
        {
            return GetHexStringFromFile(0x070, 0x4);
        }

        public string GetARM7Autload()
        {
            return GetHexStringFromFile(0x074, 0x4);
        }

        public string GetSecureDisable()
        {
            return GetHexStringFromFile(0x078, 0x8);
        }

        public string GetNTRRegionROMSize()
        {
            return GetHexStringFromFile(0x080, 0x4);
        }

        public string GetHeaderSize()
        {
            return GetHexStringFromFile(0x084, 0x4);
        }

        public string GetReserved2()
        {
            return GetHexStringFromFile(0x088, 0x38);
        }

        public string GetNintendoLogo()
        {
            return GetHexStringFromFile(0x0C0, 0x9C);
        }

        public string GetNintendoLogoCRC()
        {
            return GetHexStringFromFile(0x15C, 0x2);
        }

        public string GetHeaderCRC()
        {
            return GetHexStringFromFile(0x15E, 0x2);
        }

        public string GetDebuggerReserved()
        {
            return GetHexStringFromFile(0x160, 0x20);
        }

        public string GetGlobalMBK1ToMBK5Settings()
        {
            return GetHexStringFromFile(0x180, 0x14);
        }

        public string GetLocalMBK6ToMBK8SettingsForARM9()
        {
            return GetHexStringFromFile(0x194, 0xC);
        }

        public string GetLocalMBK6ToMBK8SettingsForARM7()
        {
            return GetHexStringFromFile(0x1A0, 0xC);
        }

        public string GetGlobalMBK9Setting()
        {
            return GetHexStringFromFile(0x1AC, 0x4);
        }

        public string GetRegionFlags()
        {
            return GetHexStringFromFile(0x1B0, 0x4);
        }

        public string GetAccessControl()
        {
            return GetHexStringFromFile(0x1B4, 0x4);
        }

        public string GetARM7SCFGEXTMask()
        {
            return GetHexStringFromFile(0x1B8, 0x4);
        }

        public string GetReservedFlags()
        {
            return GetHexStringFromFile(0x1BC, 0x4);
        }

        public string GetARM9iROMOffset()
        {
            return GetHexStringFromFile(0x1C0, 0x4);
        }

        public string GetReserved3()
        {
            return GetHexStringFromFile(0x1C4, 0x4);
        }

        public string GetARM9iLoadAddress()
        {
            return GetHexStringFromFile(0x1C8, 0x4);
        }

        public string GetARM9iSize()
        {
            return GetHexStringFromFile(0x1CC, 0x4);
        }

        public string GetARM7iROMOffset()
        {
            return GetHexStringFromFile(0x1D0, 0x4);
        }

        public string GetPointerTobaseAddress()
        {
            return GetHexStringFromFile(0x1D4, 0x4);
        }

        public string GetARM7iLoadAddress()
        {
            return GetHexStringFromFile(0x1D8, 0x4);
        }

        public string GetARM7iSize()
        {
            return GetHexStringFromFile(0x1DC, 0x4);
        }

        public string GetDigestNTRRegionOffset()
        {
            return GetHexStringFromFile(0x1E0, 0x4);
        }

        public string GetDigestNTRRegionLength()
        {
            return GetHexStringFromFile(0x1E4, 0x4);
        }

        public string GetDigestTWLRegionOffset()
        {
            return GetHexStringFromFile(0x1E8, 0x4);
        }

        public string GetDigestTWLRegionLength()
        {
            return GetHexStringFromFile(0x1EC, 0x4);
        }

        public string GetDigestSectorHashtableOffset()
        {
            return GetHexStringFromFile(0x1F0, 0x4);
        }

        public string GetDigestSectorHashtableLength()
        {
            return GetHexStringFromFile(0x1F4, 0x4);
        }

        public string GetDigestBlockHashtableOffset()
        {
            return GetHexStringFromFile(0x1F8, 0x4);
        }

        public string GetDigestBlockHashtableLength()
        {
            return GetHexStringFromFile(0x1FC, 0x4);
        }

        public string GetDigestSectorSize()
        {
            return GetHexStringFromFile(0x200, 0x4);
        }

        public string GetDigestBlockSectorCount()
        {
            return GetHexStringFromFile(0x204, 0x4);
        }

        public string GetIconBannerSize() // 0x23C0
        {
            return GetHexStringFromFile(0x208, 0x4);
        }

        public string GetUnknown()
        {
            return GetHexStringFromFile(0x20C, 0x4);
        }

        public string GetNTRTWLRegionROMSize()
        {
            return GetHexStringFromFile(0x210, 0x4);
        }

        public string GetUnknown2()
        {
            return GetHexStringFromFile(0x214, 0xC);
        }

        public string GetModcryptArea1Offset()
        {
            return GetHexStringFromFile(0x220, 0x4);
        }

        public string GetModcryptArea1Size()
        {
            return GetHexStringFromFile(0x224, 0x4);
        }

        public string GetModcryptArea2Offset()
        {
            return GetHexStringFromFile(0x228, 0x4);
        }

        public string GetModcryptArea2Size()
        {
            return GetHexStringFromFile(0x22C, 0x4);
        }

        public string GetTitleID()
        {
            return GetHexStringFromFile(0x230, 0x8);
        }

        public string GetDSIWarePublicSavSize()
        {
            return GetHexStringFromFile(0x238, 0x4);
        }

        public string GetDSIWarePrivateSavSize()
        {
            return GetHexStringFromFile(0x23C, 0x4);
        }

        public string GetReservedZero()
        {
            return GetHexStringFromFile(0x240, 0xB0);
        }

        public string GetUnknown3()
        {
            return GetHexStringFromFile(0x2F0, 0x10);
        }

        public string GetARM9WithEncryptedSecureAreaSHA1HMACHash()
        {
            return GetHexStringFromFile(0x300, 0x14);
        }

        public string GetARM7SHA1HMACHash()
        {
            return GetHexStringFromFile(0x314, 0x14);
        }

        public string GetDigestMasterSHA1HMACHash()
        {
            return GetHexStringFromFile(0x328, 0x14);
        }

        public string GetBannerSHA1HMACHash()
        {
            return GetHexStringFromFile(0x33C, 0x14);
        }

        public string GetARM9iSHA1HMACHash()
        {
            return GetHexStringFromFile(0x350, 0x14);
        }

        public string GetARM7iSHA1HMACHash()
        {
            return GetHexStringFromFile(0x364, 0x14);
        }

        public string GetReserved4()
        {
            return GetHexStringFromFile(0x378, 0x28);
        }

        public string GetARM9WithoutSecureAreaSHA1HMACHash()
        {
            return GetHexStringFromFile(0x3A0, 0x14);
        }

        public string GetReserved5()
        {
            return GetHexStringFromFile(0x3B4, 0xA4C);
        }

        public string GetReservedDebug()
        {
            return GetHexStringFromFile(0xE00, 0x180);
        }

        public string GetRSASignature()
        {
            return GetHexStringFromFile(0xF80, 0x80);
        }

        private static string ConvertAsciiToHex(String asciiString)
        {
            char[] charValues = asciiString.ToCharArray();
            string hexValue = "";
            foreach (char c in charValues)
            {
                int value = Convert.ToInt32(c);
                hexValue += String.Format("{0:X}", value);
            }
            return hexValue;
        }

        private static string ConvertHexToAscii(String hexString)
        {
            try
            {
                string ascii = string.Empty;

                for (int i = 0; i < hexString.Length; i += 2)
                {
                    String hs = string.Empty;

                    hs = hexString.Substring(i, 2);
                    uint decval = System.Convert.ToUInt32(hs, 16);
                    char character = System.Convert.ToChar(decval);
                    ascii += character;

                }

                return ascii;
            }
            catch (Exception ex)
            {
                // Console.WriteLine(ex.Message);
            }

            return string.Empty;
        }

        private string GetHexStringFromFile(int startPoint, int length)
        {
            string hexString = "";
            using (FileStream fileStream = new FileStream(@path, FileMode.Open, FileAccess.Read))
            {
                long offset = fileStream.Seek(startPoint, SeekOrigin.Begin);

                for (int x = 0; x < length; x++)
                {
                    hexString += fileStream.ReadByte().ToString("X2");
                }

            }

            return hexString;
        }

        private static byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }

        private bool WriteByteArrayToFile(string fileName, int startPoint, byte[] byteArray)
        {
            bool result = false;
            try
            {
                using (var fs = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite))
                {
                    fs.Position = startPoint;
                    fs.Write(byteArray, 0, byteArray.Length);
                    result = true;
                }
            }
            catch (Exception ex)
            {
                // Console.WriteLine("Error writing file: {0}", ex);
                result = false;
            }

            return result;
        }
    }

}