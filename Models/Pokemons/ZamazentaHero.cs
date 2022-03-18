using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Zamazenta-Hero Species to store common natural stats of all Zamazenta-Heros
	#region SpeciesZamazenta-Hero
	public class SpeciesZamazentaHero : PokemonSpecies
	{
#nullable enable
		private static SpeciesZamazentaHero? _instance = null;
#nullable restore
        public static SpeciesZamazentaHero Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesZamazentaHero();
                }
                return _instance;
            }
        }

		#region SpeciesZamazenta-Hero Constructor
		public SpeciesZamazentaHero() : base(
			889,
			"Zamazenta-Hero",
			2.9,
			210.0,
			92, // HPs
			130, 115, // Attack & Defense
			80, 115, // Special Attack & Defense
			138		
		)
		{
			InitMovesList();
		}
		#endregion

		#region Methods
		private void InitMovesList()
		{
			_moveList = new List<string>()
			{
				
			};
		}
		#endregion
	}
	#endregion

	//Zamazenta-Hero PokemonInstance Class
	#region Zamazenta-Hero
	public class ZamazentaHeroInstance : PokemonInstance
	{
		#region Zamazenta-Hero Constructors
		/// <summary>
		/// Zamazenta-Hero Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ZamazentaHeroInstance(string nickname, int level)
		: base(
				SpeciesZamazentaHero.Instance, // Pokemon Species
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
		public ZamazentaHeroInstance(int level)
		: base(
				SpeciesZamazentaHero.Instance, // PokemonInstance Species
				"Zamazenta-Hero", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zamazenta-Hero Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public ZamazentaHeroInstance() : base(
			SpeciesZamazentaHero.Instance, // PokemonInstance Species
			Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}