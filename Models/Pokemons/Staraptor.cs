using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Staraptor Specie to store common natural stats of all Staraptors
	#region SpecieStaraptor
	public class SpecieStaraptor : PokemonSpecie
	{
#nullable enable
		private static SpecieStaraptor? _instance = null;
#nullable restore
        public static SpecieStaraptor Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieStaraptor();
                }
                return _instance;
            }
        }

		#region SpecieStaraptor Builder
		public SpecieStaraptor() : base(
			"Staraptor",
			1.2,
			24.9,
			85, // HPs
			120, 70, // Attack & Defense
			50, 60, // Special Attack & Defense
			100		
		)
		{}
		#endregion
	}
	#endregion

	//Staraptor Pokemon Class
	#region Staraptor
	public class Staraptor : Pokemon
	{
		#region Staraptor Builders
		/// <summary>
		/// Staraptor Builder waiting for a Nickname & a Level
		/// </summary>
		public Staraptor(string nickname, int level)
		: base(
				398,
				SpecieStaraptor.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Staraptor Builder only waiting for a Level
		/// </summary>
		public Staraptor(int level)
		: base(
				398,
				SpecieStaraptor.Instance, // Pokemon Specie
				"Staraptor", level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Staraptor Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Staraptor() : base(
			398,
			SpecieStaraptor.Instance, // Pokemon Specie
			Normal.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}