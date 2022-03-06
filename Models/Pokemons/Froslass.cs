using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Froslass Specie to store common natural stats of all Froslasss
	#region SpecieFroslass
	public class SpecieFroslass : PokemonSpecie
	{
#nullable enable
		private static SpecieFroslass? _instance = null;
#nullable restore
        public static SpecieFroslass Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieFroslass();
                }
                return _instance;
            }
        }

		#region SpecieFroslass Builder
		public SpecieFroslass() : base(
			"Froslass",
			70, // HPs
			80, 70, // Attack & Defense
			80, 70, // Special Attack & Defense
			110		
		)
		{
			this._height = 13;
			this._weight = 266;
		}
		#endregion
	}
	#endregion

	//Froslass Pokemon Class
	#region Froslass
	public class Froslass : Pokemon
	{
		#region Froslass Builders
		/// <summary>
		/// Froslass Builder waiting for a Nickname & a Level
		/// </summary>
		public Froslass(string nickname, int level)
		: base(
				478,
				SpecieFroslass.Instance, // Pokemon Specie
				nickname, level,
				Ice.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Froslass Builder only waiting for a Level
		/// </summary>
		public Froslass(int level)
		: base(
				478,
				SpecieFroslass.Instance, // Pokemon Specie
				"Froslass", level,
				Ice.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Froslass Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Froslass() : base(
			478,
			SpecieFroslass.Instance, // Pokemon Specie
			Ice.Instance, Ghost.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}