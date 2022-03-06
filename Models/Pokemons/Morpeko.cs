using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Morpeko Specie to store common natural stats of all Morpekos
	#region SpecieMorpeko
	public class SpecieMorpeko : PokemonSpecie
	{
#nullable enable
		private static SpecieMorpeko? _instance = null;
#nullable restore
        public static SpecieMorpeko Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMorpeko();
                }
                return _instance;
            }
        }

		#region SpecieMorpeko Builder
		public SpecieMorpeko() : base(
			"Morpeko",
			58, // HPs
			95, 58, // Attack & Defense
			70, 58, // Special Attack & Defense
			97		
		)
		{
			this._height = 3;
			this._weight = 30;
		}
		#endregion
	}
	#endregion

	//Morpeko Pokemon Class
	#region Morpeko
	public class Morpeko : Pokemon
	{
		#region Morpeko Builders
		/// <summary>
		/// Morpeko Builder waiting for a Nickname & a Level
		/// </summary>
		public Morpeko(string nickname, int level)
		: base(
				877,
				SpecieMorpeko.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Morpeko Builder only waiting for a Level
		/// </summary>
		public Morpeko(int level)
		: base(
				877,
				SpecieMorpeko.Instance, // Pokemon Specie
				"Morpeko", level,
				Electric.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Morpeko Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Morpeko() : base(
			877,
			SpecieMorpeko.Instance, // Pokemon Specie
			Electric.Instance, Dark.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}