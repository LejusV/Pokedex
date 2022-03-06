using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Landorus-Incarnate Specie to store common natural stats of all Landorus-Incarnates
	#region SpecieLandorus-Incarnate
	public class SpecieLandorusIncarnate : PokemonSpecie
	{
#nullable enable
		private static SpecieLandorusIncarnate? _instance = null;
#nullable restore
        public static SpecieLandorusIncarnate Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLandorusIncarnate();
                }
                return _instance;
            }
        }

		#region SpecieLandorus-Incarnate Builder
		public SpecieLandorusIncarnate() : base(
			"Landorus-Incarnate",
			1.5,
			68.0,
			89, // HPs
			125, 90, // Attack & Defense
			115, 80, // Special Attack & Defense
			101		
		)
		{}
		#endregion
	}
	#endregion

	//Landorus-Incarnate Pokemon Class
	#region Landorus-Incarnate
	public class LandorusIncarnate : Pokemon
	{
		#region Landorus-Incarnate Builders
		/// <summary>
		/// Landorus-Incarnate Builder waiting for a Nickname & a Level
		/// </summary>
		public LandorusIncarnate(string nickname, int level)
		: base(
				645,
				SpecieLandorusIncarnate.Instance, // Pokemon Specie
				nickname, level,
				Ground.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Landorus-Incarnate Builder only waiting for a Level
		/// </summary>
		public LandorusIncarnate(int level)
		: base(
				645,
				SpecieLandorusIncarnate.Instance, // Pokemon Specie
				"Landorus-Incarnate", level,
				Ground.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Landorus-Incarnate Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public LandorusIncarnate() : base(
			645,
			SpecieLandorusIncarnate.Instance, // Pokemon Specie
			Ground.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}