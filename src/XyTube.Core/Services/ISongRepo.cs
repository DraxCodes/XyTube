using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XyTube.Core.Entities;

namespace XyTube.Core.Services
{
    public interface ISongRepo
    {
        Task<XyTrack> GetTrackById(string id);
        Task<XyTrack> GetTrackByName(string name);
        Task<XyTrack> GetTrackByUri(Uri uri);
    }
}
