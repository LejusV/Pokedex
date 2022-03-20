using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Avalugg PokemonInstance Class
	#region Avalugg
	public class Avalugg : PokemonInstance
	{
		#region Avalugg Constructors
		/// <summary>
		/// Avalugg Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Avalugg(string nickname, int level)
		: base(
				AvaluggSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Avalugg Constructor only waiting for a Level
		/// </summary>
		public Avalugg(int level)
		: this( "Avalugg", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Avalugg Constructor waiting for no params
		/// </summary>
		/*
		public Avalugg() : this( "Avalugg", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}