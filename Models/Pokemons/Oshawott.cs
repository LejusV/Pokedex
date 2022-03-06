using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Oshawott Specie to store common natural stats of all Oshawotts
	#region SpecieOshawott
	public class SpecieOshawott : PokemonSpecie
	{
#nullable enable
		private static SpecieOshawott? _instance = null;
#nullable restore
        public static SpecieOshawott Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieOshawott();
                }
                return _instance;
            }
        }

		#region SpecieOshawott Builder
		public SpecieOshawott() : base(
			"Oshawott",
			0.5,
			5.9,
			55, // HPs
			55, 45, // Attack & Defense
			63, 45, // Special Attack & Defense
			45		
		)
		{}
		#endregion
	}
	#endregion

	//Oshawott Pokemon Class
	#region Oshawott
	public class Oshawott : Pokemon
	{
		#region Oshawott Builders
		/// <summary>
		/// Oshawott Builder waiting for a Nickname & a Level
		/// </summary>
		public Oshawott(string nickname, int level)
		: base(
				501,
				SpecieOshawott.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Oshawott Builder only waiting for a Level
		/// </summary>
		public Oshawott(int level)
		: base(
				501,
				SpecieOshawott.Instance, // Pokemon Specie
				"Oshawott", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Oshawott Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Oshawott() : base(
			501,
			SpecieOshawott.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}