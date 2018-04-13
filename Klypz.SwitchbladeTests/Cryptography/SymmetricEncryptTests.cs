using Microsoft.VisualStudio.TestTools.UnitTesting;
using Klypz.Switchblade.Cryptography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klypz.Switchblade.Cryptography.Tests
{
    [TestClass()]
    public class SymmetricEncryptTests
    {
        private List<string> texts = new List<string>
        {
"Morbi a odio nec augue facilisis suscipit et et mi.",
"Cras luctus erat in est porta dignissim.",
"Phasellus vitae mauris ut tellus pretium interdum.",
"Praesent dapibus tellus id mattis commodo.",
"Phasellus eget nisl a tortor tristique porta id at mi.",
"Morbi nec ligula quis augue maximus ullamcorper id in ante.",
"Vestibulum maximus ante efficitur, tempus lacus in, faucibus libero.",
"Integer pellentesque dolor nec nisl condimentum pharetra.",
"Fusce sodales nisi a nunc hendrerit, in egestas nisl aliquam.",
"Integer ac libero vitae ligula sagittis consequat vitae euismod justo.",
"Integer vel velit eget velit fringilla commodo.",
"Donec volutpat ligula nec urna sodales fringilla.",
"Quisque quis mauris id lacus iaculis volutpat a eu ante.",
"Pellentesque ornare nibh imperdiet quam laoreet varius.",
"Vestibulum ut mi scelerisque, imperdiet ligula sit amet, aliquam nisi.",
"Sed ac ex in turpis cursus interdum sit amet at leo.",
"Aenean ac ex ut turpis aliquet scelerisque.",
"Etiam vehicula risus sit amet augue tincidunt, sit amet vulputate lectus malesuada.",
"Mauris imperdiet nibh vitae mi rutrum, a aliquam urna suscipit.",
"Phasellus quis eros et metus cursus ultrices.",
"Proin eget dolor vel velit molestie vulputate nec eget arcu.",
"Mauris tristique magna non cursus dignissim.",
"Donec tincidunt ante sed enim cursus, id semper lorem vestibulum.",
"Pellentesque vehicula tellus eu magna condimentum ultricies.",
"Nullam sed arcu blandit, condimentum urna at, lobortis sem.",
"Vestibulum efficitur lacus eget rhoncus tempus.",
"Pellentesque pulvinar tellus et purus porttitor, eu euismod lectus lacinia.",
"Fusce pellentesque leo at fringilla euismod.",
"Nulla nec enim id elit feugiat convallis.",
"Maecenas tristique est in justo pellentesque pretium.",
"In tincidunt dui vel diam luctus, vel aliquam felis ultricies.",
"Pellentesque elementum quam et libero volutpat, eu consectetur sapien aliquet.",
"In interdum nibh sed ante ornare, at venenatis tortor imperdiet.",
"Integer molestie sem quis tortor fermentum, a mollis turpis hendrerit.",
"Proin a nunc maximus, efficitur felis non, gravida enim.",
"Ut nec velit lacinia, molestie dui nec, commodo nunc.",
"Phasellus et urna auctor, venenatis ex vel, dignissim tortor.",
"Integer placerat mi eget viverra semper.",
"Nullam ultrices magna sed massa mollis lobortis.",
"Nunc quis est sed velit sollicitudin elementum.",
"Phasellus interdum eros ac dui consequat, vel sagittis odio tincidunt.",
"In luctus ligula sed maximus ullamcorper.",
"Quisque ac erat nec libero fringilla tristique.",
"Nam eget erat ut augue convallis euismod.",
"Donec egestas odio a nisl placerat, eu tincidunt orci suscipit.",
"Nulla eget elit a augue commodo condimentum.",
"Praesent aliquet arcu eu augue tempus, lobortis tincidunt odio pretium.",
"Donec gravida turpis et mauris lacinia, id lacinia ex eleifend.",
"Quisque pellentesque velit non turpis aliquet, sed vulputate massa rhoncus.",
"Nulla eget lacus sit amet sem consectetur convallis.",
"Donec facilisis sem placerat nibh rhoncus, vitae aliquet neque cursus.",
"Cras blandit est finibus lorem sodales, sed consectetur arcu sollicitudin.",
"Vivamus euismod quam non nibh venenatis finibus.",
"Phasellus quis odio vitae odio commodo scelerisque.",
"Suspendisse tempus tellus eu turpis ultrices, cursus auctor ante mattis.",
"Ut et risus vel dui iaculis hendrerit mollis ut nulla.",
"Cras eget nulla pellentesque, vestibulum ex tristique, ullamcorper mauris.",
"Phasellus porttitor neque in molestie vulputate.",
"Aenean in massa sollicitudin, aliquam urna at, interdum nunc.",
"Duis vitae purus tincidunt, ultrices quam a, venenatis magna.",
"Curabitur blandit augue at leo gravida, at volutpat orci molestie.",
"Vivamus quis sapien pellentesque lorem venenatis sollicitudin sit amet nec quam.",
"Nunc ultrices nibh a velit euismod aliquet.",
"Praesent et augue quis ligula accumsan tempus nec ut odio.",
"Integer volutpat arcu sit amet nisi ultrices interdum.",
"Suspendisse maximus magna ut diam semper semper.",
"Vivamus lacinia dui non pharetra iaculis.",
"Proin porttitor risus tempor, condimentum tellus a, volutpat mauris.",
"Aliquam eu sapien vitae ligula interdum congue id at odio.",
"Nulla pretium lacus quis tempus convallis.",
"Aliquam vitae enim pulvinar, lacinia urna sed, pretium metus.",
"Nulla id ligula id est sagittis dignissim.",
"Sed dapibus ligula ac pretium consectetur.",
"Integer malesuada enim non neque interdum aliquet.",
"Fusce nec ipsum mollis, varius libero a, faucibus eros.",
"Cras consequat erat eu fringilla tincidunt.",
"Aenean varius lectus non nulla vehicula efficitur.",
"Morbi porttitor ante dignissim ultricies consectetur."
        };
        private List<string> secrets = new List<string>
        {
            @"~9WdzXH`\sYh2(,P",
            @"b8ngLt3WHxaC648L",
            @"tgMupPvRnTzWLNUr",
            @"FMJZJFAKNEVWCWCD"
        };
        private TestContext testContextInstance;

        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        [TestCategory("Cryptography")]
        [TestMethod()]
        public void SymmetricEncryptTest()
        {
            foreach (var secret in secrets)
            {
                SymmetricEncrypt symmetricEncrypt = new SymmetricEncrypt(secret);
                foreach (var text in texts)
                {
                    string result = symmetricEncrypt.Encrypt(text);
                    Assert.AreEqual(text, symmetricEncrypt.Decrypt(result));

                    TestContext.WriteLine($"[{text}]");
                    TestContext.WriteLine($"Symm: {result}");
                    TestContext.WriteLine("-------------------------------------");
                }
            }
        }
    }
}