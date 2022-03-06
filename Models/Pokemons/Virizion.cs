using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Virizion Specie to store common natural stats of all Virizions
	#region SpecieVirizion
	public class SpecieVirizion : PokemonSpecie
	{
#nullable enable
		private static SpecieVirizion? _instance = null;
#nullable restore
        public static SpecieVirizion Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieVirizion();
                }
                return _instance;
            }
        }

		#region SpecieVirizion Builder
		public SpecieVirizion() : base(
			"Virizion",
			2.0,
			200.0,
			91, // HPs
			90, 72, // Attack & Defense
			90, 129, // Special Attack & Defense
			108		
		)
		{}
		#endregion
	}
	#endregion

	//Virizion Pokemon Class
	#region Virizion
	public class Virizion : Pokemon
	{
		#region Virizion Builders
		/// <summary>
		/// Virizion Builder waiting for a Nickname & a Level
		/// </summary>
		public Virizion(string nickname, int level)
		: base(
				640,
				SpecieVirizion.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Virizion Builder only waiting for a Level
		/// </summary>
		public Virizion(int level)
		: base(
				640,
				SpecieVirizion.Instance, // Pokemon Specie
				"Virizion", level,
				Grass.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Virizion Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Virizion() : base(
			640,
			SpecieVirizion.Instance, // Pokemon Specie
			Grass.Instance, Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}