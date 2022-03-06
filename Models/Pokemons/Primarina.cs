using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Primarina Specie to store common natural stats of all Primarinas
	#region SpeciePrimarina
	public class SpeciePrimarina : PokemonSpecie
	{
#nullable enable
		private static SpeciePrimarina? _instance = null;
#nullable restore
        public static SpeciePrimarina Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePrimarina();
                }
                return _instance;
            }
        }

		#region SpeciePrimarina Builder
		public SpeciePrimarina() : base(
			"Primarina",
			80, // HPs
			74, 74, // Attack & Defense
			126, 116, // Special Attack & Defense
			60		
		)
		{
			this._height = 18;
			this._weight = 440;
		}
		#endregion
	}
	#endregion

	//Primarina Pokemon Class
	#region Primarina
	public class Primarina : Pokemon
	{
		#region Primarina Builders
		/// <summary>
		/// Primarina Builder waiting for a Nickname & a Level
		/// </summary>
		public Primarina(string nickname, int level)
		: base(
				730,
				SpeciePrimarina.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Primarina Builder only waiting for a Level
		/// </summary>
		public Primarina(int level)
		: base(
				730,
				SpeciePrimarina.Instance, // Pokemon Specie
				"Primarina", level,
				Water.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Primarina Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Primarina() : base(
			730,
			SpeciePrimarina.Instance, // Pokemon Specie
			Water.Instance, Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}