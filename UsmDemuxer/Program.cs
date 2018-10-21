using VGMToolbox.format;

namespace UsmDemuxer
{
    class Program
    {
        static int Main(string[] args)
        {
            if (args.Length < 1) return 1;
            string path = args[0];
            new CriUsmStream(path).DemultiplexStreams(new MpegStream.DemuxOptionsStruct
            {
                ExtractAudio = true,
                ExtractVideo = true,
                AddHeader = false,
                SplitAudioStreams = false
            });
            return 0;
        }
    }
}
