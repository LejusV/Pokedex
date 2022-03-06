using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Dusknoir Specie to store common natural stats of all Dusknoirs
	#region SpecieDusknoir
	public class SpecieDusknoir : PokemonSpecie
	{
#nullable enable
		private static SpecieDusknoir? _instance = null;
#nullable restore
        public static SpecieDusknoir Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDusknoir();
                }
                return _instance;
            }
        }

		#region SpecieDusknoir Builder
		public SpecieDusknoir() : base(
			"Dusknoir",
			45, // HPs
			100, 135, // Attack & Defense
			65, 135, // Special Attack & Defense
			45		
		)
		{
			this._height = 22;
			this._weight = 1066;
		}
		#endregion
	}
	#endregion

	//Dusknoir Pokemon Class
	#region Dusknoir
	public class Dusknoir : Pokemon
	{
		#region Dusknoir Builders
		/// <summary>
		/// Dusknoir Builder waiting for a Nickname & a Level
		/// </summary>
		public Dusknoir(string nickname, int level)
		: base(
				477,
				SpecieDusknoir.Instance, // Pokemon Specie
				nickname, level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dusknoir Builder only waiting for a Level
		/// </summary>
		public Dusknoir(int level)
		: base(
				477,
				SpecieDusknoir.Instance, // Pokemon Specie
				"Dusknoir", level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dusknoir Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Dusknoir() : base(
			477,
			SpecieDusknoir.Instance, // Pokemon Specie
			Ghost.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}