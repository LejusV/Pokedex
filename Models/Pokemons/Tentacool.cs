using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Tentacool Specie to store common natural stats of all Tentacools
	#region SpecieTentacool
	public class SpecieTentacool : PokemonSpecie
	{
#nullable enable
		private static SpecieTentacool? _instance = null;
#nullable restore
        public static SpecieTentacool Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTentacool();
                }
                return _instance;
            }
        }

		#region SpecieTentacool Builder
		public SpecieTentacool() : base(
			"Tentacool",
			40, // HPs
			40, 35, // Attack & Defense
			50, 100, // Special Attack & Defense
			70			
		) {}
		#endregion
	}
	#endregion

	//Tentacool Pokemon Class
	#region Tentacool
	public class Tentacool : Pokemon
	{
		#region Tentacool Builders
		/// <summary>
		/// Tentacool Builder waiting for a Nickname & a Level
		/// </summary>
		public Tentacool(string nickname, int level)
		: base(
				72,
				SpecieTentacool.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tentacool Builder only waiting for a Level
		/// </summary>
		public Tentacool(int level)
		: base(
				72,
				SpecieTentacool.Instance, // Pokemon Specie
				"Tentacool", level,
				Water.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tentacool Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Tentacool() : base(
			72,
			SpecieTentacool.Instance, // Pokemon Specie
			Water.Instance, Poison.Instance			
		) {}
		#endregion
	}
	#endregion
}