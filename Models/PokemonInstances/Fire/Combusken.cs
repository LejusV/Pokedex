using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Combusken PokemonInstance Class
	#region Combusken
	public class Combusken : PokemonInstance
	{
		#region Combusken Constructors
		/// <summary>
		/// Combusken Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Combusken(string nickname, int level)
		: base(
				CombuskenSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Combusken Constructor only waiting for a Level
		/// </summary>
		public Combusken(int level)
		: this( "Combusken", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Combusken Constructor waiting for no params
		/// </summary>
		/*
		public Combusken() : this( "Combusken", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}