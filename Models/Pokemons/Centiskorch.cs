using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Centiskorch Specie to store common natural stats of all Centiskorchs
	#region SpecieCentiskorch
	public class SpecieCentiskorch : PokemonSpecie
	{
#nullable enable
		private static SpecieCentiskorch? _instance = null;
#nullable restore
        public static SpecieCentiskorch Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCentiskorch();
                }
                return _instance;
            }
        }

		#region SpecieCentiskorch Builder
		public SpecieCentiskorch() : base(
			"Centiskorch",
			100, // HPs
			115, 65, // Attack & Defense
			90, 90, // Special Attack & Defense
			65			
		) {}
		#endregion
	}
	#endregion

	//Centiskorch Pokemon Class
	#region Centiskorch
	public class Centiskorch : Pokemon
	{
		#region Centiskorch Builders
		/// <summary>
		/// Centiskorch Builder waiting for a Nickname & a Level
		/// </summary>
		public Centiskorch(string nickname, int level)
		: base(
				851,
				SpecieCentiskorch.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance, Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Centiskorch Builder only waiting for a Level
		/// </summary>
		public Centiskorch(int level)
		: base(
				851,
				SpecieCentiskorch.Instance, // Pokemon Specie
				"Centiskorch", level,
				Fire.Instance, Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Centiskorch Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Centiskorch() : base(
			851,
			SpecieCentiskorch.Instance, // Pokemon Specie
			Fire.Instance, Bug.Instance			
		) {}
		#endregion
	}
	#endregion
}