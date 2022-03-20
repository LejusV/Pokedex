using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Drednaw PokemonInstance Class
	#region Drednaw
	public class Drednaw : PokemonInstance
	{
		#region Drednaw Constructors
		/// <summary>
		/// Drednaw Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Drednaw(string nickname, int level)
		: base(
				DrednawSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Drednaw Constructor only waiting for a Level
		/// </summary>
		public Drednaw(int level)
		: this( "Drednaw", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Drednaw Constructor waiting for no params
		/// </summary>
		/*
		public Drednaw() : this( "Drednaw", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}