using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Skiddo Specie to store common natural stats of all Skiddos
	#region SpecieSkiddo
	public class SpecieSkiddo : PokemonSpecie
	{
#nullable enable
		private static SpecieSkiddo? _instance = null;
#nullable restore
        public static SpecieSkiddo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSkiddo();
                }
                return _instance;
            }
        }

		#region SpecieSkiddo Builder
		public SpecieSkiddo() : base(
			"Skiddo",
			66, // HPs
			65, 48, // Attack & Defense
			62, 57, // Special Attack & Defense
			52			
		) {}
		#endregion
	}
	#endregion

	//Skiddo Pokemon Class
	#region Skiddo
	public class Skiddo : Pokemon
	{
		#region Skiddo Builders
		/// <summary>
		/// Skiddo Builder waiting for a Nickname & a Level
		/// </summary>
		public Skiddo(string nickname, int level)
		: base(
				672,
				SpecieSkiddo.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Skiddo Builder only waiting for a Level
		/// </summary>
		public Skiddo(int level)
		: base(
				672,
				SpecieSkiddo.Instance, // Pokemon Specie
				"Skiddo", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Skiddo Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Skiddo() : base(
			672,
			SpecieSkiddo.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
		#endregion
	}
	#endregion
}