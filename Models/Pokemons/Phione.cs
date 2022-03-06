using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Phione Specie to store common natural stats of all Phiones
	#region SpeciePhione
	public class SpeciePhione : PokemonSpecie
	{
#nullable enable
		private static SpeciePhione? _instance = null;
#nullable restore
        public static SpeciePhione Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePhione();
                }
                return _instance;
            }
        }

		#region SpeciePhione Builder
		public SpeciePhione() : base(
			"Phione",
			0.4,
			3.1,
			80, // HPs
			80, 80, // Attack & Defense
			80, 80, // Special Attack & Defense
			80		
		)
		{}
		#endregion
	}
	#endregion

	//Phione Pokemon Class
	#region Phione
	public class Phione : Pokemon
	{
		#region Phione Builders
		/// <summary>
		/// Phione Builder waiting for a Nickname & a Level
		/// </summary>
		public Phione(string nickname, int level)
		: base(
				489,
				SpeciePhione.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Phione Builder only waiting for a Level
		/// </summary>
		public Phione(int level)
		: base(
				489,
				SpeciePhione.Instance, // Pokemon Specie
				"Phione", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Phione Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Phione() : base(
			489,
			SpeciePhione.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}