
/// <summary>
/// Namespace de l'application.
/// </summary>
namespace CalculatriceRationnel
{
    /// <summary>
    /// Classe représentant un rationnel.
    /// </summary>
    public class Rationnel
    {
        /// <summary>
        /// Attribut représentant le numérateur.
        /// </summary>
        private int numerateur;
        /// <summary>
        /// Propriété permettant d'accéder et de modifier le numérateur.
        /// </summary>
        public int Numerateur {
            get { return numerateur; }
            set {
                    if (value >= 0)
                        numerateur = value;
                    else
                        numerateur = 1;
                }
        }

        /// <summary>
        /// Attribut représentant le dénominateur.
        /// </summary>
        public int denominateur;
        /// <summary>
        /// Propriété permettant d'accéder et de modifier le dénominateur.
        /// </summary>
        public int Denominateur
        {
            get { return denominateur; }
            set
            {
                if (value > 0)
                    denominateur = value;
                else
                    denominateur = 1;
            }
        }

        /// <summary>
        /// Constructeur par défaut.
        /// </summary>
        public Rationnel()
        {
            Numerateur = 1;
            Denominateur = 1;
        }

        /// <summary>
        /// Constructeur avec paramètres.
        /// </summary>
        /// <param name="unNumerateur">Paramètre contenant la valeur du numérateur.</param>
        /// <param name="unDenominateur">Paramètre contenant la valeur du dénominateur.</param>
        public Rationnel(int unNumerateur, int unDenominateur)
        {
            Numerateur = unNumerateur;
            Denominateur = unDenominateur;
        }

        /// <summary>
        /// Méthode de service permettant d'additionner deux rationnels.
        /// </summary>
        /// <param name="rationnel">Paramètre contenant le rationnel à ajouter.</param>
        /// <returns>Rationnel résultat de l'addition.</returns>
        public Rationnel Ajouter(Rationnel rationnel)
        {
            Rationnel unRationnel = new Rationnel();
            unRationnel.Numerateur = (Numerateur * rationnel.Denominateur) + (Denominateur * rationnel.Numerateur);
            unRationnel.Denominateur = (Denominateur * rationnel.Denominateur);
            unRationnel.Simplifier();
            return unRationnel;
        }

         /// <summary>
        /// Méthode de service permettant de simplifier un rationnel.
        /// </summary>
        private void Simplifier()
        {
            int X;
            int diviseur = 0;
            X = (Numerateur > Denominateur ? Numerateur : Denominateur);
            for (int i = 1; i <= X; i++)
                if (Numerateur % i == 0)
                    if (Denominateur % i == 0)
                        diviseur = i;
            Numerateur = Numerateur / diviseur;
            Denominateur = Denominateur / diviseur;

        }

        /// <summary>
        /// Méthode de service permettant de soustraire deux rationnels.
        /// </summary>
        /// <param name="rationnel">Paramètre contenant le rationnel à soustraire.</param>
        /// <returns>Rationnel résultat de la soustraction.</returns>
        public Rationnel Soustraire(Rationnel rationnel)
        {
             Rationnel unRationnel = new Rationnel();
            unRationnel.Numerateur = (Numerateur * rationnel.Denominateur) - (Denominateur * rationnel.Numerateur);
            unRationnel.Denominateur = (Denominateur * rationnel.Denominateur);
            unRationnel.Simplifier();
            return unRationnel;

        }

        /// <summary>
        /// Méthode de service permettant de multiplier deux rationnels.
        /// </summary>
        /// <param name="rationnel">Paramètre contenant le rationnel à multiplier.</param>
        /// <returns>Rationnel résultat de la multiplication.</returns>
        public Rationnel Multiplier(Rationnel rationnel)
        {
             Rationnel unRationnel = new Rationnel();
            unRationnel.Numerateur = (Numerateur * rationnel.Numerateur);
            unRationnel.Denominateur = (Denominateur * rationnel.Denominateur);
            unRationnel.Simplifier();
            return unRationnel;

        }

        /// <summary>
        /// Méthode de service permettant de diviser deux rationnels.
        /// </summary>
        /// <param name="rationnel">Paramètre contenant le rationnel à diviser.</param>
        /// <returns>Rationnel résultat de la division.</returns>
        public Rationnel Diviser(Rationnel rationnel)
        {
          Rationnel unRationnel = new Rationnel();
            unRationnel.Numerateur = (Numerateur * rationnel.Denominateur);
            unRationnel.Denominateur = (Denominateur * rationnel.Numerateur);
            unRationnel.Simplifier();
            return unRationnel;

        }
    }
}