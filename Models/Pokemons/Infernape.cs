using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Infernape Specie to store common natural stats of all Infernapes
	#region SpecieInfernape
	public class SpecieInfernape : PokemonSpecie
	{
#nullable enable
		private static SpecieInfernape? _instance = null;
#nullable restore
        public static SpecieInfernape Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieInfernape();
                }
                return _instance;
            }
        }

		#region SpecieInfernape Builder
		public SpecieInfernape() : base(
			"Infernape",
			76, // HPs
			104, 71, // Attack & Defense
			104, 71, // Special Attack & Defense
			108		
		)
		{
			this._height = 12;
			this._weight = 550;
		}
		#endregion
	}
	#endregion

	//Infernape Pokemon Class
	#region Infernape
	public class Infernape : Pokemon
	{
		#region Infernape Builders
		/// <summary>
		/// Infernape Builder waiting for a Nickname & a Level
		/// </summary>
		public Infernape(string nickname, int level)
		: base(
				392,
				SpecieInfernape.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Infernape Builder only waiting for a Level
		/// </summary>
		public Infernape(int level)
		: base(
				392,
				SpecieInfernape.Instance, // Pokemon Specie
				"Infernape", level,
				Fire.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Infernape Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Infernape() : base(
			392,
			SpecieInfernape.Instance, // Pokemon Specie
			Fire.Instance, Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}