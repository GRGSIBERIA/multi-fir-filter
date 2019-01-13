using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCL.Net;

namespace MultiFIR.Library
{
    /// <summary>
    /// OpenCLプラットフォーム情報
    /// </summary>
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

    /// <summary>
    /// GPUデバイス情報
    /// </summary>
    public struct DeviceInformation
    {
        public string Name { get; private set; }
        public string Platform { get; private set; }
        public string Version { get; private set; }
        public string Vendor { get; private set; }
        public string DriverVersion { get; private set; }
        public string DeviceType { get; private set; }
        public string MaxComputeUnits { get; private set; }
        public string MaxWorkItemSize { get; private set; }
        public string MaxWorkGroupSize { get; private set; }
        public string MaxMemoryAllocationSize { get; private set; }
        public string MaxClockFrequency { get; private set; }
        public string AddressBits { get; private set; }
        public string GlobalMemorySize { get; private set; }
        public string GlobalCacheSize { get; private set; }
        public string GlobalCacheLineSize { get; private set; }
        public string LocalMemorySize { get; private set; }
        public string LocalMemoryType { get; private set; }
        public string MaxConstantBufferSize { get; private set; }
        public string ProfilingTimerResolution { get; private set; }
        public string Available { get; private set; }
        public string CompilerAvailable { get; private set; }

        public DeviceInformation(
            string name, string platform, string version, string vendor,
            string driverVersion, string deviceType, string maxComputeUnits,
            string maxWorkItemSize, string maxWorkGroupSize, string maxMemoryAllocationSize,
            string maxClockFrequency, string addressBits, string globalMemorySize,
            string globalCacheSize, string globalCacheLineSize, string localMemorySize,
            string localMemoryType, string maxConstantBufferSize, string profilingTimerResolution,
            string available, string compilerAvailable)
        {
            Name = name;
            Platform = platform;
            Version = version;
            Vendor = vendor;
            DriverVersion = driverVersion;
            DeviceType = deviceType;
            MaxComputeUnits = maxComputeUnits;
            MaxWorkItemSize = maxWorkItemSize;
            MaxWorkGroupSize = maxWorkGroupSize;
            MaxMemoryAllocationSize = maxMemoryAllocationSize;
            MaxClockFrequency = maxClockFrequency;
            AddressBits = addressBits;
            GlobalMemorySize = globalMemorySize;
            GlobalCacheSize = globalCacheSize;
            GlobalCacheLineSize = globalCacheLineSize;
            LocalMemorySize = localMemorySize;
            LocalMemoryType = localMemoryType;
            MaxConstantBufferSize = maxConstantBufferSize;
            ProfilingTimerResolution = profilingTimerResolution;
            Available = available;
            CompilerAvailable = compilerAvailable;
        }
    }

    /// <summary>
    /// OpenCLプラットフォームが未選択の場合に送出する
    /// </summary>
    public class NoSelectedOpenCLPlatformException : System.Exception
    {
        public NoSelectedOpenCLPlatformException(string message) : base(message) { }
    }

    public class OpenCLProvider
    {
        public Platform[] Platforms { get; private set; }
        public PlatformInformation[] PlatformInformations { get; private set; }

        /// <summary>
        /// 選択されたプラットフォーム，未指定の場合は-1
        /// </summary>
        public int SelectedPlatformIndex { get; set; }

        /// <summary>
        /// 選択されたGPUデバイス，未指定の場合は-1
        /// </summary>
        public int SelectedDeviceIndex { get; set; }

        /// <summary>
        /// 選択されているプラットフォームを返す
        /// </summary>
        public PlatformInformation SelectedPlatformInformation
        {
            get
            {
                try
                {
                    return PlatformInformations[SelectedPlatformIndex];
                }
                catch(IndexOutOfRangeException)
                {
                    throw new NoSelectedOpenCLPlatformException("OpenCLプラットフォームが未選択です");
                }
            }
        }

        public Platform SelectedPlatform
        {
            get
            {
                try
                {
                    return Platforms[SelectedPlatformIndex];
                }
                catch(IndexOutOfRangeException)
                {
                    throw new NoSelectedOpenCLPlatformException("OpenCLプラットフォームが未選択です");
                }
            }
        }

        public Device[] Devices { get; private set; }
        public DeviceInformation[] DeviceInformations { get; private set; }

        ErrorCode error;

        public OpenCLProvider()
        {
            Platforms = Cl.GetPlatformIDs(out error);

            // 未選択状態を初期状態にしておく
            SelectedPlatformIndex = -1;
            SelectedDeviceIndex = -1;

            var infos = new List<PlatformInformation>();
            foreach(var platform in Platforms)
            {
                infos.Add(new PlatformInformation(
                    Cl.GetPlatformInfo(platform, PlatformInfo.Name, out error).ToString(),
                    Cl.GetPlatformInfo(platform, PlatformInfo.Vendor, out error).ToString(),
                    Cl.GetPlatformInfo(platform, PlatformInfo.Version, out error).ToString(),
                    Cl.GetPlatformInfo(platform, PlatformInfo.Extensions, out error).ToString(),
                    Cl.GetPlatformInfo(platform, PlatformInfo.Profile, out error).ToString()
                    ));
            }
            PlatformInformations = infos.ToArray();
        }

        public void IncludeDevices()
        {
            Devices = Cl.GetDeviceIDs(SelectedPlatform, DeviceType.All, out error);
            var infos = new List<DeviceInformation>();
            foreach (var device in Devices)
            {
                infos.Add(new DeviceInformation(
                    Cl.GetDeviceInfo(device, DeviceInfo.Name, out error).ToString(),
                    Cl.GetDeviceInfo(device, DeviceInfo.Platform, out error).ToString(),
                    Cl.GetDeviceInfo(device, DeviceInfo.Version, out error).ToString(),
                    Cl.GetDeviceInfo(device, DeviceInfo.Vendor, out error).ToString(),
                    Cl.GetDeviceInfo(device, DeviceInfo.DriverVersion, out error).ToString(),
                    Cl.GetDeviceInfo(device, DeviceInfo.Type, out error).ToString(),
                    Cl.GetDeviceInfo(device, DeviceInfo.MaxComputeUnits, out error).ToString(),
                    Cl.GetDeviceInfo(device, DeviceInfo.MaxWorkItemSizes, out error).ToString(),
                    Cl.GetDeviceInfo(device, DeviceInfo.MaxWorkGroupSize, out error).ToString(),
                    Cl.GetDeviceInfo(device, DeviceInfo.MaxMemAllocSize, out error).ToString(),
                    Cl.GetDeviceInfo(device, DeviceInfo.MaxClockFrequency, out error).ToString(),
                    Cl.GetDeviceInfo(device, DeviceInfo.AddressBits, out error).ToString(),
                    Cl.GetDeviceInfo(device, DeviceInfo.GlobalMemSize, out error).ToString(),
                    Cl.GetDeviceInfo(device, DeviceInfo.GlobalMemCacheSize, out error).ToString(),
                    Cl.GetDeviceInfo(device, DeviceInfo.GlobalMemCachelineSize, out error).ToString(),
                    Cl.GetDeviceInfo(device, DeviceInfo.LocalMemSize, out error).ToString(),
                    Cl.GetDeviceInfo(device, DeviceInfo.LocalMemType, out error).ToString(),
                    Cl.GetDeviceInfo(device, DeviceInfo.MaxConstantBufferSize, out error).ToString(),
                    Cl.GetDeviceInfo(device, DeviceInfo.ProfilingTimerResolution, out error).ToString(),
                    Cl.GetDeviceInfo(device, DeviceInfo.Available, out error).ToString(),
                    Cl.GetDeviceInfo(device, DeviceInfo.CompilerAvailable, out error).ToString()
                    ));
            }
            DeviceInformations = infos.ToArray();
        }
    }
}
