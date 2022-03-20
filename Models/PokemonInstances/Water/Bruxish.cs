using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Bruxish PokemonInstance Class
	#region Bruxish
	public class Bruxish : PokemonInstance
	{
		#region Bruxish Constructors
		/// <summary>
		/// Bruxish Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Bruxish(string nickname, int level)
		: base(
				BruxishSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bruxish Constructor only waiting for a Level
		/// </summary>
		public Bruxish(int level)
		: this( "Bruxish", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bruxish Constructor waiting for no params
		/// </summary>
		/*
		public Bruxish() : this( "Bruxish", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}