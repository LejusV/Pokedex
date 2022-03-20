using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Poipole PokemonInstance Class
	#region Poipole
	public class Poipole : PokemonInstance
	{
		#region Poipole Constructors
		/// <summary>
		/// Poipole Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Poipole(string nickname, int level)
		: base(
				PoipoleSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Poipole Constructor only waiting for a Level
		/// </summary>
		public Poipole(int level)
		: this( "Poipole", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Poipole Constructor waiting for no params
		/// </summary>
		/*
		public Poipole() : this( "Poipole", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}