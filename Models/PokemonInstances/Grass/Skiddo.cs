using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Skiddo PokemonInstance Class
	#region Skiddo
	public class Skiddo : PokemonInstance
	{
		#region Skiddo Constructors
		/// <summary>
		/// Skiddo Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Skiddo(string nickname, int level)
		: base(
				SkiddoSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Skiddo Constructor only waiting for a Level
		/// </summary>
		public Skiddo(int level)
		: this( "Skiddo", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Skiddo Constructor waiting for no params
		/// </summary>
		/*
		public Skiddo() : this( "Skiddo", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}