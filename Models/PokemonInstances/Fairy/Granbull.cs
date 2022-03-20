using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Granbull PokemonInstance Class
	#region Granbull
	public class Granbull : PokemonInstance
	{
		#region Granbull Constructors
		/// <summary>
		/// Granbull Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Granbull(string nickname, int level)
		: base(
				GranbullSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Granbull Constructor only waiting for a Level
		/// </summary>
		public Granbull(int level)
		: this( "Granbull", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Granbull Constructor waiting for no params
		/// </summary>
		/*
		public Granbull() : this( "Granbull", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}