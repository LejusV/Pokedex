using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Zacian-Hero PokemonInstance Class
	#region Zacian-Hero
	public class ZacianHero : PokemonInstance
	{
		#region Zacian-Hero Constructors
		/// <summary>
		/// Zacian-Hero Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ZacianHero(string nickname, int level)
		: base(
				ZacianHeroSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zacian-Hero Constructor only waiting for a Level
		/// </summary>
		public ZacianHero(int level)
		: this( "Zacian-Hero", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zacian-Hero Constructor waiting for no params
		/// </summary>
		/*
		public ZacianHero() : this( "Zacian-Hero", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}