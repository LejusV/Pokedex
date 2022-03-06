using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Silvally Specie to store common natural stats of all Silvallys
	#region SpecieSilvally
	public class SpecieSilvally : PokemonSpecie
	{
#nullable enable
		private static SpecieSilvally? _instance = null;
#nullable restore
        public static SpecieSilvally Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSilvally();
                }
                return _instance;
            }
        }

		#region SpecieSilvally Builder
		public SpecieSilvally() : base(
			"Silvally",
			2.3,
			100.5,
			95, // HPs
			95, 95, // Attack & Defense
			95, 95, // Special Attack & Defense
			95		
		)
		{}
		#endregion
	}
	#endregion

	//Silvally Pokemon Class
	#region Silvally
	public class Silvally : Pokemon
	{
		#region Silvally Builders
		/// <summary>
		/// Silvally Builder waiting for a Nickname & a Level
		/// </summary>
		public Silvally(string nickname, int level)
		: base(
				773,
				SpecieSilvally.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Silvally Builder only waiting for a Level
		/// </summary>
		public Silvally(int level)
		: base(
				773,
				SpecieSilvally.Instance, // Pokemon Specie
				"Silvally", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Silvally Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Silvally() : base(
			773,
			SpecieSilvally.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}