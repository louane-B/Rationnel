using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class RationnelTests
{
    [TestMethod]
    public void TestAddition()
    {
        var r1 = new Rationnel { Numerateur = 1, Denominateur = 2 };
        var r2 = new Rationnel { Numerateur = 1, Denominateur = 3 };

        var resultat = r1.Ajouter(r2);

        Assert.AreEqual(5, resultat.Numerateur);
        Assert.AreEqual(6, resultat.Denominateur);
        Assert.IsInstanceOfType(resultat, typeof(Rationnel));
        Assert.IsNotNull(resultat);
    }

    [TestMethod]
    public void TestSoustraction()
    {
        var r1 = new Rationnel { Numerateur = 3, Denominateur = 4 };
        var r2 = new Rationnel { Numerateur = 1, Denominateur = 4 };

        var resultat = r1.Soustraire(r2);

        Assert.AreEqual(1, resultat.Numerateur);
        Assert.AreEqual(2, resultat.Denominateur);
        Assert.IsTrue(resultat.Numerateur < r1.Numerateur);
    }

    [TestMethod]
    public void TestMultiplication()
    {
        var r1 = new Rationnel { Numerateur = 2, Denominateur = 3 };
        var r2 = new Rationnel { Numerateur = 3, Denominateur = 4 };

        var resultat = r1.Multiplier(r2);

        Assert.AreEqual(1, resultat.Numerateur);
        Assert.AreEqual(2, resultat.Denominateur);
        Assert.IsNotSame(r1, resultat); // Vérifie que ce n’est pas le même objet
    }

    [TestMethod]
    public void TestDivision()
    {
        var r1 = new Rationnel { Numerateur = 2, Denominateur = 3 };
        var r2 = new Rationnel { Numerateur = 4, Denominateur = 5 };

        var resultat = r1.Diviser(r2);

        Assert.AreEqual(5, resultat.Numerateur);
        Assert.AreEqual(6, resultat.Denominateur);
    }

    [TestMethod]
    public void TestSimplificationIndirecte()
    {
        var r = new Rationnel { Numerateur = 6, Denominateur = 9 };
        var resultat = r.Multiplier(new Rationnel { Numerateur = 1, Denominateur = 1 });

        Assert.AreEqual(2, resultat.Numerateur);
        Assert.AreEqual(3, resultat.Denominateur);
    }

    [TestMethod]
    public void TestDivisionParZero()
    {
        var r1 = new Rationnel { Numerateur = 1, Denominateur = 2 };
        var r2 = new Rationnel { Numerateur = 0, Denominateur = 1 };

        Assert.ThrowsException<DivideByZeroException>(() =>
        {
            var resultat = r1.Diviser(r2);
        });
    }
}