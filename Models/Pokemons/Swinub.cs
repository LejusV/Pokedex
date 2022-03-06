using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Swinub Specie to store common natural stats of all Swinubs
	#region SpecieSwinub
	public class SpecieSwinub : PokemonSpecie
	{
#nullable enable
		private static SpecieSwinub? _instance = null;
#nullable restore
        public static SpecieSwinub Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSwinub();
                }
                return _instance;
            }
        }

		#region SpecieSwinub Builder
		public SpecieSwinub() : base(
			"Swinub",
			0.4,
			6.5,
			50, // HPs
			50, 40, // Attack & Defense
			30, 30, // Special Attack & Defense
			50		
		)
		{}
		#endregion
	}
	#endregion

	//Swinub Pokemon Class
	#region Swinub
	public class Swinub : Pokemon
	{
		#region Swinub Builders
		/// <summary>
		/// Swinub Builder waiting for a Nickname & a Level
		/// </summary>
		public Swinub(string nickname, int level)
		: base(
				220,
				SpecieSwinub.Instance, // Pokemon Specie
				nickname, level,
				Ice.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Swinub Builder only waiting for a Level
		/// </summary>
		public Swinub(int level)
		: base(
				220,
				SpecieSwinub.Instance, // Pokemon Specie
				"Swinub", level,
				Ice.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Swinub Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Swinub() : base(
			220,
			SpecieSwinub.Instance, // Pokemon Specie
			Ice.Instance, Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}