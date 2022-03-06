using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Magmar Specie to store common natural stats of all Magmars
	#region SpecieMagmar
	public class SpecieMagmar : PokemonSpecie
	{
#nullable enable
		private static SpecieMagmar? _instance = null;
#nullable restore
        public static SpecieMagmar Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMagmar();
                }
                return _instance;
            }
        }

		#region SpecieMagmar Builder
		public SpecieMagmar() : base(
			"Magmar",
			65, // HPs
			95, 57, // Attack & Defense
			100, 85, // Special Attack & Defense
			93		
		)
		{
			this._height = 13;
			this._weight = 445;
		}
		#endregion
	}
	#endregion

	//Magmar Pokemon Class
	#region Magmar
	public class Magmar : Pokemon
	{
		#region Magmar Builders
		/// <summary>
		/// Magmar Builder waiting for a Nickname & a Level
		/// </summary>
		public Magmar(string nickname, int level)
		: base(
				126,
				SpecieMagmar.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Magmar Builder only waiting for a Level
		/// </summary>
		public Magmar(int level)
		: base(
				126,
				SpecieMagmar.Instance, // Pokemon Specie
				"Magmar", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Magmar Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Magmar() : base(
			126,
			SpecieMagmar.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}