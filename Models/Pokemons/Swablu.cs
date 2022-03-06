using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Swablu Specie to store common natural stats of all Swablus
	#region SpecieSwablu
	public class SpecieSwablu : PokemonSpecie
	{
#nullable enable
		private static SpecieSwablu? _instance = null;
#nullable restore
        public static SpecieSwablu Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSwablu();
                }
                return _instance;
            }
        }

		#region SpecieSwablu Builder
		public SpecieSwablu() : base(
			"Swablu",
			0.4,
			1.2,
			45, // HPs
			40, 60, // Attack & Defense
			40, 75, // Special Attack & Defense
			50		
		)
		{}
		#endregion
	}
	#endregion

	//Swablu Pokemon Class
	#region Swablu
	public class Swablu : Pokemon
	{
		#region Swablu Builders
		/// <summary>
		/// Swablu Builder waiting for a Nickname & a Level
		/// </summary>
		public Swablu(string nickname, int level)
		: base(
				333,
				SpecieSwablu.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Swablu Builder only waiting for a Level
		/// </summary>
		public Swablu(int level)
		: base(
				333,
				SpecieSwablu.Instance, // Pokemon Specie
				"Swablu", level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Swablu Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Swablu() : base(
			333,
			SpecieSwablu.Instance, // Pokemon Specie
			Normal.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}