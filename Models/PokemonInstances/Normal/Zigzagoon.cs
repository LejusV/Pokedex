using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Zigzagoon PokemonInstance Class
	#region Zigzagoon
	public class Zigzagoon : PokemonInstance
	{
		#region Zigzagoon Constructors
		/// <summary>
		/// Zigzagoon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Zigzagoon(string nickname, int level)
		: base(
				ZigzagoonSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zigzagoon Constructor only waiting for a Level
		/// </summary>
		public Zigzagoon(int level)
		: this( "Zigzagoon", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zigzagoon Constructor waiting for no params
		/// </summary>
		/*
		public Zigzagoon() : this( "Zigzagoon", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}