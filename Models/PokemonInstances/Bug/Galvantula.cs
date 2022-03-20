using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Galvantula PokemonInstance Class
	#region Galvantula
	public class Galvantula : PokemonInstance
	{
		#region Galvantula Constructors
		/// <summary>
		/// Galvantula Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Galvantula(string nickname, int level)
		: base(
				GalvantulaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Galvantula Constructor only waiting for a Level
		/// </summary>
		public Galvantula(int level)
		: this( "Galvantula", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Galvantula Constructor waiting for no params
		/// </summary>
		/*
		public Galvantula() : this( "Galvantula", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}