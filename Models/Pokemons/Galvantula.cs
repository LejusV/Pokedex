using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Galvantula Specie to store common natural stats of all Galvantulas
	#region SpecieGalvantula
	public class SpecieGalvantula : PokemonSpecie
	{
#nullable enable
		private static SpecieGalvantula? _instance = null;
#nullable restore
        public static SpecieGalvantula Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGalvantula();
                }
                return _instance;
            }
        }

		#region SpecieGalvantula Builder
		public SpecieGalvantula() : base(
			"Galvantula",
			70, // HPs
			77, 60, // Attack & Defense
			97, 60, // Special Attack & Defense
			108		
		)
		{
			this._height = 8;
			this._weight = 143;
		}
		#endregion
	}
	#endregion

	//Galvantula Pokemon Class
	#region Galvantula
	public class Galvantula : Pokemon
	{
		#region Galvantula Builders
		/// <summary>
		/// Galvantula Builder waiting for a Nickname & a Level
		/// </summary>
		public Galvantula(string nickname, int level)
		: base(
				596,
				SpecieGalvantula.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Galvantula Builder only waiting for a Level
		/// </summary>
		public Galvantula(int level)
		: base(
				596,
				SpecieGalvantula.Instance, // Pokemon Specie
				"Galvantula", level,
				Bug.Instance, Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Galvantula Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Galvantula() : base(
			596,
			SpecieGalvantula.Instance, // Pokemon Specie
			Bug.Instance, Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}