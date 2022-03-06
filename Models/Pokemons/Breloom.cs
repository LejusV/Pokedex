using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Breloom Specie to store common natural stats of all Brelooms
	#region SpecieBreloom
	public class SpecieBreloom : PokemonSpecie
	{
#nullable enable
		private static SpecieBreloom? _instance = null;
#nullable restore
        public static SpecieBreloom Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBreloom();
                }
                return _instance;
            }
        }

		#region SpecieBreloom Builder
		public SpecieBreloom() : base(
			"Breloom",
			1.2,
			39.2,
			60, // HPs
			130, 80, // Attack & Defense
			60, 60, // Special Attack & Defense
			70		
		)
		{}
		#endregion
	}
	#endregion

	//Breloom Pokemon Class
	#region Breloom
	public class Breloom : Pokemon
	{
		#region Breloom Builders
		/// <summary>
		/// Breloom Builder waiting for a Nickname & a Level
		/// </summary>
		public Breloom(string nickname, int level)
		: base(
				286,
				SpecieBreloom.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Breloom Builder only waiting for a Level
		/// </summary>
		public Breloom(int level)
		: base(
				286,
				SpecieBreloom.Instance, // Pokemon Specie
				"Breloom", level,
				Grass.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Breloom Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Breloom() : base(
			286,
			SpecieBreloom.Instance, // Pokemon Specie
			Grass.Instance, Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}