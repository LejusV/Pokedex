using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Feraligatr PokemonInstance Class
	#region Feraligatr
	public class Feraligatr : PokemonInstance
	{
		#region Feraligatr Constructors
		/// <summary>
		/// Feraligatr Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Feraligatr(string nickname, int level)
		: base(
				FeraligatrSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Feraligatr Constructor only waiting for a Level
		/// </summary>
		public Feraligatr(int level)
		: this( "Feraligatr", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Feraligatr Constructor waiting for no params
		/// </summary>
		/*
		public Feraligatr() : this( "Feraligatr", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}