using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XyTube.Core.Entities;
using XyTube.Core.Services;

namespace XyTube.Explode
{
    public class SongRepo : ISongRepo
    {
        public Task<XyTrack> GetTrackById(string id)
        {
            throw new NotImplementedException();
        }

        public Task<XyTrack> GetTrackByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<XyTrack> GetTrackByUri(Uri uri)
        {
            throw new NotImplementedException();
        }
    }
}
