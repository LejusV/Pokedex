using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Lunatone Specie to store common natural stats of all Lunatones
	#region SpecieLunatone
	public class SpecieLunatone : PokemonSpecie
	{
#nullable enable
		private static SpecieLunatone? _instance = null;
#nullable restore
        public static SpecieLunatone Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLunatone();
                }
                return _instance;
            }
        }

		#region SpecieLunatone Builder
		public SpecieLunatone() : base(
			"Lunatone",
			90, // HPs
			55, 65, // Attack & Defense
			95, 85, // Special Attack & Defense
			70		
		)
		{
			this._height = 10;
			this._weight = 1680;
		}
		#endregion
	}
	#endregion

	//Lunatone Pokemon Class
	#region Lunatone
	public class Lunatone : Pokemon
	{
		#region Lunatone Builders
		/// <summary>
		/// Lunatone Builder waiting for a Nickname & a Level
		/// </summary>
		public Lunatone(string nickname, int level)
		: base(
				337,
				SpecieLunatone.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lunatone Builder only waiting for a Level
		/// </summary>
		public Lunatone(int level)
		: base(
				337,
				SpecieLunatone.Instance, // Pokemon Specie
				"Lunatone", level,
				Rock.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lunatone Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Lunatone() : base(
			337,
			SpecieLunatone.Instance, // Pokemon Specie
			Rock.Instance, Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}