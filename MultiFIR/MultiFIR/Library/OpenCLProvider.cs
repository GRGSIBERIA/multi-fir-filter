using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCL.Net;

namespace MultiFIR.Library
{
    public struct PlatformInformation
    {
        public string Name { get; private set; }
        public string Vendor { get; private set; }
        public string Version { get; private set; }
        public string Extension { get; private set; }
        public string Profile { get; private set; }

        public PlatformInformation(string name, string vendor, string version, string extension, string profile)
        {
            Name = name;
            Vendor = vendor;
            Version = version;
            Extension = extension;
            Profile = profile;
        }
    }

    public class OpenCLProvider
    {
        public Platform[] Platforms { get; private set; }
        public PlatformInformation[] PlatformInformations { get; private set; }
        public int SelectedPlatformIndex { get; set; }

        /// <summary>
        /// 選択されているプラットフォームIDを返す
        /// </summary>
        public PlatformInformation SelectedPlatformInformation
        {
            get
            {
                return PlatformInformations[SelectedPlatformIndex];
            }
        }

        ErrorCode error;

        public OpenCLProvider()
        {
            Platforms = Cl.GetPlatformIDs(out error);
            SelectedPlatformIndex = -1; // 0初期化されないようにする

            var infos = new List<PlatformInformation>();
            foreach(var platform in Platforms)
            {
                infos.Add(new PlatformInformation(
                Cl.GetPlatformInfo(platform, PlatformInfo.Name, out error).ToString(),
                Cl.GetPlatformInfo(platform, PlatformInfo.Vendor, out error).ToString(),
                Cl.GetPlatformInfo(platform, PlatformInfo.Version, out error).ToString(),
                Cl.GetPlatformInfo(platform, PlatformInfo.Extensions, out error).ToString(),
                Cl.GetPlatformInfo(platform, PlatformInfo.Profile, out error).ToString()));
            }
            PlatformInformations = infos.ToArray();
        }
    }
}
