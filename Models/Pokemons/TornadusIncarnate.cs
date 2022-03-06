using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Tornadus-Incarnate Specie to store common natural stats of all Tornadus-Incarnates
	#region SpecieTornadus-Incarnate
	public class SpecieTornadusIncarnate : PokemonSpecie
	{
#nullable enable
		private static SpecieTornadusIncarnate? _instance = null;
#nullable restore
        public static SpecieTornadusIncarnate Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTornadusIncarnate();
                }
                return _instance;
            }
        }

		#region SpecieTornadus-Incarnate Builder
		public SpecieTornadusIncarnate() : base(
			"Tornadus-Incarnate",
			79, // HPs
			115, 70, // Attack & Defense
			125, 80, // Special Attack & Defense
			111		
		)
		{
			this._height = 15;
			this._weight = 630;
		}
		#endregion
	}
	#endregion

	//Tornadus-Incarnate Pokemon Class
	#region Tornadus-Incarnate
	public class TornadusIncarnate : Pokemon
	{
		#region Tornadus-Incarnate Builders
		/// <summary>
		/// Tornadus-Incarnate Builder waiting for a Nickname & a Level
		/// </summary>
		public TornadusIncarnate(string nickname, int level)
		: base(
				641,
				SpecieTornadusIncarnate.Instance, // Pokemon Specie
				nickname, level,
				Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tornadus-Incarnate Builder only waiting for a Level
		/// </summary>
		public TornadusIncarnate(int level)
		: base(
				641,
				SpecieTornadusIncarnate.Instance, // Pokemon Specie
				"Tornadus-Incarnate", level,
				Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tornadus-Incarnate Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public TornadusIncarnate() : base(
			641,
			SpecieTornadusIncarnate.Instance, // Pokemon Specie
			Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}