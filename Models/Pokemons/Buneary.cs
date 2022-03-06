using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Buneary Specie to store common natural stats of all Bunearys
	#region SpecieBuneary
	public class SpecieBuneary : PokemonSpecie
	{
#nullable enable
		private static SpecieBuneary? _instance = null;
#nullable restore
        public static SpecieBuneary Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBuneary();
                }
                return _instance;
            }
        }

		#region SpecieBuneary Builder
		public SpecieBuneary() : base(
			"Buneary",
			55, // HPs
			66, 44, // Attack & Defense
			44, 56, // Special Attack & Defense
			85		
		)
		{
			this._height = 4;
			this._weight = 55;
		}
		#endregion
	}
	#endregion

	//Buneary Pokemon Class
	#region Buneary
	public class Buneary : Pokemon
	{
		#region Buneary Builders
		/// <summary>
		/// Buneary Builder waiting for a Nickname & a Level
		/// </summary>
		public Buneary(string nickname, int level)
		: base(
				427,
				SpecieBuneary.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Buneary Builder only waiting for a Level
		/// </summary>
		public Buneary(int level)
		: base(
				427,
				SpecieBuneary.Instance, // Pokemon Specie
				"Buneary", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Buneary Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Buneary() : base(
			427,
			SpecieBuneary.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}