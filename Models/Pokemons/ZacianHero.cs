using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Zacian-Hero Specie to store common natural stats of all Zacian-Heros
	#region SpecieZacian-Hero
	public class SpecieZacianHero : PokemonSpecie
	{
#nullable enable
		private static SpecieZacianHero? _instance = null;
#nullable restore
        public static SpecieZacianHero Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieZacianHero();
                }
                return _instance;
            }
        }

		#region SpecieZacian-Hero Builder
		public SpecieZacianHero() : base(
			"Zacian-Hero",
			92, // HPs
			130, 115, // Attack & Defense
			80, 115, // Special Attack & Defense
			138		
		)
		{
			this._height = 28;
			this._weight = 1100;
		}
		#endregion
	}
	#endregion

	//Zacian-Hero Pokemon Class
	#region Zacian-Hero
	public class ZacianHero : Pokemon
	{
		#region Zacian-Hero Builders
		/// <summary>
		/// Zacian-Hero Builder waiting for a Nickname & a Level
		/// </summary>
		public ZacianHero(string nickname, int level)
		: base(
				888,
				SpecieZacianHero.Instance, // Pokemon Specie
				nickname, level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zacian-Hero Builder only waiting for a Level
		/// </summary>
		public ZacianHero(int level)
		: base(
				888,
				SpecieZacianHero.Instance, // Pokemon Specie
				"Zacian-Hero", level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zacian-Hero Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public ZacianHero() : base(
			888,
			SpecieZacianHero.Instance, // Pokemon Specie
			Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}