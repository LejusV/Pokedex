using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Seviper PokemonInstance Class
	#region Seviper
	public class Seviper : PokemonInstance
	{
		#region Seviper Constructors
		/// <summary>
		/// Seviper Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Seviper(string nickname, int level)
		: base(
				SeviperSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Seviper Constructor only waiting for a Level
		/// </summary>
		public Seviper(int level)
		: this( "Seviper", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Seviper Constructor waiting for no params
		/// </summary>
		/*
		public Seviper() : this( "Seviper", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}