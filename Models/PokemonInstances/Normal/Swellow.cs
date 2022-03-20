using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Swellow PokemonInstance Class
	#region Swellow
	public class Swellow : PokemonInstance
	{
		#region Swellow Constructors
		/// <summary>
		/// Swellow Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Swellow(string nickname, int level)
		: base(
				SwellowSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Swellow Constructor only waiting for a Level
		/// </summary>
		public Swellow(int level)
		: this( "Swellow", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Swellow Constructor waiting for no params
		/// </summary>
		/*
		public Swellow() : this( "Swellow", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}