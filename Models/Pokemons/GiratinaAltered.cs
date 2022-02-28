using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Giratina-Altered Specie to store common natural stats of all Giratina-Altereds
	#region SpecieGiratina-Altered
	public class SpecieGiratinaAltered : PokemonSpecie
	{
#nullable enable
		private static SpecieGiratinaAltered? _instance = null;
#nullable restore
        public static SpecieGiratinaAltered Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGiratinaAltered();
                }
                return _instance;
            }
        }

		#region SpecieGiratina-Altered Builder
		public SpecieGiratinaAltered() : base(
			"Giratina-Altered",
			150, // HPs
			100, 120, // Attack & Defense
			100, 120, // Special Attack & Defense
			90			
		) {}
		#endregion
	}
	#endregion

	//Giratina-Altered Pokemon Class
	#region Giratina-Altered
	public class GiratinaAltered : Pokemon
	{
		#region Giratina-Altered Builders
		/// <summary>
		/// Giratina-Altered Builder waiting for a Nickname & a Level
		/// </summary>
		public GiratinaAltered(string nickname, int level)
		: base(
				487,
				SpecieGiratinaAltered.Instance, // Pokemon Specie
				nickname, level,
				Ghost.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Giratina-Altered Builder only waiting for a Level
		/// </summary>
		public GiratinaAltered(int level)
		: base(
				487,
				SpecieGiratinaAltered.Instance, // Pokemon Specie
				"Giratina-Altered", level,
				Ghost.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Giratina-Altered Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public GiratinaAltered() : base(
			487,
			SpecieGiratinaAltered.Instance, // Pokemon Specie
			Ghost.Instance, Dragon.Instance			
		) {}
		#endregion
	}
	#endregion
}