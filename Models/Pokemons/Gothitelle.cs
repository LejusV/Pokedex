using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Gothitelle Specie to store common natural stats of all Gothitelles
	#region SpecieGothitelle
	public class SpecieGothitelle : PokemonSpecie
	{
#nullable enable
		private static SpecieGothitelle? _instance = null;
#nullable restore
        public static SpecieGothitelle Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGothitelle();
                }
                return _instance;
            }
        }

		#region SpecieGothitelle Builder
		public SpecieGothitelle() : base(
			"Gothitelle",
			1.5,
			44.0,
			70, // HPs
			55, 95, // Attack & Defense
			95, 110, // Special Attack & Defense
			65		
		)
		{}
		#endregion
	}
	#endregion

	//Gothitelle Pokemon Class
	#region Gothitelle
	public class Gothitelle : Pokemon
	{
		#region Gothitelle Builders
		/// <summary>
		/// Gothitelle Builder waiting for a Nickname & a Level
		/// </summary>
		public Gothitelle(string nickname, int level)
		: base(
				576,
				SpecieGothitelle.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gothitelle Builder only waiting for a Level
		/// </summary>
		public Gothitelle(int level)
		: base(
				576,
				SpecieGothitelle.Instance, // Pokemon Specie
				"Gothitelle", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gothitelle Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Gothitelle() : base(
			576,
			SpecieGothitelle.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}