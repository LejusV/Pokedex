using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Ferroseed PokemonInstance Class
	#region Ferroseed
	public class Ferroseed : PokemonInstance
	{
		#region Ferroseed Constructors
		/// <summary>
		/// Ferroseed Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Ferroseed(string nickname, int level)
		: base(
				FerroseedSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ferroseed Constructor only waiting for a Level
		/// </summary>
		public Ferroseed(int level)
		: this( "Ferroseed", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ferroseed Constructor waiting for no params
		/// </summary>
		/*
		public Ferroseed() : this( "Ferroseed", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}