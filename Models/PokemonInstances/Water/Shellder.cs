using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Shellder PokemonInstance Class
	#region Shellder
	public class Shellder : PokemonInstance
	{
		#region Shellder Constructors
		/// <summary>
		/// Shellder Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Shellder(string nickname, int level)
		: base(
				ShellderSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shellder Constructor only waiting for a Level
		/// </summary>
		public Shellder(int level)
		: this( "Shellder", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shellder Constructor waiting for no params
		/// </summary>
		/*
		public Shellder() : this( "Shellder", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}