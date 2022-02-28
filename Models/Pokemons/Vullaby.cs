using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Vullaby Specie to store common natural stats of all Vullabys
	#region SpecieVullaby
	public class SpecieVullaby : PokemonSpecie
	{
#nullable enable
		private static SpecieVullaby? _instance = null;
#nullable restore
        public static SpecieVullaby Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieVullaby();
                }
                return _instance;
            }
        }

		#region SpecieVullaby Builder
		public SpecieVullaby() : base(
			"Vullaby",
			70, // HPs
			55, 75, // Attack & Defense
			45, 65, // Special Attack & Defense
			60			
		) {}
		#endregion
	}
	#endregion

	//Vullaby Pokemon Class
	#region Vullaby
	public class Vullaby : Pokemon
	{
		#region Vullaby Builders
		/// <summary>
		/// Vullaby Builder waiting for a Nickname & a Level
		/// </summary>
		public Vullaby(string nickname, int level)
		: base(
				629,
				SpecieVullaby.Instance, // Pokemon Specie
				nickname, level,
				Dark.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vullaby Builder only waiting for a Level
		/// </summary>
		public Vullaby(int level)
		: base(
				629,
				SpecieVullaby.Instance, // Pokemon Specie
				"Vullaby", level,
				Dark.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vullaby Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Vullaby() : base(
			629,
			SpecieVullaby.Instance, // Pokemon Specie
			Dark.Instance, Flying.Instance			
		) {}
		#endregion
	}
	#endregion
}