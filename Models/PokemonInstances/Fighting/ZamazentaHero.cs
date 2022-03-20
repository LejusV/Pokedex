using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Zamazenta-Hero PokemonInstance Class
	#region Zamazenta-Hero
	public class ZamazentaHero : PokemonInstance
	{
		#region Zamazenta-Hero Constructors
		/// <summary>
		/// Zamazenta-Hero Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ZamazentaHero(string nickname, int level)
		: base(
				ZamazentaHeroSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zamazenta-Hero Constructor only waiting for a Level
		/// </summary>
		public ZamazentaHero(int level)
		: this( "Zamazenta-Hero", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zamazenta-Hero Constructor waiting for no params
		/// </summary>
		/*
		public ZamazentaHero() : this( "Zamazenta-Hero", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}