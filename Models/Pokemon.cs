namespace Pokedex.Models
{
    internal class Pokemon
    {
        private string p_cry;
        private string p_name;

        public string Name
        {
            get { return p_name; }
        }

        public Pokemon(string n)
        {
            this.p_cry = string.Empty;
            this.p_name = n;
        }

        public override string ToString()
        {
            return string.Format("My name is {0}", this.p_name);
        }
    }
}
