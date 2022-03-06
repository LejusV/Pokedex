using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Slaking Specie to store common natural stats of all Slakings
	#region SpecieSlaking
	public class SpecieSlaking : PokemonSpecie
	{
#nullable enable
		private static SpecieSlaking? _instance = null;
#nullable restore
        public static SpecieSlaking Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSlaking();
                }
                return _instance;
            }
        }

		#region SpecieSlaking Builder
		public SpecieSlaking() : base(
			"Slaking",
			2.0,
			130.5,
			150, // HPs
			160, 100, // Attack & Defense
			95, 65, // Special Attack & Defense
			100		
		)
		{}
		#endregion
	}
	#endregion

	//Slaking Pokemon Class
	#region Slaking
	public class Slaking : Pokemon
	{
		#region Slaking Builders
		/// <summary>
		/// Slaking Builder waiting for a Nickname & a Level
		/// </summary>
		public Slaking(string nickname, int level)
		: base(
				289,
				SpecieSlaking.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Slaking Builder only waiting for a Level
		/// </summary>
		public Slaking(int level)
		: base(
				289,
				SpecieSlaking.Instance, // Pokemon Specie
				"Slaking", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Slaking Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Slaking() : base(
			289,
			SpecieSlaking.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}