using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Lotad Specie to store common natural stats of all Lotads
	#region SpecieLotad
	public class SpecieLotad : PokemonSpecie
	{
#nullable enable
		private static SpecieLotad? _instance = null;
#nullable restore
        public static SpecieLotad Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLotad();
                }
                return _instance;
            }
        }

		#region SpecieLotad Builder
		public SpecieLotad() : base(
			"Lotad",
			40, // HPs
			30, 30, // Attack & Defense
			40, 50, // Special Attack & Defense
			30			
		) {}
		#endregion
	}
	#endregion

	//Lotad Pokemon Class
	#region Lotad
	public class Lotad : Pokemon
	{
		#region Lotad Builders
		/// <summary>
		/// Lotad Builder waiting for a Nickname & a Level
		/// </summary>
		public Lotad(string nickname, int level)
		: base(
				270,
				SpecieLotad.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lotad Builder only waiting for a Level
		/// </summary>
		public Lotad(int level)
		: base(
				270,
				SpecieLotad.Instance, // Pokemon Specie
				"Lotad", level,
				Water.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lotad Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Lotad() : base(
			270,
			SpecieLotad.Instance, // Pokemon Specie
			Water.Instance, Grass.Instance			
		) {}
		#endregion
	}
	#endregion
}