using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Flapple Specie to store common natural stats of all Flapples
	#region SpecieFlapple
	public class SpecieFlapple : PokemonSpecie
	{
#nullable enable
		private static SpecieFlapple? _instance = null;
#nullable restore
        public static SpecieFlapple Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieFlapple();
                }
                return _instance;
            }
        }

		#region SpecieFlapple Builder
		public SpecieFlapple() : base(
			"Flapple",
			0.3,
			1.0,
			70, // HPs
			110, 80, // Attack & Defense
			95, 60, // Special Attack & Defense
			70		
		)
		{}
		#endregion
	}
	#endregion

	//Flapple Pokemon Class
	#region Flapple
	public class Flapple : Pokemon
	{
		#region Flapple Builders
		/// <summary>
		/// Flapple Builder waiting for a Nickname & a Level
		/// </summary>
		public Flapple(string nickname, int level)
		: base(
				841,
				SpecieFlapple.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Flapple Builder only waiting for a Level
		/// </summary>
		public Flapple(int level)
		: base(
				841,
				SpecieFlapple.Instance, // Pokemon Specie
				"Flapple", level,
				Grass.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Flapple Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Flapple() : base(
			841,
			SpecieFlapple.Instance, // Pokemon Specie
			Grass.Instance, Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}