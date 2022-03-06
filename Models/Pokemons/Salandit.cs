using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Salandit Specie to store common natural stats of all Salandits
	#region SpecieSalandit
	public class SpecieSalandit : PokemonSpecie
	{
#nullable enable
		private static SpecieSalandit? _instance = null;
#nullable restore
        public static SpecieSalandit Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSalandit();
                }
                return _instance;
            }
        }

		#region SpecieSalandit Builder
		public SpecieSalandit() : base(
			"Salandit",
			0.6,
			4.8,
			48, // HPs
			44, 40, // Attack & Defense
			71, 40, // Special Attack & Defense
			77		
		)
		{}
		#endregion
	}
	#endregion

	//Salandit Pokemon Class
	#region Salandit
	public class Salandit : Pokemon
	{
		#region Salandit Builders
		/// <summary>
		/// Salandit Builder waiting for a Nickname & a Level
		/// </summary>
		public Salandit(string nickname, int level)
		: base(
				757,
				SpecieSalandit.Instance, // Pokemon Specie
				nickname, level,
				Poison.Instance, Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Salandit Builder only waiting for a Level
		/// </summary>
		public Salandit(int level)
		: base(
				757,
				SpecieSalandit.Instance, // Pokemon Specie
				"Salandit", level,
				Poison.Instance, Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Salandit Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Salandit() : base(
			757,
			SpecieSalandit.Instance, // Pokemon Specie
			Poison.Instance, Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}