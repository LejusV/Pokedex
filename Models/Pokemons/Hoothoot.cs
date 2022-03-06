using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Hoothoot Specie to store common natural stats of all Hoothoots
	#region SpecieHoothoot
	public class SpecieHoothoot : PokemonSpecie
	{
#nullable enable
		private static SpecieHoothoot? _instance = null;
#nullable restore
        public static SpecieHoothoot Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHoothoot();
                }
                return _instance;
            }
        }

		#region SpecieHoothoot Builder
		public SpecieHoothoot() : base(
			"Hoothoot",
			60, // HPs
			30, 30, // Attack & Defense
			36, 56, // Special Attack & Defense
			50		
		)
		{
			this._height = 7;
			this._weight = 212;
		}
		#endregion
	}
	#endregion

	//Hoothoot Pokemon Class
	#region Hoothoot
	public class Hoothoot : Pokemon
	{
		#region Hoothoot Builders
		/// <summary>
		/// Hoothoot Builder waiting for a Nickname & a Level
		/// </summary>
		public Hoothoot(string nickname, int level)
		: base(
				163,
				SpecieHoothoot.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hoothoot Builder only waiting for a Level
		/// </summary>
		public Hoothoot(int level)
		: base(
				163,
				SpecieHoothoot.Instance, // Pokemon Specie
				"Hoothoot", level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hoothoot Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Hoothoot() : base(
			163,
			SpecieHoothoot.Instance, // Pokemon Specie
			Normal.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}