using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Tympole PokemonInstance Class
	#region Tympole
	public class Tympole : PokemonInstance
	{
		#region Tympole Constructors
		/// <summary>
		/// Tympole Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Tympole(string nickname, int level)
		: base(
				TympoleSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tympole Constructor only waiting for a Level
		/// </summary>
		public Tympole(int level)
		: this( "Tympole", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tympole Constructor waiting for no params
		/// </summary>
		/*
		public Tympole() : this( "Tympole", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}