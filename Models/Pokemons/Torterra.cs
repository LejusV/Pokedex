using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Torterra Specie to store common natural stats of all Torterras
	#region SpecieTorterra
	public class SpecieTorterra : PokemonSpecie
	{
#nullable enable
		private static SpecieTorterra? _instance = null;
#nullable restore
        public static SpecieTorterra Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTorterra();
                }
                return _instance;
            }
        }

		#region SpecieTorterra Builder
		public SpecieTorterra() : base(
			"Torterra",
			2.2,
			310.0,
			95, // HPs
			109, 105, // Attack & Defense
			75, 85, // Special Attack & Defense
			56		
		)
		{}
		#endregion
	}
	#endregion

	//Torterra Pokemon Class
	#region Torterra
	public class Torterra : Pokemon
	{
		#region Torterra Builders
		/// <summary>
		/// Torterra Builder waiting for a Nickname & a Level
		/// </summary>
		public Torterra(string nickname, int level)
		: base(
				389,
				SpecieTorterra.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Torterra Builder only waiting for a Level
		/// </summary>
		public Torterra(int level)
		: base(
				389,
				SpecieTorterra.Instance, // Pokemon Specie
				"Torterra", level,
				Grass.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Torterra Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Torterra() : base(
			389,
			SpecieTorterra.Instance, // Pokemon Specie
			Grass.Instance, Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}