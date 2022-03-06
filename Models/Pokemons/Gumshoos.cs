using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Gumshoos Specie to store common natural stats of all Gumshooss
	#region SpecieGumshoos
	public class SpecieGumshoos : PokemonSpecie
	{
#nullable enable
		private static SpecieGumshoos? _instance = null;
#nullable restore
        public static SpecieGumshoos Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGumshoos();
                }
                return _instance;
            }
        }

		#region SpecieGumshoos Builder
		public SpecieGumshoos() : base(
			"Gumshoos",
			88, // HPs
			110, 60, // Attack & Defense
			55, 60, // Special Attack & Defense
			45		
		)
		{
			this._height = 7;
			this._weight = 142;
		}
		#endregion
	}
	#endregion

	//Gumshoos Pokemon Class
	#region Gumshoos
	public class Gumshoos : Pokemon
	{
		#region Gumshoos Builders
		/// <summary>
		/// Gumshoos Builder waiting for a Nickname & a Level
		/// </summary>
		public Gumshoos(string nickname, int level)
		: base(
				735,
				SpecieGumshoos.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gumshoos Builder only waiting for a Level
		/// </summary>
		public Gumshoos(int level)
		: base(
				735,
				SpecieGumshoos.Instance, // Pokemon Specie
				"Gumshoos", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gumshoos Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Gumshoos() : base(
			735,
			SpecieGumshoos.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}