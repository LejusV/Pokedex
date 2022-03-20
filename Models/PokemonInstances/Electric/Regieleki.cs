using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Regieleki PokemonInstance Class
	#region Regieleki
	public class Regieleki : PokemonInstance
	{
		#region Regieleki Constructors
		/// <summary>
		/// Regieleki Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Regieleki(string nickname, int level)
		: base(
				RegielekiSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Regieleki Constructor only waiting for a Level
		/// </summary>
		public Regieleki(int level)
		: this( "Regieleki", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Regieleki Constructor waiting for no params
		/// </summary>
		/*
		public Regieleki() : this( "Regieleki", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}