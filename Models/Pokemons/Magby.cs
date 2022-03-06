using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Magby Specie to store common natural stats of all Magbys
	#region SpecieMagby
	public class SpecieMagby : PokemonSpecie
	{
#nullable enable
		private static SpecieMagby? _instance = null;
#nullable restore
        public static SpecieMagby Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMagby();
                }
                return _instance;
            }
        }

		#region SpecieMagby Builder
		public SpecieMagby() : base(
			"Magby",
			45, // HPs
			75, 37, // Attack & Defense
			70, 55, // Special Attack & Defense
			83		
		)
		{
			this._height = 7;
			this._weight = 214;
		}
		#endregion
	}
	#endregion

	//Magby Pokemon Class
	#region Magby
	public class Magby : Pokemon
	{
		#region Magby Builders
		/// <summary>
		/// Magby Builder waiting for a Nickname & a Level
		/// </summary>
		public Magby(string nickname, int level)
		: base(
				240,
				SpecieMagby.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Magby Builder only waiting for a Level
		/// </summary>
		public Magby(int level)
		: base(
				240,
				SpecieMagby.Instance, // Pokemon Specie
				"Magby", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Magby Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Magby() : base(
			240,
			SpecieMagby.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}