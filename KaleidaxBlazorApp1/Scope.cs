using System;
using System.Text.Json.Serialization;

namespace KaleidaxBlazorApp1
{
    public class Scope
    {
        public string ImageUrl { get; set; }
        public string AudioUrl { get; set; }
        public bool IsAnimationPlaying { get; set; } = false;
        public bool IsAudioPlaying { get; set; } = false;
        public string AudioTrack { get { return IsAudioPlaying ? AudioUrl : ""; } }
        public bool IsRotating { get; set; } = false;
        public string RotatingClass { get { return IsRotating ? "rotateScope" : ""; } }
        public bool IsAttachingImage { get; set; } = false;
        public string AttachingImageClass { get { return IsAttachingImage ? "imagePathInput fadeIn animated" : "imagePathInput"; } }
        public string AttachingImageVisible { get { return IsAttachingImage ? "visible" : "hidden"; } }
        public string AnimationImage { get; set; } = "images/play.png";
        public string RotateImage { get; set; } = "images/rotateRight.png";
        public string AttachImage { get; set; } = "images/image.png";
        public string AudioImage { get; set; } = "images/audio.png";
        public string BackgroundPositions { get; set; }
        public int Limit = new Random().Next(max - 10000, max);
        public double SquenceX { get; set; }
        public double SquenceY { get; set; }
        public int SpeedX { get; set; } = new Random().Next(3, 7);
        public int SpeedY { get; set; } = new Random().Next(3, 7);
        public int Index { get; } = 0;
        private static int trackIndex = 0;
        private const int max = 30000;

        public Scope()
        {
            Index = ++trackIndex;
            SquenceX = new Random().Next(1, Limit);
            SquenceY = new Random().Next(1, Limit);
        }
    }
    public class ImagePath
    {
        public string ImageUrl { get; set; }
        public string AudioUrl { get; set; }
    }
}