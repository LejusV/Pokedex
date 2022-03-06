using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Quilladin Specie to store common natural stats of all Quilladins
	#region SpecieQuilladin
	public class SpecieQuilladin : PokemonSpecie
	{
#nullable enable
		private static SpecieQuilladin? _instance = null;
#nullable restore
        public static SpecieQuilladin Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieQuilladin();
                }
                return _instance;
            }
        }

		#region SpecieQuilladin Builder
		public SpecieQuilladin() : base(
			"Quilladin",
			61, // HPs
			78, 95, // Attack & Defense
			56, 58, // Special Attack & Defense
			57		
		)
		{
			this._height = 7;
			this._weight = 290;
		}
		#endregion
	}
	#endregion

	//Quilladin Pokemon Class
	#region Quilladin
	public class Quilladin : Pokemon
	{
		#region Quilladin Builders
		/// <summary>
		/// Quilladin Builder waiting for a Nickname & a Level
		/// </summary>
		public Quilladin(string nickname, int level)
		: base(
				651,
				SpecieQuilladin.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Quilladin Builder only waiting for a Level
		/// </summary>
		public Quilladin(int level)
		: base(
				651,
				SpecieQuilladin.Instance, // Pokemon Specie
				"Quilladin", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Quilladin Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Quilladin() : base(
			651,
			SpecieQuilladin.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}