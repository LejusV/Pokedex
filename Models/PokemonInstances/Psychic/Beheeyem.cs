using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Beheeyem PokemonInstance Class
	#region Beheeyem
	public class Beheeyem : PokemonInstance
	{
		#region Beheeyem Constructors
		/// <summary>
		/// Beheeyem Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Beheeyem(string nickname, int level)
		: base(
				BeheeyemSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Beheeyem Constructor only waiting for a Level
		/// </summary>
		public Beheeyem(int level)
		: this( "Beheeyem", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Beheeyem Constructor waiting for no params
		/// </summary>
		/*
		public Beheeyem() : this( "Beheeyem", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}