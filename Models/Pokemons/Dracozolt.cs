using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Dracozolt Specie to store common natural stats of all Dracozolts
	#region SpecieDracozolt
	public class SpecieDracozolt : PokemonSpecie
	{
#nullable enable
		private static SpecieDracozolt? _instance = null;
#nullable restore
        public static SpecieDracozolt Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDracozolt();
                }
                return _instance;
            }
        }

		#region SpecieDracozolt Builder
		public SpecieDracozolt() : base(
			"Dracozolt",
			90, // HPs
			100, 90, // Attack & Defense
			80, 70, // Special Attack & Defense
			75		
		)
		{
			this._height = 18;
			this._weight = 1900;
		}
		#endregion
	}
	#endregion

	//Dracozolt Pokemon Class
	#region Dracozolt
	public class Dracozolt : Pokemon
	{
		#region Dracozolt Builders
		/// <summary>
		/// Dracozolt Builder waiting for a Nickname & a Level
		/// </summary>
		public Dracozolt(string nickname, int level)
		: base(
				880,
				SpecieDracozolt.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dracozolt Builder only waiting for a Level
		/// </summary>
		public Dracozolt(int level)
		: base(
				880,
				SpecieDracozolt.Instance, // Pokemon Specie
				"Dracozolt", level,
				Electric.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dracozolt Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Dracozolt() : base(
			880,
			SpecieDracozolt.Instance, // Pokemon Specie
			Electric.Instance, Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}