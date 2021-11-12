using NUnit.Framework;

namespace TestGreatHello.Tests
{
    public class GreetHelloTests
    {
        private IGreetHello _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new Greet();
        }

        [Test]
        public void Should_Send_Me_Hello_By_Name()
        {
            var actual = _sut.GreetHello("Gino"); 
            Assert.AreEqual("Hello, Gino.", actual);
            Assert.Pass("ho salutato");
        }

        [Test]
        public void Should_Send_Me_Hello_My_Friend()
        {
            var actual = _sut.GreetHello(null);
            Assert.AreEqual("Hello, my friend.", actual);
            Assert.Pass("ti ho salutato ma non ti conosco");
        }

        [Test]
        public void Should_Send_Me_Hello_By_Uppercase()
        {
            var actual = _sut.GreetHello("IGOR");
            Assert.AreEqual("HELLO IGOR!", actual);
            Assert.Pass("ti ho salutato urlando");
        }

        [Test]
        public void Should_Send_Me_Hello_To_Two_Names()
        {
            var actual = _sut.GreetHello("Oussama", "Nicola");
            Assert.AreEqual("Hello, Oussama and Nicola." , actual);
            Assert.Pass("vi ho salutato entrambi");
        }

        [Test]
        public void Should_Send_Me_Hello_To_More_Than_Two_Names()
        {
            var actual = _sut.GreetHello("Gino", "Pino" , "Lino", "Rino");
            Assert.AreEqual("Hello, Gino, Pino, Lino and Rino.", actual);
            Assert.Pass("vi ho salutato tutti");
        }

        [Test]
        public void Should_Send_Me_Hello_To_More_Than_Two_Names_Screaming()
        {
            var actual = _sut.GreetHello("Amy", "BRIAN", "Charlotte");
            Assert.AreEqual("Hello, Amy and Charlotte. AND HELLO BRIAN!", actual);
            Assert.Pass("vi ho salutato tutti, anche urlando");
        }

        [Test]
        public void Should_Send_Me_Hello_To_More_Than_Two_Names_With_Comma()
        {
            var actual = _sut.GreetHello("Bob", "Charlie,Dianne");
            Assert.AreEqual("Hello, Bob, Charlie and Dianne.", actual);
            Assert.Pass("vi ho salutato tutti, anche in coppia");
        }
        [Test]
        public void Should_Send_Me_Last(){
            var actual = _sut.GreetHello("Bob", "\"Charlie, Dianne\"");
            Assert.AreEqual("Hello, Bob and Charlie, Dianne.", actual);
            Assert.Pass("Fine dei saluti");
        }


    }
}