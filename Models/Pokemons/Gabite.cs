using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Gabite Specie to store common natural stats of all Gabites
	#region SpecieGabite
	public class SpecieGabite : PokemonSpecie
	{
#nullable enable
		private static SpecieGabite? _instance = null;
#nullable restore
        public static SpecieGabite Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGabite();
                }
                return _instance;
            }
        }

		#region SpecieGabite Builder
		public SpecieGabite() : base(
			"Gabite",
			68, // HPs
			90, 65, // Attack & Defense
			50, 55, // Special Attack & Defense
			82		
		)
		{
			this._height = 14;
			this._weight = 560;
		}
		#endregion
	}
	#endregion

	//Gabite Pokemon Class
	#region Gabite
	public class Gabite : Pokemon
	{
		#region Gabite Builders
		/// <summary>
		/// Gabite Builder waiting for a Nickname & a Level
		/// </summary>
		public Gabite(string nickname, int level)
		: base(
				444,
				SpecieGabite.Instance, // Pokemon Specie
				nickname, level,
				Dragon.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gabite Builder only waiting for a Level
		/// </summary>
		public Gabite(int level)
		: base(
				444,
				SpecieGabite.Instance, // Pokemon Specie
				"Gabite", level,
				Dragon.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gabite Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Gabite() : base(
			444,
			SpecieGabite.Instance, // Pokemon Specie
			Dragon.Instance, Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}