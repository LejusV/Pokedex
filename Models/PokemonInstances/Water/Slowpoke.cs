using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Slowpoke PokemonInstance Class
	#region Slowpoke
	public class Slowpoke : PokemonInstance
	{
		#region Slowpoke Constructors
		/// <summary>
		/// Slowpoke Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Slowpoke(string nickname, int level)
		: base(
				SlowpokeSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Slowpoke Constructor only waiting for a Level
		/// </summary>
		public Slowpoke(int level)
		: this( "Slowpoke", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Slowpoke Constructor waiting for no params
		/// </summary>
		/*
		public Slowpoke() : this( "Slowpoke", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}