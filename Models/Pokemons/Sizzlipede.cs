using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Sizzlipede Specie to store common natural stats of all Sizzlipedes
	#region SpecieSizzlipede
	public class SpecieSizzlipede : PokemonSpecie
	{
#nullable enable
		private static SpecieSizzlipede? _instance = null;
#nullable restore
        public static SpecieSizzlipede Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSizzlipede();
                }
                return _instance;
            }
        }

		#region SpecieSizzlipede Builder
		public SpecieSizzlipede() : base(
			"Sizzlipede",
			50, // HPs
			65, 45, // Attack & Defense
			50, 50, // Special Attack & Defense
			45		
		)
		{
			this._height = 7;
			this._weight = 10;
		}
		#endregion
	}
	#endregion

	//Sizzlipede Pokemon Class
	#region Sizzlipede
	public class Sizzlipede : Pokemon
	{
		#region Sizzlipede Builders
		/// <summary>
		/// Sizzlipede Builder waiting for a Nickname & a Level
		/// </summary>
		public Sizzlipede(string nickname, int level)
		: base(
				850,
				SpecieSizzlipede.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance, Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sizzlipede Builder only waiting for a Level
		/// </summary>
		public Sizzlipede(int level)
		: base(
				850,
				SpecieSizzlipede.Instance, // Pokemon Specie
				"Sizzlipede", level,
				Fire.Instance, Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sizzlipede Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Sizzlipede() : base(
			850,
			SpecieSizzlipede.Instance, // Pokemon Specie
			Fire.Instance, Bug.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}