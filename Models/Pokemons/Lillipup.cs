using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Lillipup Specie to store common natural stats of all Lillipups
	#region SpecieLillipup
	public class SpecieLillipup : PokemonSpecie
	{
#nullable enable
		private static SpecieLillipup? _instance = null;
#nullable restore
        public static SpecieLillipup Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLillipup();
                }
                return _instance;
            }
        }

		#region SpecieLillipup Builder
		public SpecieLillipup() : base(
			"Lillipup",
			45, // HPs
			60, 45, // Attack & Defense
			25, 45, // Special Attack & Defense
			55		
		)
		{
			this._height = 4;
			this._weight = 41;
		}
		#endregion
	}
	#endregion

	//Lillipup Pokemon Class
	#region Lillipup
	public class Lillipup : Pokemon
	{
		#region Lillipup Builders
		/// <summary>
		/// Lillipup Builder waiting for a Nickname & a Level
		/// </summary>
		public Lillipup(string nickname, int level)
		: base(
				506,
				SpecieLillipup.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lillipup Builder only waiting for a Level
		/// </summary>
		public Lillipup(int level)
		: base(
				506,
				SpecieLillipup.Instance, // Pokemon Specie
				"Lillipup", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lillipup Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Lillipup() : base(
			506,
			SpecieLillipup.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}