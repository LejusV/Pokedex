using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Sliggoo Specie to store common natural stats of all Sliggoos
	#region SpecieSliggoo
	public class SpecieSliggoo : PokemonSpecie
	{
#nullable enable
		private static SpecieSliggoo? _instance = null;
#nullable restore
        public static SpecieSliggoo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSliggoo();
                }
                return _instance;
            }
        }

		#region SpecieSliggoo Builder
		public SpecieSliggoo() : base(
			"Sliggoo",
			68, // HPs
			75, 53, // Attack & Defense
			83, 113, // Special Attack & Defense
			60		
		)
		{
			this._height = 8;
			this._weight = 175;
		}
		#endregion
	}
	#endregion

	//Sliggoo Pokemon Class
	#region Sliggoo
	public class Sliggoo : Pokemon
	{
		#region Sliggoo Builders
		/// <summary>
		/// Sliggoo Builder waiting for a Nickname & a Level
		/// </summary>
		public Sliggoo(string nickname, int level)
		: base(
				705,
				SpecieSliggoo.Instance, // Pokemon Specie
				nickname, level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sliggoo Builder only waiting for a Level
		/// </summary>
		public Sliggoo(int level)
		: base(
				705,
				SpecieSliggoo.Instance, // Pokemon Specie
				"Sliggoo", level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sliggoo Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Sliggoo() : base(
			705,
			SpecieSliggoo.Instance, // Pokemon Specie
			Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}