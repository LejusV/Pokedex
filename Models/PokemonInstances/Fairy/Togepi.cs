using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Togepi PokemonInstance Class
	#region Togepi
	public class Togepi : PokemonInstance
	{
		#region Togepi Constructors
		/// <summary>
		/// Togepi Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Togepi(string nickname, int level)
		: base(
				TogepiSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Togepi Constructor only waiting for a Level
		/// </summary>
		public Togepi(int level)
		: this( "Togepi", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Togepi Constructor waiting for no params
		/// </summary>
		/*
		public Togepi() : this( "Togepi", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}