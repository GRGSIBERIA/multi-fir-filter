using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;
using NAudio.Utils;
using NAudio.Wave.Asio;

namespace MultiFIR.Library
{
    public class AudioPatcher : ISampleProvider
    {
        public WaveFormat WaveFormat => throw new NotImplementedException();

        private readonly int outputChannels;
        private readonly int inputChannels;
        private float[] mixBuffer;

        public AudioPatcher(int sampleRate, int inputChannels, int outputChannels)
        {
            WaveFormat = WaveFormat.CreateIeeeFloatWaveFormat(sampleRate, outputChannels);
        }

        public void ProcessBuffer(IntPtr[] inBuffers, IntPtr[] outBuffers, int sampleCount, AsioSampleType sampleType)
        {
            Func<IntPtr, int, float> getInputSample;
            Action<IntPtr, int, float> setOutputSample;
            switch (sampleType)
            {
                case AsioSampleType.Int32LSB:
                    getInputSample = GetInputSampleInt32LSB;
                    setOutputSample = SetOutputSampleInt32LSB;
                    break;
                case AsioSampleType.Int16LSB:
                    getInputSample = GetInputSampleInt16LSB;
                    setOutputSample = SetOutputSampleInt16LSB;
                    break;
                case AsioSampleType.Float32LSB:
                    getInputSample = GetInputSampleFloat32LSB;
                    setOutputSample = SetOutputSampleFloat32LSB;
                    break;
            }
        }

        private unsafe void SetOutputSampleInt32LSB(IntPtr buffer, int n, float value)
        {
            *((int*)buffer + n) = (int)(value * int.MaxValue);
        }

        private unsafe float GetInputSampleInt32LSB(IntPtr inputBuffer, int n)
        {
            return *((int*)inputBuffer + n) / (float)int.MaxValue;
        }

        private unsafe float GetInputSampleInt16LSB(IntPtr inputBuffer, int n)
        {
            return *((short*)inputBuffer + n) / (float)short.MaxValue;
        }

        private unsafe void SetOutputSampleInt16LSB(IntPtr buffer, int n, float value)
        {
            *((short*)buffer + n) = (short)(value * short.MaxValue);
        }

        private unsafe float GetInputSampleFloat32LSB(IntPtr inputBuffer, int n)
        {
            return *((float*)inputBuffer + n);
        }

        private unsafe void SetOutputSampleFloat32LSB(IntPtr buffer, int n, float value)
        {
            *((float*)buffer + n) = value;
        }

        public int Read(float[] buffer, int offset, int count)
        {
            throw new NotImplementedException();
        }
    }
}
