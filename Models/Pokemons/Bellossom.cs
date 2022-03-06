using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Bellossom Specie to store common natural stats of all Bellossoms
	#region SpecieBellossom
	public class SpecieBellossom : PokemonSpecie
	{
#nullable enable
		private static SpecieBellossom? _instance = null;
#nullable restore
        public static SpecieBellossom Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBellossom();
                }
                return _instance;
            }
        }

		#region SpecieBellossom Builder
		public SpecieBellossom() : base(
			"Bellossom",
			0.4,
			5.8,
			75, // HPs
			80, 95, // Attack & Defense
			90, 100, // Special Attack & Defense
			50		
		)
		{}
		#endregion
	}
	#endregion

	//Bellossom Pokemon Class
	#region Bellossom
	public class Bellossom : Pokemon
	{
		#region Bellossom Builders
		/// <summary>
		/// Bellossom Builder waiting for a Nickname & a Level
		/// </summary>
		public Bellossom(string nickname, int level)
		: base(
				182,
				SpecieBellossom.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bellossom Builder only waiting for a Level
		/// </summary>
		public Bellossom(int level)
		: base(
				182,
				SpecieBellossom.Instance, // Pokemon Specie
				"Bellossom", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bellossom Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Bellossom() : base(
			182,
			SpecieBellossom.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}