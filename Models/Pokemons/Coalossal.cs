using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Coalossal Specie to store common natural stats of all Coalossals
	#region SpecieCoalossal
	public class SpecieCoalossal : PokemonSpecie
	{
#nullable enable
		private static SpecieCoalossal? _instance = null;
#nullable restore
        public static SpecieCoalossal Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCoalossal();
                }
                return _instance;
            }
        }

		#region SpecieCoalossal Builder
		public SpecieCoalossal() : base(
			"Coalossal",
			2.8,
			310.5,
			110, // HPs
			80, 120, // Attack & Defense
			80, 90, // Special Attack & Defense
			30		
		)
		{}
		#endregion
	}
	#endregion

	//Coalossal Pokemon Class
	#region Coalossal
	public class Coalossal : Pokemon
	{
		#region Coalossal Builders
		/// <summary>
		/// Coalossal Builder waiting for a Nickname & a Level
		/// </summary>
		public Coalossal(string nickname, int level)
		: base(
				839,
				SpecieCoalossal.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Coalossal Builder only waiting for a Level
		/// </summary>
		public Coalossal(int level)
		: base(
				839,
				SpecieCoalossal.Instance, // Pokemon Specie
				"Coalossal", level,
				Rock.Instance, Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Coalossal Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Coalossal() : base(
			839,
			SpecieCoalossal.Instance, // Pokemon Specie
			Rock.Instance, Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}