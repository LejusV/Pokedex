using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Roselia PokemonInstance Class
	#region Roselia
	public class Roselia : PokemonInstance
	{
		#region Roselia Constructors
		/// <summary>
		/// Roselia Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Roselia(string nickname, int level)
		: base(
				RoseliaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Roselia Constructor only waiting for a Level
		/// </summary>
		public Roselia(int level)
		: this( "Roselia", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Roselia Constructor waiting for no params
		/// </summary>
		/*
		public Roselia() : this( "Roselia", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}