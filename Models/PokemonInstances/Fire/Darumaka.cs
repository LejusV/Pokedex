using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Darumaka PokemonInstance Class
	#region Darumaka
	public class Darumaka : PokemonInstance
	{
		#region Darumaka Constructors
		/// <summary>
		/// Darumaka Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Darumaka(string nickname, int level)
		: base(
				DarumakaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Darumaka Constructor only waiting for a Level
		/// </summary>
		public Darumaka(int level)
		: this( "Darumaka", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Darumaka Constructor waiting for no params
		/// </summary>
		/*
		public Darumaka() : this( "Darumaka", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}