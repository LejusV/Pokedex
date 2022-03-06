using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Ariados Specie to store common natural stats of all Ariadoss
	#region SpecieAriados
	public class SpecieAriados : PokemonSpecie
	{
#nullable enable
		private static SpecieAriados? _instance = null;
#nullable restore
        public static SpecieAriados Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieAriados();
                }
                return _instance;
            }
        }

		#region SpecieAriados Builder
		public SpecieAriados() : base(
			"Ariados",
			1.1,
			33.5,
			70, // HPs
			90, 70, // Attack & Defense
			60, 70, // Special Attack & Defense
			40		
		)
		{}
		#endregion
	}
	#endregion

	//Ariados Pokemon Class
	#region Ariados
	public class Ariados : Pokemon
	{
		#region Ariados Builders
		/// <summary>
		/// Ariados Builder waiting for a Nickname & a Level
		/// </summary>
		public Ariados(string nickname, int level)
		: base(
				168,
				SpecieAriados.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ariados Builder only waiting for a Level
		/// </summary>
		public Ariados(int level)
		: base(
				168,
				SpecieAriados.Instance, // Pokemon Specie
				"Ariados", level,
				Bug.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ariados Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Ariados() : base(
			168,
			SpecieAriados.Instance, // Pokemon Specie
			Bug.Instance, Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}