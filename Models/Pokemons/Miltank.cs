using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Miltank Specie to store common natural stats of all Miltanks
	#region SpecieMiltank
	public class SpecieMiltank : PokemonSpecie
	{
#nullable enable
		private static SpecieMiltank? _instance = null;
#nullable restore
        public static SpecieMiltank Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMiltank();
                }
                return _instance;
            }
        }

		#region SpecieMiltank Builder
		public SpecieMiltank() : base(
			"Miltank",
			1.2,
			75.5,
			95, // HPs
			80, 105, // Attack & Defense
			40, 70, // Special Attack & Defense
			100		
		)
		{}
		#endregion
	}
	#endregion

	//Miltank Pokemon Class
	#region Miltank
	public class Miltank : Pokemon
	{
		#region Miltank Builders
		/// <summary>
		/// Miltank Builder waiting for a Nickname & a Level
		/// </summary>
		public Miltank(string nickname, int level)
		: base(
				241,
				SpecieMiltank.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Miltank Builder only waiting for a Level
		/// </summary>
		public Miltank(int level)
		: base(
				241,
				SpecieMiltank.Instance, // Pokemon Specie
				"Miltank", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Miltank Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Miltank() : base(
			241,
			SpecieMiltank.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}