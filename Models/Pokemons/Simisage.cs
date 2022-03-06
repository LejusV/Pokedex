using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Simisage Specie to store common natural stats of all Simisages
	#region SpecieSimisage
	public class SpecieSimisage : PokemonSpecie
	{
#nullable enable
		private static SpecieSimisage? _instance = null;
#nullable restore
        public static SpecieSimisage Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSimisage();
                }
                return _instance;
            }
        }

		#region SpecieSimisage Builder
		public SpecieSimisage() : base(
			"Simisage",
			75, // HPs
			98, 63, // Attack & Defense
			98, 63, // Special Attack & Defense
			101		
		)
		{
			this._height = 11;
			this._weight = 305;
		}
		#endregion
	}
	#endregion

	//Simisage Pokemon Class
	#region Simisage
	public class Simisage : Pokemon
	{
		#region Simisage Builders
		/// <summary>
		/// Simisage Builder waiting for a Nickname & a Level
		/// </summary>
		public Simisage(string nickname, int level)
		: base(
				512,
				SpecieSimisage.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Simisage Builder only waiting for a Level
		/// </summary>
		public Simisage(int level)
		: base(
				512,
				SpecieSimisage.Instance, // Pokemon Specie
				"Simisage", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Simisage Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Simisage() : base(
			512,
			SpecieSimisage.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}