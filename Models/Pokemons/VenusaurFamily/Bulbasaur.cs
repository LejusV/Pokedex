using Pokedex.Models.Moves.Categories;

namespace Pokedex.Models.Pokemons
{
    internal class Bulbasaur : VenusaurFamily
    {
        public void LevelCheck()
        {
            if (!this._moves.Contains(Tackle.Instance)) this.AddMove(Tackle.Instance);
            if (_level >= 3) 
            {
                if (!this._moves.Contains(Growl.Instance)) this.AddMove(Growl.Instance);

                if (_level >= 7) 
                {
                    if (!this._moves.Contains(LeechSeed.Instance)) this.AddMove(LeechSeed.Instance);

                    if (_level >= 9) 
                    {
                        if (!this._moves.Contains(VineWhip.Instance)) this.AddMove(VineWhip.Instance);

                        if (_level >= 13)
                        {
                            if (!this._moves.Contains(PoisonPowder.Instance)) this.AddMove(PoisonPowder.Instance);
                            if (!this._moves.Contains(SleepPowder.Instance)) this.AddMove(SleepPowder.Instance);
                        }

                    }
                }
            }
        }

        public Bulbasaur(string nickname = "Bulbasaur", int? level = null) : base(1, nickname, nickname, level)
        {
            this._natural_fixed_stats = new PokemonStats(45, 49, 49, 65, 65, 45);
            CalculateStats();
            LevelCheck();

        }
    }
}
