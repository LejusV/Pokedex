using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Snubbull PokemonInstance Class
	#region Snubbull
	public class Snubbull : PokemonInstance
	{
		#region Snubbull Constructors
		/// <summary>
		/// Snubbull Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Snubbull(string nickname, int level)
		: base(
				SnubbullSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Snubbull Constructor only waiting for a Level
		/// </summary>
		public Snubbull(int level)
		: this( "Snubbull", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Snubbull Constructor waiting for no params
		/// </summary>
		/*
		public Snubbull() : this( "Snubbull", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}