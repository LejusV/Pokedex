using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Aron Specie to store common natural stats of all Arons
	#region SpecieAron
	public class SpecieAron : PokemonSpecie
	{
#nullable enable
		private static SpecieAron? _instance = null;
#nullable restore
        public static SpecieAron Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieAron();
                }
                return _instance;
            }
        }

		#region SpecieAron Builder
		public SpecieAron() : base(
			"Aron",
			0.4,
			60.0,
			50, // HPs
			70, 100, // Attack & Defense
			40, 40, // Special Attack & Defense
			30		
		)
		{}
		#endregion
	}
	#endregion

	//Aron Pokemon Class
	#region Aron
	public class Aron : Pokemon
	{
		#region Aron Builders
		/// <summary>
		/// Aron Builder waiting for a Nickname & a Level
		/// </summary>
		public Aron(string nickname, int level)
		: base(
				304,
				SpecieAron.Instance, // Pokemon Specie
				nickname, level,
				Steel.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Aron Builder only waiting for a Level
		/// </summary>
		public Aron(int level)
		: base(
				304,
				SpecieAron.Instance, // Pokemon Specie
				"Aron", level,
				Steel.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Aron Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Aron() : base(
			304,
			SpecieAron.Instance, // Pokemon Specie
			Steel.Instance, Rock.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}