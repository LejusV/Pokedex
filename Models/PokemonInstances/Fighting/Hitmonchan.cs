using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Hitmonchan PokemonInstance Class
	#region Hitmonchan
	public class Hitmonchan : PokemonInstance
	{
		#region Hitmonchan Constructors
		/// <summary>
		/// Hitmonchan Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Hitmonchan(string nickname, int level)
		: base(
				HitmonchanSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hitmonchan Constructor only waiting for a Level
		/// </summary>
		public Hitmonchan(int level)
		: this( "Hitmonchan", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hitmonchan Constructor waiting for no params
		/// </summary>
		/*
		public Hitmonchan() : this( "Hitmonchan", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}