using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Palkia PokemonInstance Class
	#region Palkia
	public class Palkia : PokemonInstance
	{
		#region Palkia Constructors
		/// <summary>
		/// Palkia Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Palkia(string nickname, int level)
		: base(
				PalkiaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Palkia Constructor only waiting for a Level
		/// </summary>
		public Palkia(int level)
		: this( "Palkia", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Palkia Constructor waiting for no params
		/// </summary>
		/*
		public Palkia() : this( "Palkia", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}