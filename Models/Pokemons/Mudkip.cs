using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Mudkip Specie to store common natural stats of all Mudkips
	#region SpecieMudkip
	public class SpecieMudkip : PokemonSpecie
	{
#nullable enable
		private static SpecieMudkip? _instance = null;
#nullable restore
        public static SpecieMudkip Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMudkip();
                }
                return _instance;
            }
        }

		#region SpecieMudkip Builder
		public SpecieMudkip() : base(
			"Mudkip",
			50, // HPs
			70, 50, // Attack & Defense
			50, 50, // Special Attack & Defense
			40		
		)
		{
			this._height = 4;
			this._weight = 76;
		}
		#endregion
	}
	#endregion

	//Mudkip Pokemon Class
	#region Mudkip
	public class Mudkip : Pokemon
	{
		#region Mudkip Builders
		/// <summary>
		/// Mudkip Builder waiting for a Nickname & a Level
		/// </summary>
		public Mudkip(string nickname, int level)
		: base(
				258,
				SpecieMudkip.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mudkip Builder only waiting for a Level
		/// </summary>
		public Mudkip(int level)
		: base(
				258,
				SpecieMudkip.Instance, // Pokemon Specie
				"Mudkip", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mudkip Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Mudkip() : base(
			258,
			SpecieMudkip.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}