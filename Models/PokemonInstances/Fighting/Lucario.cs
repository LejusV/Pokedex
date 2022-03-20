using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Lucario PokemonInstance Class
	#region Lucario
	public class Lucario : PokemonInstance
	{
		#region Lucario Constructors
		/// <summary>
		/// Lucario Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Lucario(string nickname, int level)
		: base(
				LucarioSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lucario Constructor only waiting for a Level
		/// </summary>
		public Lucario(int level)
		: this( "Lucario", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lucario Constructor waiting for no params
		/// </summary>
		/*
		public Lucario() : this( "Lucario", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}