using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Luvdisc PokemonInstance Class
	#region Luvdisc
	public class Luvdisc : PokemonInstance
	{
		#region Luvdisc Constructors
		/// <summary>
		/// Luvdisc Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Luvdisc(string nickname, int level)
		: base(
				LuvdiscSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Luvdisc Constructor only waiting for a Level
		/// </summary>
		public Luvdisc(int level)
		: this( "Luvdisc", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Luvdisc Constructor waiting for no params
		/// </summary>
		/*
		public Luvdisc() : this( "Luvdisc", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}