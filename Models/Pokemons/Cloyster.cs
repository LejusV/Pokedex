using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Cloyster Specie to store common natural stats of all Cloysters
	#region SpecieCloyster
	public class SpecieCloyster : PokemonSpecie
	{
#nullable enable
		private static SpecieCloyster? _instance = null;
#nullable restore
        public static SpecieCloyster Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCloyster();
                }
                return _instance;
            }
        }

		#region SpecieCloyster Builder
		public SpecieCloyster() : base(
			"Cloyster",
			1.5,
			132.5,
			50, // HPs
			95, 180, // Attack & Defense
			85, 45, // Special Attack & Defense
			70		
		)
		{}
		#endregion
	}
	#endregion

	//Cloyster Pokemon Class
	#region Cloyster
	public class Cloyster : Pokemon
	{
		#region Cloyster Builders
		/// <summary>
		/// Cloyster Builder waiting for a Nickname & a Level
		/// </summary>
		public Cloyster(string nickname, int level)
		: base(
				91,
				SpecieCloyster.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cloyster Builder only waiting for a Level
		/// </summary>
		public Cloyster(int level)
		: base(
				91,
				SpecieCloyster.Instance, // Pokemon Specie
				"Cloyster", level,
				Water.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cloyster Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Cloyster() : base(
			91,
			SpecieCloyster.Instance, // Pokemon Specie
			Water.Instance, Ice.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}