using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Slowbro Specie to store common natural stats of all Slowbros
	#region SpecieSlowbro
	public class SpecieSlowbro : PokemonSpecie
	{
#nullable enable
		private static SpecieSlowbro? _instance = null;
#nullable restore
        public static SpecieSlowbro Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSlowbro();
                }
                return _instance;
            }
        }

		#region SpecieSlowbro Builder
		public SpecieSlowbro() : base(
			"Slowbro",
			1.6,
			78.5,
			95, // HPs
			75, 110, // Attack & Defense
			100, 80, // Special Attack & Defense
			30		
		)
		{}
		#endregion
	}
	#endregion

	//Slowbro Pokemon Class
	#region Slowbro
	public class Slowbro : Pokemon
	{
		#region Slowbro Builders
		/// <summary>
		/// Slowbro Builder waiting for a Nickname & a Level
		/// </summary>
		public Slowbro(string nickname, int level)
		: base(
				80,
				SpecieSlowbro.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Slowbro Builder only waiting for a Level
		/// </summary>
		public Slowbro(int level)
		: base(
				80,
				SpecieSlowbro.Instance, // Pokemon Specie
				"Slowbro", level,
				Water.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Slowbro Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Slowbro() : base(
			80,
			SpecieSlowbro.Instance, // Pokemon Specie
			Water.Instance, Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}