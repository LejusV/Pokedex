using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Registeel PokemonInstance Class
	#region Registeel
	public class Registeel : PokemonInstance
	{
		#region Registeel Constructors
		/// <summary>
		/// Registeel Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Registeel(string nickname, int level)
		: base(
				RegisteelSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Registeel Constructor only waiting for a Level
		/// </summary>
		public Registeel(int level)
		: this( "Registeel", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Registeel Constructor waiting for no params
		/// </summary>
		/*
		public Registeel() : this( "Registeel", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}