using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Fletchling PokemonInstance Class
	#region Fletchling
	public class Fletchling : PokemonInstance
	{
		#region Fletchling Constructors
		/// <summary>
		/// Fletchling Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Fletchling(string nickname, int level)
		: base(
				FletchlingSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Fletchling Constructor only waiting for a Level
		/// </summary>
		public Fletchling(int level)
		: this( "Fletchling", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Fletchling Constructor waiting for no params
		/// </summary>
		/*
		public Fletchling() : this( "Fletchling", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}