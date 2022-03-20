using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Duosion PokemonInstance Class
	#region Duosion
	public class Duosion : PokemonInstance
	{
		#region Duosion Constructors
		/// <summary>
		/// Duosion Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Duosion(string nickname, int level)
		: base(
				DuosionSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Duosion Constructor only waiting for a Level
		/// </summary>
		public Duosion(int level)
		: this( "Duosion", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Duosion Constructor waiting for no params
		/// </summary>
		/*
		public Duosion() : this( "Duosion", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}