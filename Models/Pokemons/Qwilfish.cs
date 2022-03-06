using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Qwilfish Specie to store common natural stats of all Qwilfishs
	#region SpecieQwilfish
	public class SpecieQwilfish : PokemonSpecie
	{
#nullable enable
		private static SpecieQwilfish? _instance = null;
#nullable restore
        public static SpecieQwilfish Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieQwilfish();
                }
                return _instance;
            }
        }

		#region SpecieQwilfish Builder
		public SpecieQwilfish() : base(
			"Qwilfish",
			0.5,
			3.9,
			65, // HPs
			95, 85, // Attack & Defense
			55, 55, // Special Attack & Defense
			85		
		)
		{}
		#endregion
	}
	#endregion

	//Qwilfish Pokemon Class
	#region Qwilfish
	public class Qwilfish : Pokemon
	{
		#region Qwilfish Builders
		/// <summary>
		/// Qwilfish Builder waiting for a Nickname & a Level
		/// </summary>
		public Qwilfish(string nickname, int level)
		: base(
				211,
				SpecieQwilfish.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Qwilfish Builder only waiting for a Level
		/// </summary>
		public Qwilfish(int level)
		: base(
				211,
				SpecieQwilfish.Instance, // Pokemon Specie
				"Qwilfish", level,
				Water.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Qwilfish Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Qwilfish() : base(
			211,
			SpecieQwilfish.Instance, // Pokemon Specie
			Water.Instance, Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}