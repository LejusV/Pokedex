using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Gallade Specie to store common natural stats of all Gallades
	#region SpecieGallade
	public class SpecieGallade : PokemonSpecie
	{
#nullable enable
		private static SpecieGallade? _instance = null;
#nullable restore
        public static SpecieGallade Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGallade();
                }
                return _instance;
            }
        }

		#region SpecieGallade Builder
		public SpecieGallade() : base(
			"Gallade",
			68, // HPs
			125, 65, // Attack & Defense
			65, 115, // Special Attack & Defense
			80		
		)
		{
			this._height = 16;
			this._weight = 520;
		}
		#endregion
	}
	#endregion

	//Gallade Pokemon Class
	#region Gallade
	public class Gallade : Pokemon
	{
		#region Gallade Builders
		/// <summary>
		/// Gallade Builder waiting for a Nickname & a Level
		/// </summary>
		public Gallade(string nickname, int level)
		: base(
				475,
				SpecieGallade.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gallade Builder only waiting for a Level
		/// </summary>
		public Gallade(int level)
		: base(
				475,
				SpecieGallade.Instance, // Pokemon Specie
				"Gallade", level,
				Psychic.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gallade Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Gallade() : base(
			475,
			SpecieGallade.Instance, // Pokemon Specie
			Psychic.Instance, Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}