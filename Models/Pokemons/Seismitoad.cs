using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Seismitoad Specie to store common natural stats of all Seismitoads
	#region SpecieSeismitoad
	public class SpecieSeismitoad : PokemonSpecie
	{
#nullable enable
		private static SpecieSeismitoad? _instance = null;
#nullable restore
        public static SpecieSeismitoad Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSeismitoad();
                }
                return _instance;
            }
        }

		#region SpecieSeismitoad Builder
		public SpecieSeismitoad() : base(
			"Seismitoad",
			105, // HPs
			95, 75, // Attack & Defense
			85, 75, // Special Attack & Defense
			74		
		)
		{
			this._height = 15;
			this._weight = 620;
		}
		#endregion
	}
	#endregion

	//Seismitoad Pokemon Class
	#region Seismitoad
	public class Seismitoad : Pokemon
	{
		#region Seismitoad Builders
		/// <summary>
		/// Seismitoad Builder waiting for a Nickname & a Level
		/// </summary>
		public Seismitoad(string nickname, int level)
		: base(
				537,
				SpecieSeismitoad.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Seismitoad Builder only waiting for a Level
		/// </summary>
		public Seismitoad(int level)
		: base(
				537,
				SpecieSeismitoad.Instance, // Pokemon Specie
				"Seismitoad", level,
				Water.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Seismitoad Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Seismitoad() : base(
			537,
			SpecieSeismitoad.Instance, // Pokemon Specie
			Water.Instance, Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}