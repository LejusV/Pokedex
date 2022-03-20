using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Starmie PokemonInstance Class
	#region Starmie
	public class Starmie : PokemonInstance
	{
		#region Starmie Constructors
		/// <summary>
		/// Starmie Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Starmie(string nickname, int level)
		: base(
				StarmieSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Starmie Constructor only waiting for a Level
		/// </summary>
		public Starmie(int level)
		: this( "Starmie", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Starmie Constructor waiting for no params
		/// </summary>
		/*
		public Starmie() : this( "Starmie", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}