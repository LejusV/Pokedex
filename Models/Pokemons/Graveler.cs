using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Graveler Specie to store common natural stats of all Gravelers
	#region SpecieGraveler
	public class SpecieGraveler : PokemonSpecie
	{
#nullable enable
		private static SpecieGraveler? _instance = null;
#nullable restore
        public static SpecieGraveler Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGraveler();
                }
                return _instance;
            }
        }

		#region SpecieGraveler Builder
		public SpecieGraveler() : base(
			"Graveler",
			1.0,
			105.0,
			55, // HPs
			95, 115, // Attack & Defense
			45, 45, // Special Attack & Defense
			35		
		)
		{}
		#endregion
	}
	#endregion

	//Graveler Pokemon Class
	#region Graveler
	public class Graveler : Pokemon
	{
		#region Graveler Builders
		/// <summary>
		/// Graveler Builder waiting for a Nickname & a Level
		/// </summary>
		public Graveler(string nickname, int level)
		: base(
				75,
				SpecieGraveler.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Graveler Builder only waiting for a Level
		/// </summary>
		public Graveler(int level)
		: base(
				75,
				SpecieGraveler.Instance, // Pokemon Specie
				"Graveler", level,
				Rock.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Graveler Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Graveler() : base(
			75,
			SpecieGraveler.Instance, // Pokemon Specie
			Rock.Instance, Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}