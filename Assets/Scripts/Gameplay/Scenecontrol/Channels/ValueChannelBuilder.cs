using EmmySharp;
using MoonSharp.Interpreter;

namespace ArcCreate.Gameplay.Scenecontrol
{
    [MoonSharpUserData]
    [EmmyAlias("Channel")]
    [EmmyDoc("Class for creating different channels")]
    [EmmySingleton]
    public class ValueChannelBuilder
    {
        [EmmyDoc("Create a keyframe channel")]
        public static KeyChannel Keyframe() => new KeyChannel();

        [EmmyDoc("Create a fast fourier transform channel that reacts to the system's audio")]
        [EmmyAlias("FFT")]
        public static FFTChannel FFT(int freqBandMin, int freqBandMax, float min, float max, float smoothness, float scalar)
            => new FFTChannel(freqBandMin, freqBandMax, min, max, smoothness, scalar);

        [EmmyDoc("Create a channel that clamp between values")]
        public static ClampChannel Clamp(ValueChannel a, ValueChannel b, ValueChannel c)
            => new ClampChannel(a, b, c);

        [EmmyDoc("Create a conditional channel")]
        public static ConditionalChannel Condition(ValueChannel control, ValueChannel threshold, ValueChannel ifAbove, ValueChannel ifEqual, ValueChannel ifBelow)
            => new ConditionalChannel(control, threshold, ifAbove, ifEqual, ifBelow);

        [EmmyDoc("Create a constant channel")]
        public static ConstantChannel Constant(float val)
            => new ConstantChannel(val);

        [EmmyDoc("Create a periodic cosine channel")]
        public static CosChannel Cos(ValueChannel period, ValueChannel min, ValueChannel max, ValueChannel offset)
            => new CosChannel(period, min, max, offset);

        [EmmyDoc("Create an exponential channel")]
        public static ExpChannel Exp(ValueChannel num, ValueChannel exp)
            => new ExpChannel(num, exp);

        [EmmyDoc("Create a channel that chooses max value between two channels")]
        public static MaxChannel Max(ValueChannel a, ValueChannel b)
            => new MaxChannel(a, b);

        [EmmyDoc("Create a channel that chooses min value between two channels")]
        public static MinChannel Min(ValueChannel a, ValueChannel b)
            => new MinChannel(a, b);

        [EmmyDoc("Create a perlin noise channel")]
        public static NoiseChannel Noise(ValueChannel frequency, ValueChannel min, ValueChannel max, ValueChannel offset, ValueChannel octave)
            => new NoiseChannel(frequency, min, max, offset, octave);

        [EmmyDoc("Create a random channel")]
        public static RandomChannel Random(int seed, ValueChannel min, ValueChannel max)
            => new RandomChannel(seed, min, max);

        [EmmyDoc("Create a saw channel that loop between values")]
        public static SawChannel Saw(string easing, ValueChannel period, ValueChannel min, ValueChannel max, ValueChannel offset)
            => new SawChannel(easing, period, min, max, offset);

        [EmmyDoc("Create a periodic sine channel")]
        public static SineChannel Sine(ValueChannel period, ValueChannel min, ValueChannel max, ValueChannel offset)
            => new SineChannel(period, min, max, offset);
    }
}