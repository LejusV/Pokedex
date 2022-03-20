using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Haxorus PokemonInstance Class
	#region Haxorus
	public class Haxorus : PokemonInstance
	{
		#region Haxorus Constructors
		/// <summary>
		/// Haxorus Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Haxorus(string nickname, int level)
		: base(
				HaxorusSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Haxorus Constructor only waiting for a Level
		/// </summary>
		public Haxorus(int level)
		: this( "Haxorus", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Haxorus Constructor waiting for no params
		/// </summary>
		/*
		public Haxorus() : this( "Haxorus", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}