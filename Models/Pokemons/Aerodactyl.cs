using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Aerodactyl Specie to store common natural stats of all Aerodactyls
	#region SpecieAerodactyl
	public class SpecieAerodactyl : PokemonSpecie
	{
#nullable enable
		private static SpecieAerodactyl? _instance = null;
#nullable restore
        public static SpecieAerodactyl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieAerodactyl();
                }
                return _instance;
            }
        }

		#region SpecieAerodactyl Builder
		public SpecieAerodactyl() : base(
			"Aerodactyl",
			1.8,
			59.0,
			80, // HPs
			105, 65, // Attack & Defense
			60, 75, // Special Attack & Defense
			130		
		)
		{}
		#endregion
	}
	#endregion

	//Aerodactyl Pokemon Class
	#region Aerodactyl
	public class Aerodactyl : Pokemon
	{
		#region Aerodactyl Builders
		/// <summary>
		/// Aerodactyl Builder waiting for a Nickname & a Level
		/// </summary>
		public Aerodactyl(string nickname, int level)
		: base(
				142,
				SpecieAerodactyl.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Aerodactyl Builder only waiting for a Level
		/// </summary>
		public Aerodactyl(int level)
		: base(
				142,
				SpecieAerodactyl.Instance, // Pokemon Specie
				"Aerodactyl", level,
				Rock.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Aerodactyl Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Aerodactyl() : base(
			142,
			SpecieAerodactyl.Instance, // Pokemon Specie
			Rock.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}