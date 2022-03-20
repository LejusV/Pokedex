using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Haunter PokemonInstance Class
	#region Haunter
	public class Haunter : PokemonInstance
	{
		#region Haunter Constructors
		/// <summary>
		/// Haunter Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Haunter(string nickname, int level)
		: base(
				HaunterSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Haunter Constructor only waiting for a Level
		/// </summary>
		public Haunter(int level)
		: this( "Haunter", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Haunter Constructor waiting for no params
		/// </summary>
		/*
		public Haunter() : this( "Haunter", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}