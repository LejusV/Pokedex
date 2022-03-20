using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Kirlia PokemonInstance Class
	#region Kirlia
	public class Kirlia : PokemonInstance
	{
		#region Kirlia Constructors
		/// <summary>
		/// Kirlia Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Kirlia(string nickname, int level)
		: base(
				KirliaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kirlia Constructor only waiting for a Level
		/// </summary>
		public Kirlia(int level)
		: this( "Kirlia", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kirlia Constructor waiting for no params
		/// </summary>
		/*
		public Kirlia() : this( "Kirlia", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}