using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Applin Specie to store common natural stats of all Applins
	#region SpecieApplin
	public class SpecieApplin : PokemonSpecie
	{
#nullable enable
		private static SpecieApplin? _instance = null;
#nullable restore
        public static SpecieApplin Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieApplin();
                }
                return _instance;
            }
        }

		#region SpecieApplin Builder
		public SpecieApplin() : base(
			"Applin",
			0.2,
			0.5,
			40, // HPs
			40, 80, // Attack & Defense
			40, 40, // Special Attack & Defense
			20		
		)
		{}
		#endregion
	}
	#endregion

	//Applin Pokemon Class
	#region Applin
	public class Applin : Pokemon
	{
		#region Applin Builders
		/// <summary>
		/// Applin Builder waiting for a Nickname & a Level
		/// </summary>
		public Applin(string nickname, int level)
		: base(
				840,
				SpecieApplin.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Applin Builder only waiting for a Level
		/// </summary>
		public Applin(int level)
		: base(
				840,
				SpecieApplin.Instance, // Pokemon Specie
				"Applin", level,
				Grass.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Applin Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Applin() : base(
			840,
			SpecieApplin.Instance, // Pokemon Specie
			Grass.Instance, Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}