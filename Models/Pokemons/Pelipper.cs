using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Pelipper Specie to store common natural stats of all Pelippers
	#region SpeciePelipper
	public class SpeciePelipper : PokemonSpecie
	{
#nullable enable
		private static SpeciePelipper? _instance = null;
#nullable restore
        public static SpeciePelipper Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePelipper();
                }
                return _instance;
            }
        }

		#region SpeciePelipper Builder
		public SpeciePelipper() : base(
			"Pelipper",
			60, // HPs
			50, 100, // Attack & Defense
			95, 70, // Special Attack & Defense
			65			
		) {}
		#endregion
	}
	#endregion

	//Pelipper Pokemon Class
	#region Pelipper
	public class Pelipper : Pokemon
	{
		#region Pelipper Builders
		/// <summary>
		/// Pelipper Builder waiting for a Nickname & a Level
		/// </summary>
		public Pelipper(string nickname, int level)
		: base(
				279,
				SpeciePelipper.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pelipper Builder only waiting for a Level
		/// </summary>
		public Pelipper(int level)
		: base(
				279,
				SpeciePelipper.Instance, // Pokemon Specie
				"Pelipper", level,
				Water.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pelipper Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Pelipper() : base(
			279,
			SpeciePelipper.Instance, // Pokemon Specie
			Water.Instance, Flying.Instance			
		) {}
		#endregion
	}
	#endregion
}