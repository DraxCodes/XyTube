using System;
using System.Collections.Generic;
using System.Text;

namespace XyTube.Core.Entities
{
    public class XyTrack
    {
        public Status Status { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string ImageUrl { get; set; }
        public byte[] Stream { get; set; }
    }
}
