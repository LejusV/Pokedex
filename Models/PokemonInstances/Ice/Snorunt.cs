using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Snorunt PokemonInstance Class
	#region Snorunt
	public class Snorunt : PokemonInstance
	{
		#region Snorunt Constructors
		/// <summary>
		/// Snorunt Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Snorunt(string nickname, int level)
		: base(
				SnoruntSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Snorunt Constructor only waiting for a Level
		/// </summary>
		public Snorunt(int level)
		: this( "Snorunt", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Snorunt Constructor waiting for no params
		/// </summary>
		/*
		public Snorunt() : this( "Snorunt", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}