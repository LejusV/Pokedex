using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Koffing PokemonInstance Class
	#region Koffing
	public class Koffing : PokemonInstance
	{
		#region Koffing Constructors
		/// <summary>
		/// Koffing Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Koffing(string nickname, int level)
		: base(
				KoffingSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Koffing Constructor only waiting for a Level
		/// </summary>
		public Koffing(int level)
		: this( "Koffing", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Koffing Constructor waiting for no params
		/// </summary>
		/*
		public Koffing() : this( "Koffing", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}