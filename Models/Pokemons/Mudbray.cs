using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Mudbray Specie to store common natural stats of all Mudbrays
	#region SpecieMudbray
	public class SpecieMudbray : PokemonSpecie
	{
#nullable enable
		private static SpecieMudbray? _instance = null;
#nullable restore
        public static SpecieMudbray Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMudbray();
                }
                return _instance;
            }
        }

		#region SpecieMudbray Builder
		public SpecieMudbray() : base(
			"Mudbray",
			70, // HPs
			100, 70, // Attack & Defense
			45, 55, // Special Attack & Defense
			45		
		)
		{
			this._height = 10;
			this._weight = 1100;
		}
		#endregion
	}
	#endregion

	//Mudbray Pokemon Class
	#region Mudbray
	public class Mudbray : Pokemon
	{
		#region Mudbray Builders
		/// <summary>
		/// Mudbray Builder waiting for a Nickname & a Level
		/// </summary>
		public Mudbray(string nickname, int level)
		: base(
				749,
				SpecieMudbray.Instance, // Pokemon Specie
				nickname, level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mudbray Builder only waiting for a Level
		/// </summary>
		public Mudbray(int level)
		: base(
				749,
				SpecieMudbray.Instance, // Pokemon Specie
				"Mudbray", level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mudbray Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Mudbray() : base(
			749,
			SpecieMudbray.Instance, // Pokemon Specie
			Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}