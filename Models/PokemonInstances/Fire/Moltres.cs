using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Moltres PokemonInstance Class
	#region Moltres
	public class Moltres : PokemonInstance
	{
		#region Moltres Constructors
		/// <summary>
		/// Moltres Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Moltres(string nickname, int level)
		: base(
				MoltresSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Moltres Constructor only waiting for a Level
		/// </summary>
		public Moltres(int level)
		: this( "Moltres", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Moltres Constructor waiting for no params
		/// </summary>
		/*
		public Moltres() : this( "Moltres", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}