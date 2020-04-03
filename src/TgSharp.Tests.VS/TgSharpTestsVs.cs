
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TgSharp.Tests
{
    [TestClass]
    public class TgSharpTestsVS : TgSharpTests
    {
        [TestInitialize]
        public void Init()
        {
            base.Init(o => Assert.IsNotNull(o), b => Assert.IsTrue(b));
        }
        
        [TestMethod]
        public override async Task AuthUser()
        {
            await base.AuthUser();
        }

        [TestMethod]
        public override async Task SendMessageTest()
        {
            await base.SendMessageTest();
        }

        [TestMethod]
        public override async Task SendMessageToChannelTest()
        {
            await base.SendMessageToChannelTest();
        }

        [TestMethod]
        public override async Task SendPhotoToContactTest()
        {
            await base.SendPhotoToContactTest();
        }

        [TestMethod]
        public override async Task SendBigFileToContactTest()
        {
            await base.SendBigFileToContactTest();
        }

        [TestMethod]
        public override async Task DownloadFileFromContactTest()
        {
            await base.DownloadFileFromContactTest();
        }

        [TestMethod]
        public override async Task DownloadFileFromWrongLocationTest()
        {
            await base.DownloadFileFromWrongLocationTest();
        }

        [TestMethod]
        public override async Task SignUpNewUser()
        {
            await base.SignUpNewUser();
        }

        [TestMethod]
        public override async Task SendMessageByUserNameTest()
        {
            await base.SendMessageByUserNameTest();
        }
    }
}
