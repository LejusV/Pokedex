using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Bayleef Specie to store common natural stats of all Bayleefs
	#region SpecieBayleef
	public class SpecieBayleef : PokemonSpecie
	{
#nullable enable
		private static SpecieBayleef? _instance = null;
#nullable restore
        public static SpecieBayleef Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBayleef();
                }
                return _instance;
            }
        }

		#region SpecieBayleef Builder
		public SpecieBayleef() : base(
			"Bayleef",
			60, // HPs
			62, 80, // Attack & Defense
			63, 80, // Special Attack & Defense
			60		
		)
		{
			this._height = 12;
			this._weight = 158;
		}
		#endregion
	}
	#endregion

	//Bayleef Pokemon Class
	#region Bayleef
	public class Bayleef : Pokemon
	{
		#region Bayleef Builders
		/// <summary>
		/// Bayleef Builder waiting for a Nickname & a Level
		/// </summary>
		public Bayleef(string nickname, int level)
		: base(
				153,
				SpecieBayleef.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bayleef Builder only waiting for a Level
		/// </summary>
		public Bayleef(int level)
		: base(
				153,
				SpecieBayleef.Instance, // Pokemon Specie
				"Bayleef", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bayleef Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Bayleef() : base(
			153,
			SpecieBayleef.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}