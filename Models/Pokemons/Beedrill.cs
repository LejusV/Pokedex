using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Beedrill Specie to store common natural stats of all Beedrills
	#region SpecieBeedrill
	public class SpecieBeedrill : PokemonSpecie
	{
#nullable enable
		private static SpecieBeedrill? _instance = null;
#nullable restore
        public static SpecieBeedrill Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBeedrill();
                }
                return _instance;
            }
        }

		#region SpecieBeedrill Builder
		public SpecieBeedrill() : base(
			"Beedrill",
			1.0,
			29.5,
			65, // HPs
			90, 40, // Attack & Defense
			45, 80, // Special Attack & Defense
			75		
		)
		{}
		#endregion
	}
	#endregion

	//Beedrill Pokemon Class
	#region Beedrill
	public class Beedrill : Pokemon
	{
		#region Beedrill Builders
		/// <summary>
		/// Beedrill Builder waiting for a Nickname & a Level
		/// </summary>
		public Beedrill(string nickname, int level)
		: base(
				15,
				SpecieBeedrill.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Beedrill Builder only waiting for a Level
		/// </summary>
		public Beedrill(int level)
		: base(
				15,
				SpecieBeedrill.Instance, // Pokemon Specie
				"Beedrill", level,
				Bug.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Beedrill Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Beedrill() : base(
			15,
			SpecieBeedrill.Instance, // Pokemon Specie
			Bug.Instance, Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}