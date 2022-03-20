using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Gurdurr PokemonInstance Class
	#region Gurdurr
	public class Gurdurr : PokemonInstance
	{
		#region Gurdurr Constructors
		/// <summary>
		/// Gurdurr Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Gurdurr(string nickname, int level)
		: base(
				GurdurrSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gurdurr Constructor only waiting for a Level
		/// </summary>
		public Gurdurr(int level)
		: this( "Gurdurr", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gurdurr Constructor waiting for no params
		/// </summary>
		/*
		public Gurdurr() : this( "Gurdurr", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}