using Pokedex.Models.Moves.Categories;

namespace Pokedex.Models.Pokemons
{
    class Squirtle : BlastoiseFamily
    {
        public void LevelCheck()
        {
            if (!this._moves.Contains(Tackle.Instance)) this.AddMove(Tackle.Instance);
            
            if (_level >= 4) 
            {
                if (!this._moves.Contains(TailWhip.Instance)) this.AddMove(TailWhip.Instance);

                if (_level >= 7) 
                {
                    if (!this._moves.Contains(Bubble.Instance)) this.AddMove(Bubble.Instance);

                    if (_level >= 10)
                    {
                        if (!this._moves.Contains(Withdraw.Instance)) this.AddMove(Withdraw.Instance);

                        if (_level >= 13)
                        {
                            if (!this._moves.Contains(WaterGun.Instance)) this.AddMove(WaterGun.Instance);

                            if (_level >= 19)
                            {
                                if (!this._moves.Contains(RapidSpin.Instance)) this.AddMove(RapidSpin.Instance);

                                if (_level >= 22)
                                {
                                    //if (!this._moves.Contains(MOVE.Instance)) this.AddMove(MOVE.Instance);

                                    if (_level >= 25)
                                    {
                                        if (!this._moves.Contains(WaterPulse.Instance)) this.AddMove(WaterPulse.Instance);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public Squirtle(string nickname = "Squirtle", int? level = null) : base(7, nickname, "Squirtle", level)
        {
            this._natural_fixed_stats = new PokemonStats(44, 48, 65, 50, 64, 43);
            CalculateStats();
            LevelCheck();
        }
    }
}
