using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Shroomish Specie to store common natural stats of all Shroomishs
	#region SpecieShroomish
	public class SpecieShroomish : PokemonSpecie
	{
#nullable enable
		private static SpecieShroomish? _instance = null;
#nullable restore
        public static SpecieShroomish Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieShroomish();
                }
                return _instance;
            }
        }

		#region SpecieShroomish Builder
		public SpecieShroomish() : base(
			"Shroomish",
			60, // HPs
			40, 60, // Attack & Defense
			40, 60, // Special Attack & Defense
			35		
		)
		{
			this._height = 4;
			this._weight = 45;
		}
		#endregion
	}
	#endregion

	//Shroomish Pokemon Class
	#region Shroomish
	public class Shroomish : Pokemon
	{
		#region Shroomish Builders
		/// <summary>
		/// Shroomish Builder waiting for a Nickname & a Level
		/// </summary>
		public Shroomish(string nickname, int level)
		: base(
				285,
				SpecieShroomish.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shroomish Builder only waiting for a Level
		/// </summary>
		public Shroomish(int level)
		: base(
				285,
				SpecieShroomish.Instance, // Pokemon Specie
				"Shroomish", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shroomish Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Shroomish() : base(
			285,
			SpecieShroomish.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}