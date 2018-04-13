using Microsoft.VisualStudio.TestTools.UnitTesting;
using Klypz.Switchblade.Cryptography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Klypz.Switchblade.Cryptography.Tests
{
    [TestClass()]
    public class ApplySaltTests
    {
        private DataTable dictionaryTest = new DataTable();

        public ApplySaltTests()
        {
            dictionaryTest.Columns.Add("Chave", typeof(String));
            dictionaryTest.Columns.Add("SALT", typeof(String));
            dictionaryTest.Columns.Add("WITHSALT", typeof(String));

            var dict = dictionaryTest.NewRow();
            dict["Chave"] = @"p27H2fep";
            dict["SALT"] = @"~9WdzXH`\sYh2(,P";
            dict["WITHSALT"] = @"AI3s288GNYhrVz3lj+vQFar9BnZTJ1n7+vOoyZ2GMR51u3YXNIAiD27w4BotvF8JLNPZ4tJNeYkZ5l4MnsjoSg==";
            dictionaryTest.Rows.Add(dict);
            dict = dictionaryTest.NewRow();
            dict["Chave"] = @"6mqcqW8S";
            dict["SALT"] = @"~9WdzXH`\sYh2(,P";
            dict["WITHSALT"] = @"I4rSQS9r7CE2EdIAeCoGIJTwqfIyDDA0AFFmYuSOj8ym+mw51LyVoDurMxO+bVXO7LJGw0pZhkdwXid0Xj8CFA==";
            dictionaryTest.Rows.Add(dict);
            dict = dictionaryTest.NewRow();
            dict["Chave"] = @"BhD95MGB";
            dict["SALT"] = @"~9WdzXH`\sYh2(,P";
            dict["WITHSALT"] = @"vkG2YOI87kWeVzXhyGAMGTaxGN+QiAiCdhnkdPTg9ckoCtZsC2lUNV9FvyP/YVRvP5JpDBvTKqYQ5iNgPFCr7A==";
            dictionaryTest.Rows.Add(dict);
            dict = dictionaryTest.NewRow();
            dict["Chave"] = @"TAYeSBck";
            dict["SALT"] = @"~9WdzXH`\sYh2(,P";
            dict["WITHSALT"] = @"+5ROzWUehaVhXVAzZsMDRadz/fSUobHKI+vJTa74eW/UGMbHF4zT0fx5PK6WbWFLY5avO8sldk9LA+lUhXlQ2w==";
            dictionaryTest.Rows.Add(dict);
            dict = dictionaryTest.NewRow();
            dict["Chave"] = @"MtzKanvL";
            dict["SALT"] = @"~9WdzXH`\sYh2(,P";
            dict["WITHSALT"] = @"W4b3rQqvOtnVSY/m3G2ZnDyTpyPG13IoHyUekjcUSrhA3r8Hxfg9E6TdPVWtIp3QKPwB/HYvcHmmU1bqUa5CSQ==";
            dictionaryTest.Rows.Add(dict);
            dict = dictionaryTest.NewRow();
            dict["Chave"] = @"YC2jxkvd";
            dict["SALT"] = @"~9WdzXH`\sYh2(,P";
            dict["WITHSALT"] = @"XuOif20mCZVY/1W2fP3CiitZJFACL+0hZ5VTr3U8bigTSd/4vY634DHiNuvCYlwO9CKq0ozXxNWEYT8ABcAVJg==";
            dictionaryTest.Rows.Add(dict);
            dict = dictionaryTest.NewRow();
            dict["Chave"] = @"9aKBzfEq";
            dict["SALT"] = @"~9WdzXH`\sYh2(,P";
            dict["WITHSALT"] = @"fcpGLlCq6BRVouj0JoVG9uCF/Evu5husINg5ut8UWev1jMrot3038pXfBu4ZXBcoIUE9zg8lPiTS879BDtfQQw==";
            dictionaryTest.Rows.Add(dict);
            dict = dictionaryTest.NewRow();
            dict["Chave"] = @"9YRm839z";
            dict["SALT"] = @"~9WdzXH`\sYh2(,P";
            dict["WITHSALT"] = @"J27LGVROUR70QejRjjBtFL4Lk0GiHxY+hmRh2t9F2JMXJWUxq1yplR1LNzVMlPxVaNaTniErp02FG1Dpf6IeMg==";
            dictionaryTest.Rows.Add(dict);
            dict = dictionaryTest.NewRow();
            dict["Chave"] = @"XJkddfu9";
            dict["SALT"] = @"~9WdzXH`\sYh2(,P";
            dict["WITHSALT"] = @"6myr4jBqKrILXQMLYaUo21LCNbNzb0ZBEgGXm07/kLzoBGBJqS9HiZ+0GHtor1hk/e9eDTic3WG6hAp5+HER9A==";
            dictionaryTest.Rows.Add(dict);
            dict = dictionaryTest.NewRow();
            dict["Chave"] = @"C2R2jCHM";
            dict["SALT"] = @"~9WdzXH`\sYh2(,P";
            dict["WITHSALT"] = @"5bEN/gAH/BWfsYHnYtiQ+puUEKad1O/zGaWZWZ6AhtgDzam2uNRFknOWVFo1I6uU/DSyiB3IUeEwS9zS+EDa1g==";
            dictionaryTest.Rows.Add(dict);
            dict = dictionaryTest.NewRow();
            dict["Chave"] = @"p27H2fep";
            dict["SALT"] = @"b8ngLt3WHxaC648L";
            dict["WITHSALT"] = @"Xt633SELhq7itf5DWOyghOjedl/mpytmLJfj9eGLGfH3R0HOH1T/AzxPgzZrq95+whit2Po0bvua7uepuvGLCw==";
            dictionaryTest.Rows.Add(dict);
            dict = dictionaryTest.NewRow();
            dict["Chave"] = @"6mqcqW8S";
            dict["SALT"] = @"b8ngLt3WHxaC648L";
            dict["WITHSALT"] = @"v28nIzpirrYlPLZbY7hhwO9nbCcz9S4ynGtgYgFH0mue9V1OMVty8gonM5OQ5i7zIdUvmi7fc8qK/hMr6B6YNg==";
            dictionaryTest.Rows.Add(dict);
            dict = dictionaryTest.NewRow();
            dict["Chave"] = @"BhD95MGB";
            dict["SALT"] = @"b8ngLt3WHxaC648L";
            dict["WITHSALT"] = @"DDeFkAQRotIXnlXAOe56SizJ/gmpnP+pqC0DLh0s9pm/CRBIgIfMkBiQnlVWP/drap22a+/iB/BPUfMriauRHQ==";
            dictionaryTest.Rows.Add(dict);
            dict = dictionaryTest.NewRow();
            dict["Chave"] = @"TAYeSBck";
            dict["SALT"] = @"b8ngLt3WHxaC648L";
            dict["WITHSALT"] = @"/KOtfPac6P8lrDQgHV7AurA9ZJN66oMcaHbYNP0218jwnTJwfpt/ywlXL5DckGdHg5XuFbU4QRIff/Cv/g7iQA==";
            dictionaryTest.Rows.Add(dict);
            dict = dictionaryTest.NewRow();
            dict["Chave"] = @"MtzKanvL";
            dict["SALT"] = @"b8ngLt3WHxaC648L";
            dict["WITHSALT"] = @"w6jfqlRpGc9TiU2QVWLlN8EuJD/EFIjbkwwrcCv8Hj+smtzQ4oatKUNzwHVj1ZlsongozfuAO5SzwZhLMNR31w==";
            dictionaryTest.Rows.Add(dict);
            dict = dictionaryTest.NewRow();
            dict["Chave"] = @"YC2jxkvd";
            dict["SALT"] = @"b8ngLt3WHxaC648L";
            dict["WITHSALT"] = @"Vu+Z6AoHSszZ2rDrocC2CfvxT4RCZVw2Mfy/8HduMIOnocP4VvgmcQuD3BqKKFbnskh3xZFH2UJTrvau4oMZmA==";
            dictionaryTest.Rows.Add(dict);
            dict = dictionaryTest.NewRow();
            dict["Chave"] = @"9aKBzfEq";
            dict["SALT"] = @"b8ngLt3WHxaC648L";
            dict["WITHSALT"] = @"xuhyJjSftpb9wtgTFnWNjxzNMteamlHOE51p7kpPRRRwxOXOHtKRQZOkIIGFBfAOeHSyCGrAyMHc8+WruwhRqw==";
            dictionaryTest.Rows.Add(dict);
            dict = dictionaryTest.NewRow();
            dict["Chave"] = @"9YRm839z";
            dict["SALT"] = @"b8ngLt3WHxaC648L";
            dict["WITHSALT"] = @"MquSmgkyd1vFTG+SPafTe0SaRHUWjVQ+VfdBN0Fpe62QK1HJmouLvQyilotmjXvtUk5e4Bo0n2hFC7w/z3JCLg==";
            dictionaryTest.Rows.Add(dict);
            dict = dictionaryTest.NewRow();
            dict["Chave"] = @"XJkddfu9";
            dict["SALT"] = @"b8ngLt3WHxaC648L";
            dict["WITHSALT"] = @"8rYv5ic081PLDjKYgaDHExJ6BDtt/+JwEHwCwhrsIYTzj/6zczX3Oaxy9GE1HKhcpFxskIQ9BlfT+NCeElilSg==";
            dictionaryTest.Rows.Add(dict);
            dict = dictionaryTest.NewRow();
            dict["Chave"] = @"C2R2jCHM";
            dict["SALT"] = @"b8ngLt3WHxaC648L";
            dict["WITHSALT"] = @"f3f0ua8kgZvaJw5jmnmFG1r711sOuYxjMFA9DdMaUPHjmZ/Qgd+jV9e29dKg1nla1bUyoR6RjTSSrUpkj4aQ9A==";
            dictionaryTest.Rows.Add(dict);
            dict = dictionaryTest.NewRow();
            dict["Chave"] = @"p27H2fep";
            dict["SALT"] = @"tgMupPvRnTzWLNUr";
            dict["WITHSALT"] = @"0z/wJ6RzU5dY+8Au4JQPMSBrlhw6iCj8I76UNWhTJXJUdEW86xAVP/Sa/4D9OAHI/fdQvPIlmeKl+8yTy56urg==";
            dictionaryTest.Rows.Add(dict);
            dict = dictionaryTest.NewRow();
            dict["Chave"] = @"6mqcqW8S";
            dict["SALT"] = @"tgMupPvRnTzWLNUr";
            dict["WITHSALT"] = @"QPWiz9GoC6nxiL1fzjxKtNlrks4QLvcbQ1HD6JgqtIb9KRyTEPXn8uuFe6Xi3zbETY8ZTmV5WgMAWbYIYCmftw==";
            dictionaryTest.Rows.Add(dict);
            dict = dictionaryTest.NewRow();
            dict["Chave"] = @"BhD95MGB";
            dict["SALT"] = @"tgMupPvRnTzWLNUr";
            dict["WITHSALT"] = @"XlHc9zc2918fXDctXTFm426bR0nWCZLepD4De2O6CxlG4TWIyFHIGKy3XmcYOoiskZkcIbZBm53j5ts4EeowHg==";
            dictionaryTest.Rows.Add(dict);
            dict = dictionaryTest.NewRow();
            dict["Chave"] = @"TAYeSBck";
            dict["SALT"] = @"tgMupPvRnTzWLNUr";
            dict["WITHSALT"] = @"zwM9ilVMAQR/L/rjANKIGCTFaTa9u8N1mML3gfY8//u/Cp9ApCpIBdA6J3IUO6JL1hZsir+jf+JdIGWAPS2nKA==";
            dictionaryTest.Rows.Add(dict);
            dict = dictionaryTest.NewRow();
            dict["Chave"] = @"MtzKanvL";
            dict["SALT"] = @"tgMupPvRnTzWLNUr";
            dict["WITHSALT"] = @"ayscrzZ2CjIxfPuJe/ofQ154Q3ftreoSgPbDR2J3WUdotGogVjUaK1bmxA0bX+w2I03vEdkqZjSEqFDtXuXdnA==";
            dictionaryTest.Rows.Add(dict);
            dict = dictionaryTest.NewRow();
            dict["Chave"] = @"YC2jxkvd";
            dict["SALT"] = @"tgMupPvRnTzWLNUr";
            dict["WITHSALT"] = @"q9DLW/DD7j+kw0c75Vhkm3pE2slTjGlv1y4X8F7TG6jqV0c3uIjAUiwNAkM+tGQaISdg8OIuD6aEd43bGL4spQ==";
            dictionaryTest.Rows.Add(dict);
            dict = dictionaryTest.NewRow();
            dict["Chave"] = @"9aKBzfEq";
            dict["SALT"] = @"tgMupPvRnTzWLNUr";
            dict["WITHSALT"] = @"HFU6WIjBznejK7bZDbGHw9UVXzb8rRyFYo15gIXKWTvVWrvl5/D6dmPNrBMVTqyMXPHoHqM2jUHKEByRURSGpA==";
            dictionaryTest.Rows.Add(dict);
            dict = dictionaryTest.NewRow();
            dict["Chave"] = @"9YRm839z";
            dict["SALT"] = @"tgMupPvRnTzWLNUr";
            dict["WITHSALT"] = @"t4J2QXDgykHmOGtM9a4AnRlW/Wp5xXv/dD5yyH9PK8X5yrsnkGWICIvfNe3zQvVI+8J1NPEODgw7r8rqzml40Q==";
            dictionaryTest.Rows.Add(dict);
            dict = dictionaryTest.NewRow();
            dict["Chave"] = @"XJkddfu9";
            dict["SALT"] = @"tgMupPvRnTzWLNUr";
            dict["WITHSALT"] = @"5pU3qNi5zxq/rzx1wHMrOUhCub5RyS63PAA/EIflxhkAvgbLhn4uFzyxCRANoXtyHRGbyEpYxxdSPEXKbizrpg==";
            dictionaryTest.Rows.Add(dict);
            dict = dictionaryTest.NewRow();
            dict["Chave"] = @"C2R2jCHM";
            dict["SALT"] = @"tgMupPvRnTzWLNUr";
            dict["WITHSALT"] = @"OtEklcl+Z/xEapIHrtQOtQ//LpM0Q42HkVwmLrif/++bz3WNfjCRi3fj27HyV4ZPX8ARl79PRWVmd6HTxOC9lQ==";
            dictionaryTest.Rows.Add(dict);
            dict = dictionaryTest.NewRow();
            dict["Chave"] = @"p27H2fep";
            dict["SALT"] = @"FMJZJFAKNEVWCWCD";
            dict["WITHSALT"] = @"V46yARQyVqCukJdU5TbAl/bWBJgeAMfB7VJU9CT0UIriWowNax8Q6+6Ci+/nz5VEwLqR7f/bVxsOnhW/MCOuuQ==";
            dictionaryTest.Rows.Add(dict);
            dict = dictionaryTest.NewRow();
            dict["Chave"] = @"6mqcqW8S";
            dict["SALT"] = @"FMJZJFAKNEVWCWCD";
            dict["WITHSALT"] = @"+BLrXo4IFGjpoj5vOg2mcnyQN3hTtkWg4P/g0GtMsEUnSjkmSoK59BZEoJIFCm8pF37Eb8qj+x2N9XyTzTvH7Q==";
            dictionaryTest.Rows.Add(dict);
            dict = dictionaryTest.NewRow();
            dict["Chave"] = @"BhD95MGB";
            dict["SALT"] = @"FMJZJFAKNEVWCWCD";
            dict["WITHSALT"] = @"etczKYu8/2CO/Db1hE//0c2IVCqbzer087xvSsVImbLzzinoP0Lw8jsuydTlVhrV19v6zuuOqoxUEo0sfPivpg==";
            dictionaryTest.Rows.Add(dict);
            dict = dictionaryTest.NewRow();
            dict["Chave"] = @"TAYeSBck";
            dict["SALT"] = @"FMJZJFAKNEVWCWCD";
            dict["WITHSALT"] = @"vEKPX3Cnuzpc8R1S0AaUb8qwDmPcWJCC2Vcy/Du8+hz51FXw4TfJhukj1xe+w7nY6BVJw6+nRWwATwKfuZYnqg==";
            dictionaryTest.Rows.Add(dict);
            dict = dictionaryTest.NewRow();
            dict["Chave"] = @"MtzKanvL";
            dict["SALT"] = @"FMJZJFAKNEVWCWCD";
            dict["WITHSALT"] = @"N2GUh0qKsBLE/bTVskWwCYsQccuUlMz16yqlCPMIP7BAuDOB29YEH2Xp3vz8quem13FugcGA73aLvWbRndgvGw==";
            dictionaryTest.Rows.Add(dict);
            dict = dictionaryTest.NewRow();
            dict["Chave"] = @"YC2jxkvd";
            dict["SALT"] = @"FMJZJFAKNEVWCWCD";
            dict["WITHSALT"] = @"ZP+l2Ec5e3JCGLUQ7Ly+gzt1n4+WBKZaypSMnwEGLripSJOany08B4xUKlT71hCFxcvPzeOd6K0pB2ILgNi96Q==";
            dictionaryTest.Rows.Add(dict);
            dict = dictionaryTest.NewRow();
            dict["Chave"] = @"9aKBzfEq";
            dict["SALT"] = @"FMJZJFAKNEVWCWCD";
            dict["WITHSALT"] = @"uxRcbIE5m88NA4MUt7qhNyT0Ls9XDvSD5T/7URSYYNuIeAVzhLcUrWDCU9QRWJ0LxWVQlrvrJv9HbMcKUt/oxg==";
            dictionaryTest.Rows.Add(dict);
            dict = dictionaryTest.NewRow();
            dict["Chave"] = @"9YRm839z";
            dict["SALT"] = @"FMJZJFAKNEVWCWCD";
            dict["WITHSALT"] = @"I3c8tTiCdWTihfQK5aHNTGPM0xTzVs4dBqxjXhYIkqqxX1GPI2MiiYYN+yetfOg2YqrN5yMnQ7FWzQFBb3soVg==";
            dictionaryTest.Rows.Add(dict);
            dict = dictionaryTest.NewRow();
            dict["Chave"] = @"XJkddfu9";
            dict["SALT"] = @"FMJZJFAKNEVWCWCD";
            dict["WITHSALT"] = @"GWWpsN90JD40pnF/sb/r+qt+w7pc9si/RzHO8GF0popGLj5brq9CTTB6h0oOObKKtPtRBLHq2LntEJJfzufaRw==";
            dictionaryTest.Rows.Add(dict);
            dict = dictionaryTest.NewRow();
            dict["Chave"] = @"C2R2jCHM";
            dict["SALT"] = @"FMJZJFAKNEVWCWCD";
            dict["WITHSALT"] = @"qE6lZwrkG5PJ9UKWUV3wkE/XhKJpNgOo1YEBcA51I15Qu0MI5EdOCYr6iOuYBjPyI2mE/l9pkhQge8iHaC5Zxg==";
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
        public void GetTest()
        {
            foreach (DataRow row in dictionaryTest.Rows)
            {
                string _chave = (string)row["Chave"];
                string salt = (string)row["SALT"];
                ApplySalt applySalt = new ApplySalt(_chave, salt);

                Assert.AreEqual((string)row["WITHSALT"], applySalt.Get());

                TestContext.WriteLine($"[{_chave}, {salt}] : {applySalt.Get()}");

                for (int i = 1; i < 512; i++)
                {
                    TestContext.WriteLine("--");
                    TestContext.WriteLine(applySalt.Get(HashStringType.SHA1, 10, i));
                }
            }
        }
    }
}