using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Articuno Specie to store common natural stats of all Articunos
	#region SpecieArticuno
	public class SpecieArticuno : PokemonSpecie
	{
#nullable enable
		private static SpecieArticuno? _instance = null;
#nullable restore
        public static SpecieArticuno Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieArticuno();
                }
                return _instance;
            }
        }

		#region SpecieArticuno Builder
		public SpecieArticuno() : base(
			"Articuno",
			1.7,
			55.4,
			90, // HPs
			85, 100, // Attack & Defense
			95, 125, // Special Attack & Defense
			85		
		)
		{}
		#endregion
	}
	#endregion

	//Articuno Pokemon Class
	#region Articuno
	public class Articuno : Pokemon
	{
		#region Articuno Builders
		/// <summary>
		/// Articuno Builder waiting for a Nickname & a Level
		/// </summary>
		public Articuno(string nickname, int level)
		: base(
				144,
				SpecieArticuno.Instance, // Pokemon Specie
				nickname, level,
				Ice.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Articuno Builder only waiting for a Level
		/// </summary>
		public Articuno(int level)
		: base(
				144,
				SpecieArticuno.Instance, // Pokemon Specie
				"Articuno", level,
				Ice.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Articuno Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Articuno() : base(
			144,
			SpecieArticuno.Instance, // Pokemon Specie
			Ice.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}