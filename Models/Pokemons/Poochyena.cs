using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Poochyena Specie to store common natural stats of all Poochyenas
	#region SpeciePoochyena
	public class SpeciePoochyena : PokemonSpecie
	{
#nullable enable
		private static SpeciePoochyena? _instance = null;
#nullable restore
        public static SpeciePoochyena Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePoochyena();
                }
                return _instance;
            }
        }

		#region SpeciePoochyena Builder
		public SpeciePoochyena() : base(
			"Poochyena",
			0.5,
			13.6,
			35, // HPs
			55, 35, // Attack & Defense
			30, 30, // Special Attack & Defense
			35		
		)
		{}
		#endregion
	}
	#endregion

	//Poochyena Pokemon Class
	#region Poochyena
	public class Poochyena : Pokemon
	{
		#region Poochyena Builders
		/// <summary>
		/// Poochyena Builder waiting for a Nickname & a Level
		/// </summary>
		public Poochyena(string nickname, int level)
		: base(
				261,
				SpeciePoochyena.Instance, // Pokemon Specie
				nickname, level,
				Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Poochyena Builder only waiting for a Level
		/// </summary>
		public Poochyena(int level)
		: base(
				261,
				SpeciePoochyena.Instance, // Pokemon Specie
				"Poochyena", level,
				Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Poochyena Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Poochyena() : base(
			261,
			SpeciePoochyena.Instance, // Pokemon Specie
			Dark.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}