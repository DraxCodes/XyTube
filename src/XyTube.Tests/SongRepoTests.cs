using System.Threading.Tasks;
using Xunit;
using XyTube.Core.Entities;
using XyTube.Core.Services;
using XyTube.Explode;

namespace XyTube.Tests
{
    public class SongRepoTests
    {
        private readonly ISongRepo _songRepo;
        public SongRepoTests()
        {
            _songRepo = new SongRepo();
        }

        [Fact]
        public async Task GetTrackById_ShouldReturnFailOnInvalidId()
        {
            var track = await _songRepo.GetTrackById("123456789");

            Assert.Equal(Status.Failed, track.Status);
        }
    }
}
