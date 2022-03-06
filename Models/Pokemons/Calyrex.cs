using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Calyrex Specie to store common natural stats of all Calyrexs
	#region SpecieCalyrex
	public class SpecieCalyrex : PokemonSpecie
	{
#nullable enable
		private static SpecieCalyrex? _instance = null;
#nullable restore
        public static SpecieCalyrex Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCalyrex();
                }
                return _instance;
            }
        }

		#region SpecieCalyrex Builder
		public SpecieCalyrex() : base(
			"Calyrex",
			1.1,
			7.7,
			100, // HPs
			80, 80, // Attack & Defense
			80, 80, // Special Attack & Defense
			80		
		)
		{}
		#endregion
	}
	#endregion

	//Calyrex Pokemon Class
	#region Calyrex
	public class Calyrex : Pokemon
	{
		#region Calyrex Builders
		/// <summary>
		/// Calyrex Builder waiting for a Nickname & a Level
		/// </summary>
		public Calyrex(string nickname, int level)
		: base(
				898,
				SpecieCalyrex.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Calyrex Builder only waiting for a Level
		/// </summary>
		public Calyrex(int level)
		: base(
				898,
				SpecieCalyrex.Instance, // Pokemon Specie
				"Calyrex", level,
				Psychic.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Calyrex Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Calyrex() : base(
			898,
			SpecieCalyrex.Instance, // Pokemon Specie
			Psychic.Instance, Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}