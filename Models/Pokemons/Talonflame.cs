using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Talonflame Specie to store common natural stats of all Talonflames
	#region SpecieTalonflame
	public class SpecieTalonflame : PokemonSpecie
	{
#nullable enable
		private static SpecieTalonflame? _instance = null;
#nullable restore
        public static SpecieTalonflame Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTalonflame();
                }
                return _instance;
            }
        }

		#region SpecieTalonflame Builder
		public SpecieTalonflame() : base(
			"Talonflame",
			1.2,
			24.5,
			78, // HPs
			81, 71, // Attack & Defense
			74, 69, // Special Attack & Defense
			126		
		)
		{}
		#endregion
	}
	#endregion

	//Talonflame Pokemon Class
	#region Talonflame
	public class Talonflame : Pokemon
	{
		#region Talonflame Builders
		/// <summary>
		/// Talonflame Builder waiting for a Nickname & a Level
		/// </summary>
		public Talonflame(string nickname, int level)
		: base(
				663,
				SpecieTalonflame.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Talonflame Builder only waiting for a Level
		/// </summary>
		public Talonflame(int level)
		: base(
				663,
				SpecieTalonflame.Instance, // Pokemon Specie
				"Talonflame", level,
				Fire.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Talonflame Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Talonflame() : base(
			663,
			SpecieTalonflame.Instance, // Pokemon Specie
			Fire.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}