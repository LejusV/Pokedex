using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Lairon Specie to store common natural stats of all Lairons
	#region SpecieLairon
	public class SpecieLairon : PokemonSpecie
	{
#nullable enable
		private static SpecieLairon? _instance = null;
#nullable restore
        public static SpecieLairon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLairon();
                }
                return _instance;
            }
        }

		#region SpecieLairon Builder
		public SpecieLairon() : base(
			"Lairon",
			60, // HPs
			90, 140, // Attack & Defense
			50, 50, // Special Attack & Defense
			40		
		)
		{
			this._height = 9;
			this._weight = 1200;
		}
		#endregion
	}
	#endregion

	//Lairon Pokemon Class
	#region Lairon
	public class Lairon : Pokemon
	{
		#region Lairon Builders
		/// <summary>
		/// Lairon Builder waiting for a Nickname & a Level
		/// </summary>
		public Lairon(string nickname, int level)
		: base(
				305,
				SpecieLairon.Instance, // Pokemon Specie
				nickname, level,
				Steel.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lairon Builder only waiting for a Level
		/// </summary>
		public Lairon(int level)
		: base(
				305,
				SpecieLairon.Instance, // Pokemon Specie
				"Lairon", level,
				Steel.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lairon Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Lairon() : base(
			305,
			SpecieLairon.Instance, // Pokemon Specie
			Steel.Instance, Rock.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}