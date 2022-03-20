using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Pincurchin PokemonInstance Class
	#region Pincurchin
	public class Pincurchin : PokemonInstance
	{
		#region Pincurchin Constructors
		/// <summary>
		/// Pincurchin Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Pincurchin(string nickname, int level)
		: base(
				PincurchinSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pincurchin Constructor only waiting for a Level
		/// </summary>
		public Pincurchin(int level)
		: this( "Pincurchin", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pincurchin Constructor waiting for no params
		/// </summary>
		/*
		public Pincurchin() : this( "Pincurchin", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}