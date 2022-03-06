using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Purugly Specie to store common natural stats of all Puruglys
	#region SpeciePurugly
	public class SpeciePurugly : PokemonSpecie
	{
#nullable enable
		private static SpeciePurugly? _instance = null;
#nullable restore
        public static SpeciePurugly Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePurugly();
                }
                return _instance;
            }
        }

		#region SpeciePurugly Builder
		public SpeciePurugly() : base(
			"Purugly",
			1.0,
			43.8,
			71, // HPs
			82, 64, // Attack & Defense
			64, 59, // Special Attack & Defense
			112		
		)
		{}
		#endregion
	}
	#endregion

	//Purugly Pokemon Class
	#region Purugly
	public class Purugly : Pokemon
	{
		#region Purugly Builders
		/// <summary>
		/// Purugly Builder waiting for a Nickname & a Level
		/// </summary>
		public Purugly(string nickname, int level)
		: base(
				432,
				SpeciePurugly.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Purugly Builder only waiting for a Level
		/// </summary>
		public Purugly(int level)
		: base(
				432,
				SpeciePurugly.Instance, // Pokemon Specie
				"Purugly", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Purugly Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Purugly() : base(
			432,
			SpeciePurugly.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}