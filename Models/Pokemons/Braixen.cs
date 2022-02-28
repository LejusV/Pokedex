using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Braixen Specie to store common natural stats of all Braixens
	#region SpecieBraixen
	public class SpecieBraixen : PokemonSpecie
	{
#nullable enable
		private static SpecieBraixen? _instance = null;
#nullable restore
        public static SpecieBraixen Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBraixen();
                }
                return _instance;
            }
        }

		#region SpecieBraixen Builder
		public SpecieBraixen() : base(
			"Braixen",
			59, // HPs
			59, 58, // Attack & Defense
			90, 70, // Special Attack & Defense
			73			
		) {}
		#endregion
	}
	#endregion

	//Braixen Pokemon Class
	#region Braixen
	public class Braixen : Pokemon
	{
		#region Braixen Builders
		/// <summary>
		/// Braixen Builder waiting for a Nickname & a Level
		/// </summary>
		public Braixen(string nickname, int level)
		: base(
				654,
				SpecieBraixen.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Braixen Builder only waiting for a Level
		/// </summary>
		public Braixen(int level)
		: base(
				654,
				SpecieBraixen.Instance, // Pokemon Specie
				"Braixen", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Braixen Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Braixen() : base(
			654,
			SpecieBraixen.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
		#endregion
	}
	#endregion
}