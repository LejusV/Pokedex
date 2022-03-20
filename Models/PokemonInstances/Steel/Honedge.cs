using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Honedge PokemonInstance Class
	#region Honedge
	public class Honedge : PokemonInstance
	{
		#region Honedge Constructors
		/// <summary>
		/// Honedge Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Honedge(string nickname, int level)
		: base(
				HonedgeSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Honedge Constructor only waiting for a Level
		/// </summary>
		public Honedge(int level)
		: this( "Honedge", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Honedge Constructor waiting for no params
		/// </summary>
		/*
		public Honedge() : this( "Honedge", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}