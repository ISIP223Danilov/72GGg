using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static _72GGg.fynkcya;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
           string text = "david is the best potato in the second world war";
           string text2 = "qnvq vf gur orfg cbgngb va gur frpbaq jbeyq jne";
           Assert.AreEqual(text, Rot13(text2));
           
        }
    }
}
/*
 * [Test]
public void TestCaesarEncryptDecrypt()
{
string original = &quot;Поддержка и тестирование программных модулей&quot;;
int shift = 5;
string encrypted = CaesarCipher.Encrypt(original, shift);
string decrypted = CaesarCipher.Decrypt(encrypted, shift);
Assert.AreEqual(original, decrypted);
Assert.AreNotEqual(original, encrypted);
}*/