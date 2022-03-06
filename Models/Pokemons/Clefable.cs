using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Clefable Specie to store common natural stats of all Clefables
	#region SpecieClefable
	public class SpecieClefable : PokemonSpecie
	{
#nullable enable
		private static SpecieClefable? _instance = null;
#nullable restore
        public static SpecieClefable Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieClefable();
                }
                return _instance;
            }
        }

		#region SpecieClefable Builder
		public SpecieClefable() : base(
			"Clefable",
			95, // HPs
			70, 73, // Attack & Defense
			95, 90, // Special Attack & Defense
			60		
		)
		{
			this._height = 13;
			this._weight = 400;
		}
		#endregion
	}
	#endregion

	//Clefable Pokemon Class
	#region Clefable
	public class Clefable : Pokemon
	{
		#region Clefable Builders
		/// <summary>
		/// Clefable Builder waiting for a Nickname & a Level
		/// </summary>
		public Clefable(string nickname, int level)
		: base(
				36,
				SpecieClefable.Instance, // Pokemon Specie
				nickname, level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Clefable Builder only waiting for a Level
		/// </summary>
		public Clefable(int level)
		: base(
				36,
				SpecieClefable.Instance, // Pokemon Specie
				"Clefable", level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Clefable Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Clefable() : base(
			36,
			SpecieClefable.Instance, // Pokemon Specie
			Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}