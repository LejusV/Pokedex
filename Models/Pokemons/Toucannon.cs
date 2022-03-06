using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Toucannon Specie to store common natural stats of all Toucannons
	#region SpecieToucannon
	public class SpecieToucannon : PokemonSpecie
	{
#nullable enable
		private static SpecieToucannon? _instance = null;
#nullable restore
        public static SpecieToucannon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieToucannon();
                }
                return _instance;
            }
        }

		#region SpecieToucannon Builder
		public SpecieToucannon() : base(
			"Toucannon",
			80, // HPs
			120, 75, // Attack & Defense
			75, 75, // Special Attack & Defense
			60		
		)
		{
			this._height = 11;
			this._weight = 260;
		}
		#endregion
	}
	#endregion

	//Toucannon Pokemon Class
	#region Toucannon
	public class Toucannon : Pokemon
	{
		#region Toucannon Builders
		/// <summary>
		/// Toucannon Builder waiting for a Nickname & a Level
		/// </summary>
		public Toucannon(string nickname, int level)
		: base(
				733,
				SpecieToucannon.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Toucannon Builder only waiting for a Level
		/// </summary>
		public Toucannon(int level)
		: base(
				733,
				SpecieToucannon.Instance, // Pokemon Specie
				"Toucannon", level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Toucannon Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Toucannon() : base(
			733,
			SpecieToucannon.Instance, // Pokemon Specie
			Normal.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}