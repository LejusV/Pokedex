using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Haxorus Specie to store common natural stats of all Haxoruss
	#region SpecieHaxorus
	public class SpecieHaxorus : PokemonSpecie
	{
#nullable enable
		private static SpecieHaxorus? _instance = null;
#nullable restore
        public static SpecieHaxorus Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHaxorus();
                }
                return _instance;
            }
        }

		#region SpecieHaxorus Builder
		public SpecieHaxorus() : base(
			"Haxorus",
			1.8,
			105.5,
			76, // HPs
			147, 90, // Attack & Defense
			60, 70, // Special Attack & Defense
			97		
		)
		{}
		#endregion
	}
	#endregion

	//Haxorus Pokemon Class
	#region Haxorus
	public class Haxorus : Pokemon
	{
		#region Haxorus Builders
		/// <summary>
		/// Haxorus Builder waiting for a Nickname & a Level
		/// </summary>
		public Haxorus(string nickname, int level)
		: base(
				612,
				SpecieHaxorus.Instance, // Pokemon Specie
				nickname, level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Haxorus Builder only waiting for a Level
		/// </summary>
		public Haxorus(int level)
		: base(
				612,
				SpecieHaxorus.Instance, // Pokemon Specie
				"Haxorus", level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Haxorus Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Haxorus() : base(
			612,
			SpecieHaxorus.Instance, // Pokemon Specie
			Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}