using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace MultiFIR.Library
{
    public struct Channel
    {
        public string Name { get; private set; }

        public Channel(string name)
        {
            Name = name;
        }
    }

    public class ASIOProvider
    {
        AsioOut asio;

        public Channel[] Inputs { get; private set; }
        public Channel[] Outputs { get; private set; }
        public float PlaybackLatency { get { return asio.PlaybackLatency; } }
        public PlaybackState PlaybackState { get { return asio.PlaybackState; } }

        public ASIOProvider(string driverName)
        {
            asio = new AsioOut(driverName);

            var inputs = new List<Channel>();
            for (int i = 0; i < asio.NumberOfInputChannels; ++i)
                inputs.Add(new Channel(
                    asio.AsioInputChannelName(i)));
            Inputs = inputs.ToArray();

            var outputs = new List<Channel>();
            for (int i = 0; i < asio.NumberOfOutputChannels; ++i)
                outputs.Add(new Channel(
                    asio.AsioOutputChannelName(i)));
            Outputs = outputs.ToArray();

            
        }
    }

    public class WaveProvider : IWaveProvider
    {
        public WaveFormat WaveFormat => throw new NotImplementedException();

        public int Read(byte[] buffer, int offset, int count)
        {
            throw new NotImplementedException();
        }
    }
}
