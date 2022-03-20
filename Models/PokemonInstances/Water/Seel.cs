using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Seel PokemonInstance Class
	#region Seel
	public class Seel : PokemonInstance
	{
		#region Seel Constructors
		/// <summary>
		/// Seel Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Seel(string nickname, int level)
		: base(
				SeelSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Seel Constructor only waiting for a Level
		/// </summary>
		public Seel(int level)
		: this( "Seel", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Seel Constructor waiting for no params
		/// </summary>
		/*
		public Seel() : this( "Seel", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}