namespace Ispit.Model
{
    internal class Proizvod
    {
        public int ProizvodID { get; set; }

        public string Naziv {  get; set; }

       public Proizvod(int proizvodID, string naziv)
        {
            ProizvodID = proizvodID;
            Naziv = naziv;
        }
    }
}
