using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Poipole Specie to store common natural stats of all Poipoles
	#region SpeciePoipole
	public class SpeciePoipole : PokemonSpecie
	{
#nullable enable
		private static SpeciePoipole? _instance = null;
#nullable restore
        public static SpeciePoipole Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePoipole();
                }
                return _instance;
            }
        }

		#region SpeciePoipole Builder
		public SpeciePoipole() : base(
			"Poipole",
			67, // HPs
			73, 67, // Attack & Defense
			73, 67, // Special Attack & Defense
			73			
		) {}
		#endregion
	}
	#endregion

	//Poipole Pokemon Class
	#region Poipole
	public class Poipole : Pokemon
	{
		#region Poipole Builders
		/// <summary>
		/// Poipole Builder waiting for a Nickname & a Level
		/// </summary>
		public Poipole(string nickname, int level)
		: base(
				803,
				SpeciePoipole.Instance, // Pokemon Specie
				nickname, level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Poipole Builder only waiting for a Level
		/// </summary>
		public Poipole(int level)
		: base(
				803,
				SpeciePoipole.Instance, // Pokemon Specie
				"Poipole", level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Poipole Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Poipole() : base(
			803,
			SpeciePoipole.Instance, // Pokemon Specie
			Poison.Instance			
		) {}
		#endregion
	}
	#endregion
}