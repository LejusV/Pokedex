using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Celesteela PokemonInstance Class
	#region Celesteela
	public class Celesteela : PokemonInstance
	{
		#region Celesteela Constructors
		/// <summary>
		/// Celesteela Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Celesteela(string nickname, int level)
		: base(
				CelesteelaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Celesteela Constructor only waiting for a Level
		/// </summary>
		public Celesteela(int level)
		: this( "Celesteela", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Celesteela Constructor waiting for no params
		/// </summary>
		/*
		public Celesteela() : this( "Celesteela", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}