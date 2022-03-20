using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Salamence PokemonInstance Class
	#region Salamence
	public class Salamence : PokemonInstance
	{
		#region Salamence Constructors
		/// <summary>
		/// Salamence Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Salamence(string nickname, int level)
		: base(
				SalamenceSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Salamence Constructor only waiting for a Level
		/// </summary>
		public Salamence(int level)
		: this( "Salamence", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Salamence Constructor waiting for no params
		/// </summary>
		/*
		public Salamence() : this( "Salamence", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}