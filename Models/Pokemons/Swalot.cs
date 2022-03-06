using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Swalot Specie to store common natural stats of all Swalots
	#region SpecieSwalot
	public class SpecieSwalot : PokemonSpecie
	{
#nullable enable
		private static SpecieSwalot? _instance = null;
#nullable restore
        public static SpecieSwalot Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSwalot();
                }
                return _instance;
            }
        }

		#region SpecieSwalot Builder
		public SpecieSwalot() : base(
			"Swalot",
			100, // HPs
			73, 83, // Attack & Defense
			73, 83, // Special Attack & Defense
			55		
		)
		{
			this._height = 17;
			this._weight = 800;
		}
		#endregion
	}
	#endregion

	//Swalot Pokemon Class
	#region Swalot
	public class Swalot : Pokemon
	{
		#region Swalot Builders
		/// <summary>
		/// Swalot Builder waiting for a Nickname & a Level
		/// </summary>
		public Swalot(string nickname, int level)
		: base(
				317,
				SpecieSwalot.Instance, // Pokemon Specie
				nickname, level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Swalot Builder only waiting for a Level
		/// </summary>
		public Swalot(int level)
		: base(
				317,
				SpecieSwalot.Instance, // Pokemon Specie
				"Swalot", level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Swalot Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Swalot() : base(
			317,
			SpecieSwalot.Instance, // Pokemon Specie
			Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}