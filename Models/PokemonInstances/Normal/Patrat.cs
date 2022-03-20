using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Patrat PokemonInstance Class
	#region Patrat
	public class Patrat : PokemonInstance
	{
		#region Patrat Constructors
		/// <summary>
		/// Patrat Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Patrat(string nickname, int level)
		: base(
				PatratSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Patrat Constructor only waiting for a Level
		/// </summary>
		public Patrat(int level)
		: this( "Patrat", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Patrat Constructor waiting for no params
		/// </summary>
		/*
		public Patrat() : this( "Patrat", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}