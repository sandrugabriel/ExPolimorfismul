using ExPolimorfismul.Models;
using System;
using Xunit.Abstractions;

namespace TestPunct
{
    public class UnitTest1
    {
        private readonly ITestOutputHelper output;

        public UnitTest1(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void Testpunct()
        {

            Punct punct = new Punct(10, 5);
            Punct aux = new Punct(10,5);
            
          
            punct.translatare(5, 5);
            punct.duplicare();

            output.WriteLine(punct.ToString());
            output.WriteLine(punct.duplicare().ToString());
            punct.translatare(10, 5);
            output.WriteLine(punct.ToString());   

            Punct punct1 = new Punct(10, 5);
            punct.Equals(punct1);


            Assert.Equal($"Punct:\nx={punct.X}, y={punct.Y}",punct.ToString());//afisarea
            Assert.NotEqual(punct,aux);//translatarea
            Assert.False(punct.Equals(punct1));
            Assert.NotNull(punct.duplicare());

            Assert.Equal(punct, punct.duplicare());//duplicare
        }

        [Fact]
        public void TestLinie() {

            Punct punct1 = new Punct(10, 5);
            Punct punct2 = new Punct(15, 8);
            Linie linie = new Linie(punct1, punct2);
            Punct punct3 = new Punct(10, 5);
            Punct punct4 = new Punct(15, 8);
            Linie aux = new Linie(punct3,punct4);


            Assert.Equal("Linie:\n" + punct1 + "\n" + punct2, linie.ToString());//afisare
            linie.translatare(5, 5);
            Assert.NotEqual(linie, aux);//traducere
            Assert.Equal(linie, linie.duplicare());//duplicare
        }

        [Fact]
        public void TestCerc() { 
        
            Punct punct1 = new Punct(10, 5);
            Punct punct2 = new Punct(15, 9);
            Linie raza = new Linie(punct1, punct2);
            Cerc cerc = new Cerc(raza, punct1);

            Assert.Equal("Cerc:\nRaza:" + raza.ToString() + "\nPunctul:" + punct1.ToString(),cerc.ToString());//afisarea
            cerc.translatare(5, 0);
            Assert.NotEqual(cerc.Punct.X, 10);//translatare
            Assert.Equal(cerc,cerc.duplicare());//duplicare
            
        }

        [Fact]
        public void TestDreptunghi() {

            Punct punct1 = new Punct(10, 5);
            Punct punct2 = new Punct(15, 9);
            Dreptunghi dreptunghi = new Dreptunghi(punct1, punct2);

            Assert.Equal("Dreptunghi:\n" + punct1 + "\n" + punct2, dreptunghi.ToString());//traducere
            dreptunghi.translatare(0, 10);
            Assert.NotEqual(dreptunghi.Punct1.Y, 10);//translatare
            Assert.NotEqual(dreptunghi,dreptunghi.duplicare());//duplicare

        }

    }
}