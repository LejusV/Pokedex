using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Ho-Oh Specie to store common natural stats of all Ho-Ohs
	#region SpecieHo-Oh
	public class SpecieHoOh : PokemonSpecie
	{
#nullable enable
		private static SpecieHoOh? _instance = null;
#nullable restore
        public static SpecieHoOh Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHoOh();
                }
                return _instance;
            }
        }

		#region SpecieHo-Oh Builder
		public SpecieHoOh() : base(
			"Ho-Oh",
			3.8,
			199.0,
			106, // HPs
			130, 90, // Attack & Defense
			110, 154, // Special Attack & Defense
			90		
		)
		{}
		#endregion
	}
	#endregion

	//Ho-Oh Pokemon Class
	#region Ho-Oh
	public class HoOh : Pokemon
	{
		#region Ho-Oh Builders
		/// <summary>
		/// Ho-Oh Builder waiting for a Nickname & a Level
		/// </summary>
		public HoOh(string nickname, int level)
		: base(
				250,
				SpecieHoOh.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ho-Oh Builder only waiting for a Level
		/// </summary>
		public HoOh(int level)
		: base(
				250,
				SpecieHoOh.Instance, // Pokemon Specie
				"Ho-Oh", level,
				Fire.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ho-Oh Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public HoOh() : base(
			250,
			SpecieHoOh.Instance, // Pokemon Specie
			Fire.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}