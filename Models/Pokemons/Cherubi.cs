using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Cherubi Specie to store common natural stats of all Cherubis
	#region SpecieCherubi
	public class SpecieCherubi : PokemonSpecie
	{
#nullable enable
		private static SpecieCherubi? _instance = null;
#nullable restore
        public static SpecieCherubi Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCherubi();
                }
                return _instance;
            }
        }

		#region SpecieCherubi Builder
		public SpecieCherubi() : base(
			"Cherubi",
			45, // HPs
			35, 45, // Attack & Defense
			62, 53, // Special Attack & Defense
			35		
		)
		{
			this._height = 4;
			this._weight = 33;
		}
		#endregion
	}
	#endregion

	//Cherubi Pokemon Class
	#region Cherubi
	public class Cherubi : Pokemon
	{
		#region Cherubi Builders
		/// <summary>
		/// Cherubi Builder waiting for a Nickname & a Level
		/// </summary>
		public Cherubi(string nickname, int level)
		: base(
				420,
				SpecieCherubi.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cherubi Builder only waiting for a Level
		/// </summary>
		public Cherubi(int level)
		: base(
				420,
				SpecieCherubi.Instance, // Pokemon Specie
				"Cherubi", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cherubi Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Cherubi() : base(
			420,
			SpecieCherubi.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}