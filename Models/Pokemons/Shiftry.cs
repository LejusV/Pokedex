using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Shiftry Specie to store common natural stats of all Shiftrys
	#region SpecieShiftry
	public class SpecieShiftry : PokemonSpecie
	{
#nullable enable
		private static SpecieShiftry? _instance = null;
#nullable restore
        public static SpecieShiftry Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieShiftry();
                }
                return _instance;
            }
        }

		#region SpecieShiftry Builder
		public SpecieShiftry() : base(
			"Shiftry",
			1.3,
			59.6,
			90, // HPs
			100, 60, // Attack & Defense
			90, 60, // Special Attack & Defense
			80		
		)
		{}
		#endregion
	}
	#endregion

	//Shiftry Pokemon Class
	#region Shiftry
	public class Shiftry : Pokemon
	{
		#region Shiftry Builders
		/// <summary>
		/// Shiftry Builder waiting for a Nickname & a Level
		/// </summary>
		public Shiftry(string nickname, int level)
		: base(
				275,
				SpecieShiftry.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shiftry Builder only waiting for a Level
		/// </summary>
		public Shiftry(int level)
		: base(
				275,
				SpecieShiftry.Instance, // Pokemon Specie
				"Shiftry", level,
				Grass.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shiftry Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Shiftry() : base(
			275,
			SpecieShiftry.Instance, // Pokemon Specie
			Grass.Instance, Dark.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}