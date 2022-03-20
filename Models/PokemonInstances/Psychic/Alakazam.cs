using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Alakazam PokemonInstance Class
	#region Alakazam
	public class Alakazam : PokemonInstance
	{
		#region Alakazam Constructors
		/// <summary>
		/// Alakazam Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Alakazam(string nickname, int level)
		: base(
				AlakazamSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Alakazam Constructor only waiting for a Level
		/// </summary>
		public Alakazam(int level)
		: this( "Alakazam", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Alakazam Constructor waiting for no params
		/// </summary>
		/*
		public Alakazam() : this( "Alakazam", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}