namespace LegyenOnIsMilliomos
{
    internal class Millio
    {
        public string Kerdes;
        public string A;
        public string B;
        public string C;
        public string D;
        public string HelyesValasz;

        public Millio (string sor)
        {
            var dbok = sor.Split(";");
            this.Kerdes = dbok[0];
            this.A = dbok[1];
            this.B = dbok[2];
            this.C = dbok[3];
            this.D = dbok[4];
            this.HelyesValasz = dbok[5];
        }
    }
}