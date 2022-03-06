using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Salamence Specie to store common natural stats of all Salamences
	#region SpecieSalamence
	public class SpecieSalamence : PokemonSpecie
	{
#nullable enable
		private static SpecieSalamence? _instance = null;
#nullable restore
        public static SpecieSalamence Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSalamence();
                }
                return _instance;
            }
        }

		#region SpecieSalamence Builder
		public SpecieSalamence() : base(
			"Salamence",
			95, // HPs
			135, 80, // Attack & Defense
			110, 80, // Special Attack & Defense
			100		
		)
		{
			this._height = 15;
			this._weight = 1026;
		}
		#endregion
	}
	#endregion

	//Salamence Pokemon Class
	#region Salamence
	public class Salamence : Pokemon
	{
		#region Salamence Builders
		/// <summary>
		/// Salamence Builder waiting for a Nickname & a Level
		/// </summary>
		public Salamence(string nickname, int level)
		: base(
				373,
				SpecieSalamence.Instance, // Pokemon Specie
				nickname, level,
				Dragon.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Salamence Builder only waiting for a Level
		/// </summary>
		public Salamence(int level)
		: base(
				373,
				SpecieSalamence.Instance, // Pokemon Specie
				"Salamence", level,
				Dragon.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Salamence Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Salamence() : base(
			373,
			SpecieSalamence.Instance, // Pokemon Specie
			Dragon.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}