using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Archeops PokemonInstance Class
	#region Archeops
	public class Archeops : PokemonInstance
	{
		#region Archeops Constructors
		/// <summary>
		/// Archeops Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Archeops(string nickname, int level)
		: base(
				ArcheopsSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Archeops Constructor only waiting for a Level
		/// </summary>
		public Archeops(int level)
		: this( "Archeops", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Archeops Constructor waiting for no params
		/// </summary>
		/*
		public Archeops() : this( "Archeops", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}