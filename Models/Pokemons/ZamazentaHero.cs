using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Zamazenta-Hero Specie to store common natural stats of all Zamazenta-Heros
	#region SpecieZamazenta-Hero
	public class SpecieZamazentaHero : PokemonSpecie
	{
#nullable enable
		private static SpecieZamazentaHero? _instance = null;
#nullable restore
        public static SpecieZamazentaHero Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieZamazentaHero();
                }
                return _instance;
            }
        }

		#region SpecieZamazenta-Hero Builder
		public SpecieZamazentaHero() : base(
			"Zamazenta-Hero",
			92, // HPs
			130, 115, // Attack & Defense
			80, 115, // Special Attack & Defense
			138			
		) {}
		#endregion
	}
	#endregion

	//Zamazenta-Hero Pokemon Class
	#region Zamazenta-Hero
	public class ZamazentaHero : Pokemon
	{
		#region Zamazenta-Hero Builders
		/// <summary>
		/// Zamazenta-Hero Builder waiting for a Nickname & a Level
		/// </summary>
		public ZamazentaHero(string nickname, int level)
		: base(
				889,
				SpecieZamazentaHero.Instance, // Pokemon Specie
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zamazenta-Hero Builder only waiting for a Level
		/// </summary>
		public ZamazentaHero(int level)
		: base(
				889,
				SpecieZamazentaHero.Instance, // Pokemon Specie
				"Zamazenta-Hero", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zamazenta-Hero Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public ZamazentaHero() : base(
			889,
			SpecieZamazentaHero.Instance, // Pokemon Specie
			Fighting.Instance			
		) {}
		#endregion
	}
	#endregion
}