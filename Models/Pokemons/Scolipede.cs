using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Scolipede Specie to store common natural stats of all Scolipedes
	#region SpecieScolipede
	public class SpecieScolipede : PokemonSpecie
	{
#nullable enable
		private static SpecieScolipede? _instance = null;
#nullable restore
        public static SpecieScolipede Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieScolipede();
                }
                return _instance;
            }
        }

		#region SpecieScolipede Builder
		public SpecieScolipede() : base(
			"Scolipede",
			2.5,
			200.5,
			60, // HPs
			100, 89, // Attack & Defense
			55, 69, // Special Attack & Defense
			112		
		)
		{}
		#endregion
	}
	#endregion

	//Scolipede Pokemon Class
	#region Scolipede
	public class Scolipede : Pokemon
	{
		#region Scolipede Builders
		/// <summary>
		/// Scolipede Builder waiting for a Nickname & a Level
		/// </summary>
		public Scolipede(string nickname, int level)
		: base(
				545,
				SpecieScolipede.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Scolipede Builder only waiting for a Level
		/// </summary>
		public Scolipede(int level)
		: base(
				545,
				SpecieScolipede.Instance, // Pokemon Specie
				"Scolipede", level,
				Bug.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Scolipede Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Scolipede() : base(
			545,
			SpecieScolipede.Instance, // Pokemon Specie
			Bug.Instance, Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}