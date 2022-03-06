using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Spewpa Specie to store common natural stats of all Spewpas
	#region SpecieSpewpa
	public class SpecieSpewpa : PokemonSpecie
	{
#nullable enable
		private static SpecieSpewpa? _instance = null;
#nullable restore
        public static SpecieSpewpa Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSpewpa();
                }
                return _instance;
            }
        }

		#region SpecieSpewpa Builder
		public SpecieSpewpa() : base(
			"Spewpa",
			0.3,
			8.4,
			45, // HPs
			22, 60, // Attack & Defense
			27, 30, // Special Attack & Defense
			29		
		)
		{}
		#endregion
	}
	#endregion

	//Spewpa Pokemon Class
	#region Spewpa
	public class Spewpa : Pokemon
	{
		#region Spewpa Builders
		/// <summary>
		/// Spewpa Builder waiting for a Nickname & a Level
		/// </summary>
		public Spewpa(string nickname, int level)
		: base(
				665,
				SpecieSpewpa.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Spewpa Builder only waiting for a Level
		/// </summary>
		public Spewpa(int level)
		: base(
				665,
				SpecieSpewpa.Instance, // Pokemon Specie
				"Spewpa", level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Spewpa Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Spewpa() : base(
			665,
			SpecieSpewpa.Instance, // Pokemon Specie
			Bug.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}