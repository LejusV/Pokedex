using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Spiritomb Specie to store common natural stats of all Spiritombs
	#region SpecieSpiritomb
	public class SpecieSpiritomb : PokemonSpecie
	{
#nullable enable
		private static SpecieSpiritomb? _instance = null;
#nullable restore
        public static SpecieSpiritomb Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSpiritomb();
                }
                return _instance;
            }
        }

		#region SpecieSpiritomb Builder
		public SpecieSpiritomb() : base(
			"Spiritomb",
			50, // HPs
			92, 108, // Attack & Defense
			92, 108, // Special Attack & Defense
			35		
		)
		{
			this._height = 10;
			this._weight = 1080;
		}
		#endregion
	}
	#endregion

	//Spiritomb Pokemon Class
	#region Spiritomb
	public class Spiritomb : Pokemon
	{
		#region Spiritomb Builders
		/// <summary>
		/// Spiritomb Builder waiting for a Nickname & a Level
		/// </summary>
		public Spiritomb(string nickname, int level)
		: base(
				442,
				SpecieSpiritomb.Instance, // Pokemon Specie
				nickname, level,
				Ghost.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Spiritomb Builder only waiting for a Level
		/// </summary>
		public Spiritomb(int level)
		: base(
				442,
				SpecieSpiritomb.Instance, // Pokemon Specie
				"Spiritomb", level,
				Ghost.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Spiritomb Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Spiritomb() : base(
			442,
			SpecieSpiritomb.Instance, // Pokemon Specie
			Ghost.Instance, Dark.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}