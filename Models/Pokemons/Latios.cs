using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Latios Specie to store common natural stats of all Latioss
	#region SpecieLatios
	public class SpecieLatios : PokemonSpecie
	{
#nullable enable
		private static SpecieLatios? _instance = null;
#nullable restore
        public static SpecieLatios Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLatios();
                }
                return _instance;
            }
        }

		#region SpecieLatios Builder
		public SpecieLatios() : base(
			"Latios",
			80, // HPs
			90, 80, // Attack & Defense
			130, 110, // Special Attack & Defense
			110		
		)
		{
			this._height = 20;
			this._weight = 600;
		}
		#endregion
	}
	#endregion

	//Latios Pokemon Class
	#region Latios
	public class Latios : Pokemon
	{
		#region Latios Builders
		/// <summary>
		/// Latios Builder waiting for a Nickname & a Level
		/// </summary>
		public Latios(string nickname, int level)
		: base(
				381,
				SpecieLatios.Instance, // Pokemon Specie
				nickname, level,
				Dragon.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Latios Builder only waiting for a Level
		/// </summary>
		public Latios(int level)
		: base(
				381,
				SpecieLatios.Instance, // Pokemon Specie
				"Latios", level,
				Dragon.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Latios Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Latios() : base(
			381,
			SpecieLatios.Instance, // Pokemon Specie
			Dragon.Instance, Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}