using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Bulbasaur Specie to store common natural stats of all Bulbasaurs
	#region SpecieBulbasaur
	public class SpecieBulbasaur : PokemonSpecie
	{
#nullable enable
		private static SpecieBulbasaur? _instance = null;
#nullable restore
        public static SpecieBulbasaur Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBulbasaur();
                }
                return _instance;
            }
        }

		#region SpecieBulbasaur Builder
		public SpecieBulbasaur() : base(
			"Bulbasaur",
			45, // HPs
			49, 49, // Attack & Defense
			65, 65, // Special Attack & Defense
			45		
		)
		{
			this._height = 7;
			this._weight = 69;
		}
		#endregion
	}
	#endregion

	//Bulbasaur Pokemon Class
	#region Bulbasaur
	public class Bulbasaur : Pokemon
	{
		#region Bulbasaur Builders
		/// <summary>
		/// Bulbasaur Builder waiting for a Nickname & a Level
		/// </summary>
		public Bulbasaur(string nickname, int level)
		: base(
				1,
				SpecieBulbasaur.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bulbasaur Builder only waiting for a Level
		/// </summary>
		public Bulbasaur(int level)
		: base(
				1,
				SpecieBulbasaur.Instance, // Pokemon Specie
				"Bulbasaur", level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bulbasaur Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Bulbasaur() : base(
			1,
			SpecieBulbasaur.Instance, // Pokemon Specie
			Grass.Instance, Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}