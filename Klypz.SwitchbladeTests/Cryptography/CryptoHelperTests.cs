using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;

namespace Klypz.Switchblade.Cryptography.Tests
{
    [TestClass()]
    public class CryptoHelperTests
    {
        private DataTable dictionaryTest = new DataTable();

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
        public CryptoHelperTests()
        {
            dictionaryTest.Columns.Add("Chave", typeof(String));
            dictionaryTest.Columns.Add("MD5", typeof(String));
            dictionaryTest.Columns.Add("SHA1", typeof(String));
            dictionaryTest.Columns.Add("SHA256", typeof(String));
            dictionaryTest.Columns.Add("SHA384", typeof(String));
            dictionaryTest.Columns.Add("SHA512", typeof(String));
            var dict = dictionaryTest.NewRow();
            dict["Chave"] = "p27H2fep";
            dict["MD5"] = "ee0f419a455d3be81ff7784c273a5198";
            dict["SHA1"] = "176706ad58bd49ce407ab0994cb9eb41212a97f3";
            dict["SHA256"] = "bcbf5860fa9f18962a86ff81ecea87bbd2fc2b97e02e69b45bd5d9af0dfb17f4";
            dict["SHA384"] = "55cc6f3928417dcc710c01b4fc6c0f613e574641ac8073d1192ab173ce231c18570137c7cbe70e0615c0385209dc1336";
            dict["SHA512"] = "a387bf172c9e4b49563967ce893fb14e11cadea3981d8f5a15103a886d2544f4ae7cf74aec71c49763d193760fd4f82caff70714c905829fd057d30930c14bd1";
            dictionaryTest.Rows.Add(dict);
            dict = dictionaryTest.NewRow();
            dict["Chave"] = "6mqcqW8S";
            dict["MD5"] = "a97e2cfdc50e085a55f0864a7a3391f7";
            dict["SHA1"] = "4e8594886aa225271702543917d2b2f1bc21a2cf";
            dict["SHA256"] = "6b0ad558bbffbed11f1ad64f576f92ac4e2274934b4afc2c26d001f629b261f3";
            dict["SHA384"] = "7abc9ef85eb025a6583442f0c5568e3b2f1d087042bd8db216be1e308e41500f765ac646066e73b160be35eae57fe71d";
            dict["SHA512"] = "494ebd1db5e5b8544860f6e43cafa28f1b0b8230dfe690d93f162d476243f1074da2bf8855511824842b5f5c49cae29f84cff5510bcebb7070411ac36502ed41";
            dictionaryTest.Rows.Add(dict);
            dict = dictionaryTest.NewRow();
            dict["Chave"] = "BhD95MGB";
            dict["MD5"] = "c8e4e96a23a6584e82dc05176848fd89";
            dict["SHA1"] = "2cc4647eff0bd0f4ff4bfa8b031cca23e7ab9871";
            dict["SHA256"] = "4cfcdee89dc4bdbf3c777bc66cd1784dcda584563006bc76cce436f143070f56";
            dict["SHA384"] = "0b169903e7d3532ef0de85444f57be5bbc8bb3e40903eb16a3a369a196653f98ea336549f30f1c45e7549c02b05652ee";
            dict["SHA512"] = "94303ac8c84667221f1e86f764ce5767f7dfe63143aaaf38b6edd69b70449292f52e296486739061a05441191dbe648cbc2c12382bdb7101a3b41c4c2f7cd9d7";
            dictionaryTest.Rows.Add(dict);
            dict = dictionaryTest.NewRow();
            dict["Chave"] = "TAYeSBck";
            dict["MD5"] = "7b0dc2538600eeb2ad7725bb43c51359";
            dict["SHA1"] = "6bcc2f6f1ade9eff7faf172bb2c6f29b596d671e";
            dict["SHA256"] = "a3b106c5d4ea07e539f0dcfa83721c6ac0565b97fc1d5ffb6753525e53786a25";
            dict["SHA384"] = "e3a2b797e44ed21ffbdbf25ac4c85a8ec054a9da77b9b6bda466bd274991987ea1d15527d01510e3f63f24975f78ab15";
            dict["SHA512"] = "b71797b753c1d9eeb5de6ff31be09e434e6cf8a654442deac1300242313a883e4f83019b8a36ed0a7be350aa94cdf897d0c4783da1ca7132f278a5ab71f223d7";
            dictionaryTest.Rows.Add(dict);
            dict = dictionaryTest.NewRow();
            dict["Chave"] = "MtzKanvL";
            dict["MD5"] = "e0415b4e032214772a4e40f3f63ccd82";
            dict["SHA1"] = "f4b37431067fc7e9a9a92693b482795b7c711851";
            dict["SHA256"] = "903e716dddeec08b79aafb8f77e147ab1aa2ecb0dd76d7246d7a259158b9bb5b";
            dict["SHA384"] = "a1ebd88d7a07dc496b15a3b8f836b750fd399a85b7bc6015081c1709e861d7d40c995dddbf37b2d060e002d26dbadd7a";
            dict["SHA512"] = "55a50073c6adec3065a96949a3ef73d9636bee233e51dbc8baebcada0165e29278a31e3d97b46e01aa545d87eb1f0f6bef77ebf488d5b45c2f96de4098c8fc79";
            dictionaryTest.Rows.Add(dict);
            dict = dictionaryTest.NewRow();
            dict["Chave"] = "YC2jxkvd";
            dict["MD5"] = "0676b89b9524fd4993778a02668f0450";
            dict["SHA1"] = "9bf5966a542e1419611a516ee9f77733d11086d4";
            dict["SHA256"] = "1c1277f47b6af06391169a02644914203a961898fd5da795d9012487beb3bebf";
            dict["SHA384"] = "6849bf680ed725326c291a31bbf37eecf30ab70c2ea90685df07329c9722151b81db886c612f201a8f727e8be2919946";
            dict["SHA512"] = "e479cabb2b1ccc74bfdc15d5ca59765c2d13f64caa540861850d02df307efaae1c3cff9934da08b8b5e059ed9b8d54f0eff09ac01b684eaa4f80b2e1d8cb3a4a";
            dictionaryTest.Rows.Add(dict);
            dict = dictionaryTest.NewRow();
            dict["Chave"] = "9aKBzfEq";
            dict["MD5"] = "73f50599046142a07b15e5cc956dfdaf";
            dict["SHA1"] = "adf7a03dd57f07e1235e2abccdd8b636200748cf";
            dict["SHA256"] = "ad2ff67e749894c8d2ad3074f2559091225a2f30a87cfaf0cf583a31dcc77311";
            dict["SHA384"] = "14636c9a2b3a2c8b04d1937a077ca849ca21cb1f99ab69d7e846fff4b9f70c2aa52c4ffc0d8dea57ff1da5f2dcb48dcb";
            dict["SHA512"] = "456a1a556d079f9a76bdbd5bf84b01ec14c562c09e2fa91cf1dde17bda0c62e02d824c9e1ea697631409d2db0bcd6bd6aa949886dbc755cd9aa3c174af594f87";
            dictionaryTest.Rows.Add(dict);
            dict = dictionaryTest.NewRow();
            dict["Chave"] = "9YRm839z";
            dict["MD5"] = "0fb9f297476a59a205ce12c9a752ca5e";
            dict["SHA1"] = "ac8c2aec6d8bed9396f706b002e46b0d384506fb";
            dict["SHA256"] = "948b7370f539b24e49aa14a66378995866786551381f3b3f844d4f81a990f310";
            dict["SHA384"] = "5e83dc71334defdc1f5751313f9709e93e9433da6a3f05d90fb8a6451a04197402f0bf2fde8e27da5afe60f0046666fe";
            dict["SHA512"] = "e60e082ff46d4aae1a403645a83434581d3b2bd81ab868aa5dc0389bde1848a69122d5908bce402963deacbd773e7934c96bce55787da012ee96a0f11eda93cc";
            dictionaryTest.Rows.Add(dict);
            dict = dictionaryTest.NewRow();
            dict["Chave"] = "XJkddfu9";
            dict["MD5"] = "d1dd9cc1cffea037843661dbaa41cc3c";
            dict["SHA1"] = "7ce43562fc37b3a00727c1ff604986f4b736d392";
            dict["SHA256"] = "5df73f959196c4224708efd977517eb9f576a7f69eb5869532e16ebdce712e98";
            dict["SHA384"] = "cec5908ea6d342f054046b8ee870599ce381a427b6c91f86ed8ef987889f3a1b1e6dd555f08c506322cd10440414b674";
            dict["SHA512"] = "8add4a3438797b68a9734fc7c2d95b38546aacb412e7a11b900567e5c765b8ed9a18ae6f3fab616508353ba7d61f48bdc2024aaca2d67ea4557117e4fb9fd18d";
            dictionaryTest.Rows.Add(dict);
            dict = dictionaryTest.NewRow();
            dict["Chave"] = "C2R2jCHM";
            dict["MD5"] = "e5f1cac9bd41dfa66a7b9affcbbacd71";
            dict["SHA1"] = "87417b8bd4376b3711175804281126941a360cfe";
            dict["SHA256"] = "40f4563271cfd93a1537214b4accaaee82b71c7e23ac27fde2275c24e970ff91";
            dict["SHA384"] = "a55035c88b94b6ef69fef353be8c84146d44573020cb2630495a5d06662770a223fbda3b61dd044415a60a22fee96517";
            dict["SHA512"] = "fe2649a783071cd7b4aec9cb6709852a4bd4719aad90c18ec24388f9e82cad8e8c3cd259aefb3999affc42c30366fe990be3eddae84b026f443ec5e826832a85";
            dictionaryTest.Rows.Add(dict);
        }

        private TestContext testContextInstance;

        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        [TestCategory("Cryptography")]
        [TestMethod()]
        public void ToHashesTest()
        {
            foreach (DataRow row in dictionaryTest.Rows)
            {
                HashString hashString = new HashString((string)row["Chave"]);

                Assert.AreEqual(((string)row["Chave"]).ToMD5(), hashString.GetHashString(HashStringType.MD5));
                Assert.AreEqual(((string)row["Chave"]).ToSHA1(), hashString.GetHashString(HashStringType.SHA1));
                Assert.AreEqual(((string)row["Chave"]).ToSHA256(), hashString.GetHashString(HashStringType.SHA256));
                Assert.AreEqual(((string)row["Chave"]).ToSHA384(), hashString.GetHashString(HashStringType.SHA384));
                Assert.AreEqual(((string)row["Chave"]).ToSHA512(), hashString.GetHashString(HashStringType.SHA512));
            }
        }

        [TestCategory("Cryptography")]
        [TestMethod()]
        public void ToSymmetricEncryptTest()
        {
            foreach (var secret in secrets)
            {
                SymmetricEncrypt symmetricEncrypt = new SymmetricEncrypt(secret);
                foreach (var text in texts)
                {
                    string result = symmetricEncrypt.Encrypt(text);
                    Assert.AreEqual(text.ToSymmetricEncrypt(secret), result);
                    Assert.AreEqual(result.ToSymmetricDecrypt(secret), symmetricEncrypt.Decrypt(result));
                }
            }
        }
    }
}