using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Cacnea Specie to store common natural stats of all Cacneas
	#region SpecieCacnea
	public class SpecieCacnea : PokemonSpecie
	{
#nullable enable
		private static SpecieCacnea? _instance = null;
#nullable restore
        public static SpecieCacnea Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCacnea();
                }
                return _instance;
            }
        }

		#region SpecieCacnea Builder
		public SpecieCacnea() : base(
			"Cacnea",
			50, // HPs
			85, 40, // Attack & Defense
			85, 40, // Special Attack & Defense
			35		
		)
		{
			this._height = 4;
			this._weight = 513;
		}
		#endregion
	}
	#endregion

	//Cacnea Pokemon Class
	#region Cacnea
	public class Cacnea : Pokemon
	{
		#region Cacnea Builders
		/// <summary>
		/// Cacnea Builder waiting for a Nickname & a Level
		/// </summary>
		public Cacnea(string nickname, int level)
		: base(
				331,
				SpecieCacnea.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cacnea Builder only waiting for a Level
		/// </summary>
		public Cacnea(int level)
		: base(
				331,
				SpecieCacnea.Instance, // Pokemon Specie
				"Cacnea", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cacnea Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Cacnea() : base(
			331,
			SpecieCacnea.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}