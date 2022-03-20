using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Deerling PokemonInstance Class
	#region Deerling
	public class Deerling : PokemonInstance
	{
		#region Deerling Constructors
		/// <summary>
		/// Deerling Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Deerling(string nickname, int level)
		: base(
				DeerlingSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Deerling Constructor only waiting for a Level
		/// </summary>
		public Deerling(int level)
		: this( "Deerling", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Deerling Constructor waiting for no params
		/// </summary>
		/*
		public Deerling() : this( "Deerling", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}