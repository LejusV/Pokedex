using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Sigilyph Specie to store common natural stats of all Sigilyphs
	#region SpecieSigilyph
	public class SpecieSigilyph : PokemonSpecie
	{
#nullable enable
		private static SpecieSigilyph? _instance = null;
#nullable restore
        public static SpecieSigilyph Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSigilyph();
                }
                return _instance;
            }
        }

		#region SpecieSigilyph Builder
		public SpecieSigilyph() : base(
			"Sigilyph",
			72, // HPs
			58, 80, // Attack & Defense
			103, 80, // Special Attack & Defense
			97		
		)
		{
			this._height = 14;
			this._weight = 140;
		}
		#endregion
	}
	#endregion

	//Sigilyph Pokemon Class
	#region Sigilyph
	public class Sigilyph : Pokemon
	{
		#region Sigilyph Builders
		/// <summary>
		/// Sigilyph Builder waiting for a Nickname & a Level
		/// </summary>
		public Sigilyph(string nickname, int level)
		: base(
				561,
				SpecieSigilyph.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sigilyph Builder only waiting for a Level
		/// </summary>
		public Sigilyph(int level)
		: base(
				561,
				SpecieSigilyph.Instance, // Pokemon Specie
				"Sigilyph", level,
				Psychic.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sigilyph Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Sigilyph() : base(
			561,
			SpecieSigilyph.Instance, // Pokemon Specie
			Psychic.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}