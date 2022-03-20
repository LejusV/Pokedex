using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Grimer PokemonInstance Class
	#region Grimer
	public class Grimer : PokemonInstance
	{
		#region Grimer Constructors
		/// <summary>
		/// Grimer Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Grimer(string nickname, int level)
		: base(
				GrimerSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Grimer Constructor only waiting for a Level
		/// </summary>
		public Grimer(int level)
		: this( "Grimer", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Grimer Constructor waiting for no params
		/// </summary>
		/*
		public Grimer() : this( "Grimer", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}