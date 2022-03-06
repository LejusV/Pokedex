using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Sinistea Specie to store common natural stats of all Sinisteas
	#region SpecieSinistea
	public class SpecieSinistea : PokemonSpecie
	{
#nullable enable
		private static SpecieSinistea? _instance = null;
#nullable restore
        public static SpecieSinistea Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSinistea();
                }
                return _instance;
            }
        }

		#region SpecieSinistea Builder
		public SpecieSinistea() : base(
			"Sinistea",
			0.1,
			0.2,
			40, // HPs
			45, 45, // Attack & Defense
			74, 54, // Special Attack & Defense
			50		
		)
		{}
		#endregion
	}
	#endregion

	//Sinistea Pokemon Class
	#region Sinistea
	public class Sinistea : Pokemon
	{
		#region Sinistea Builders
		/// <summary>
		/// Sinistea Builder waiting for a Nickname & a Level
		/// </summary>
		public Sinistea(string nickname, int level)
		: base(
				854,
				SpecieSinistea.Instance, // Pokemon Specie
				nickname, level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sinistea Builder only waiting for a Level
		/// </summary>
		public Sinistea(int level)
		: base(
				854,
				SpecieSinistea.Instance, // Pokemon Specie
				"Sinistea", level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sinistea Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Sinistea() : base(
			854,
			SpecieSinistea.Instance, // Pokemon Specie
			Ghost.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}