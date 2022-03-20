using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Scraggy PokemonInstance Class
	#region Scraggy
	public class Scraggy : PokemonInstance
	{
		#region Scraggy Constructors
		/// <summary>
		/// Scraggy Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Scraggy(string nickname, int level)
		: base(
				ScraggySpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Scraggy Constructor only waiting for a Level
		/// </summary>
		public Scraggy(int level)
		: this( "Scraggy", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Scraggy Constructor waiting for no params
		/// </summary>
		/*
		public Scraggy() : this( "Scraggy", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}