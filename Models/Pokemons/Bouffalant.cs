using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Bouffalant Specie to store common natural stats of all Bouffalants
	#region SpecieBouffalant
	public class SpecieBouffalant : PokemonSpecie
	{
#nullable enable
		private static SpecieBouffalant? _instance = null;
#nullable restore
        public static SpecieBouffalant Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBouffalant();
                }
                return _instance;
            }
        }

		#region SpecieBouffalant Builder
		public SpecieBouffalant() : base(
			"Bouffalant",
			95, // HPs
			110, 95, // Attack & Defense
			40, 95, // Special Attack & Defense
			55		
		)
		{
			this._height = 16;
			this._weight = 946;
		}
		#endregion
	}
	#endregion

	//Bouffalant Pokemon Class
	#region Bouffalant
	public class Bouffalant : Pokemon
	{
		#region Bouffalant Builders
		/// <summary>
		/// Bouffalant Builder waiting for a Nickname & a Level
		/// </summary>
		public Bouffalant(string nickname, int level)
		: base(
				626,
				SpecieBouffalant.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bouffalant Builder only waiting for a Level
		/// </summary>
		public Bouffalant(int level)
		: base(
				626,
				SpecieBouffalant.Instance, // Pokemon Specie
				"Bouffalant", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bouffalant Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Bouffalant() : base(
			626,
			SpecieBouffalant.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}