using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Wobbuffet Specie to store common natural stats of all Wobbuffets
	#region SpecieWobbuffet
	public class SpecieWobbuffet : PokemonSpecie
	{
#nullable enable
		private static SpecieWobbuffet? _instance = null;
#nullable restore
        public static SpecieWobbuffet Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieWobbuffet();
                }
                return _instance;
            }
        }

		#region SpecieWobbuffet Builder
		public SpecieWobbuffet() : base(
			"Wobbuffet",
			190, // HPs
			33, 58, // Attack & Defense
			33, 58, // Special Attack & Defense
			33			
		) {}
		#endregion
	}
	#endregion

	//Wobbuffet Pokemon Class
	#region Wobbuffet
	public class Wobbuffet : Pokemon
	{
		#region Wobbuffet Builders
		/// <summary>
		/// Wobbuffet Builder waiting for a Nickname & a Level
		/// </summary>
		public Wobbuffet(string nickname, int level)
		: base(
				202,
				SpecieWobbuffet.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wobbuffet Builder only waiting for a Level
		/// </summary>
		public Wobbuffet(int level)
		: base(
				202,
				SpecieWobbuffet.Instance, // Pokemon Specie
				"Wobbuffet", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wobbuffet Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Wobbuffet() : base(
			202,
			SpecieWobbuffet.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
		#endregion
	}
	#endregion
}