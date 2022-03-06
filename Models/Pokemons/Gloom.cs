using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Gloom Specie to store common natural stats of all Glooms
	#region SpecieGloom
	public class SpecieGloom : PokemonSpecie
	{
#nullable enable
		private static SpecieGloom? _instance = null;
#nullable restore
        public static SpecieGloom Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGloom();
                }
                return _instance;
            }
        }

		#region SpecieGloom Builder
		public SpecieGloom() : base(
			"Gloom",
			60, // HPs
			65, 70, // Attack & Defense
			85, 75, // Special Attack & Defense
			40		
		)
		{
			this._height = 8;
			this._weight = 86;
		}
		#endregion
	}
	#endregion

	//Gloom Pokemon Class
	#region Gloom
	public class Gloom : Pokemon
	{
		#region Gloom Builders
		/// <summary>
		/// Gloom Builder waiting for a Nickname & a Level
		/// </summary>
		public Gloom(string nickname, int level)
		: base(
				44,
				SpecieGloom.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gloom Builder only waiting for a Level
		/// </summary>
		public Gloom(int level)
		: base(
				44,
				SpecieGloom.Instance, // Pokemon Specie
				"Gloom", level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gloom Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Gloom() : base(
			44,
			SpecieGloom.Instance, // Pokemon Specie
			Grass.Instance, Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}