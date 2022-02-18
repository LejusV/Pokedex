using Pokedex.Models.Moves.Categories;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
    internal class Charmander : CharizardFamily
    {
        public void LevelCheck()
        {
            if (!this._moves.Contains(Scratch.Instance)) this.AddMove(Scratch.Instance);
            if (!this._moves.Contains(Growl.Instance)) this.AddMove(Growl.Instance);
            
            if (_level >= 7) 
            {
                if (!this._moves.Contains(Ember.Instance)) this.AddMove(Ember.Instance);

                if (_level >= 10) 
                {
                    if (!this._moves.Contains(Smokescreen.Instance)) this.AddMove(Smokescreen.Instance);

                    if (_level >= 16)
                    {
                        //if (!this._moves.Contains([MOVE].Instance)) this.AddMove([MOVE].Instance);

                        if (_level >= 19)
                        {
                            if (!this._moves.Contains(ScaryFace.Instance)) this.AddMove(ScaryFace.Instance);

                            if (_level >= 25)
                            {
                                if (!this._moves.Contains(FireFang.Instance)) this.AddMove(FireFang.Instance);
                            }
                        }
                    }
                }
            }
        }
        public Charmander(string nickname = "Charmander", int? level= null) : base(4, nickname, nickname, level, Fire.Instance)
        {
            this._natural_fixed_stats = new PokemonStats(39, 52, 43, 60, 50, 65);
            CalculateStats();
            LevelCheck();
        }
    }
}
