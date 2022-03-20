using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Audino PokemonInstance Class
	#region Audino
	public class Audino : PokemonInstance
	{
		#region Audino Constructors
		/// <summary>
		/// Audino Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Audino(string nickname, int level)
		: base(
				AudinoSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Audino Constructor only waiting for a Level
		/// </summary>
		public Audino(int level)
		: this( "Audino", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Audino Constructor waiting for no params
		/// </summary>
		/*
		public Audino() : this( "Audino", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}