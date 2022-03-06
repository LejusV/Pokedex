using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Tsareena Specie to store common natural stats of all Tsareenas
	#region SpecieTsareena
	public class SpecieTsareena : PokemonSpecie
	{
#nullable enable
		private static SpecieTsareena? _instance = null;
#nullable restore
        public static SpecieTsareena Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTsareena();
                }
                return _instance;
            }
        }

		#region SpecieTsareena Builder
		public SpecieTsareena() : base(
			"Tsareena",
			1.2,
			21.4,
			72, // HPs
			120, 98, // Attack & Defense
			50, 98, // Special Attack & Defense
			72		
		)
		{}
		#endregion
	}
	#endregion

	//Tsareena Pokemon Class
	#region Tsareena
	public class Tsareena : Pokemon
	{
		#region Tsareena Builders
		/// <summary>
		/// Tsareena Builder waiting for a Nickname & a Level
		/// </summary>
		public Tsareena(string nickname, int level)
		: base(
				763,
				SpecieTsareena.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tsareena Builder only waiting for a Level
		/// </summary>
		public Tsareena(int level)
		: base(
				763,
				SpecieTsareena.Instance, // Pokemon Specie
				"Tsareena", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tsareena Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Tsareena() : base(
			763,
			SpecieTsareena.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}