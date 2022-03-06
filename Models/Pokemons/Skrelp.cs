using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Skrelp Specie to store common natural stats of all Skrelps
	#region SpecieSkrelp
	public class SpecieSkrelp : PokemonSpecie
	{
#nullable enable
		private static SpecieSkrelp? _instance = null;
#nullable restore
        public static SpecieSkrelp Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSkrelp();
                }
                return _instance;
            }
        }

		#region SpecieSkrelp Builder
		public SpecieSkrelp() : base(
			"Skrelp",
			0.5,
			7.3,
			50, // HPs
			60, 60, // Attack & Defense
			60, 60, // Special Attack & Defense
			30		
		)
		{}
		#endregion
	}
	#endregion

	//Skrelp Pokemon Class
	#region Skrelp
	public class Skrelp : Pokemon
	{
		#region Skrelp Builders
		/// <summary>
		/// Skrelp Builder waiting for a Nickname & a Level
		/// </summary>
		public Skrelp(string nickname, int level)
		: base(
				690,
				SpecieSkrelp.Instance, // Pokemon Specie
				nickname, level,
				Poison.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Skrelp Builder only waiting for a Level
		/// </summary>
		public Skrelp(int level)
		: base(
				690,
				SpecieSkrelp.Instance, // Pokemon Specie
				"Skrelp", level,
				Poison.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Skrelp Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Skrelp() : base(
			690,
			SpecieSkrelp.Instance, // Pokemon Specie
			Poison.Instance, Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}