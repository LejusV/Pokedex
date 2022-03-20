using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Chimecho PokemonInstance Class
	#region Chimecho
	public class Chimecho : PokemonInstance
	{
		#region Chimecho Constructors
		/// <summary>
		/// Chimecho Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Chimecho(string nickname, int level)
		: base(
				ChimechoSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chimecho Constructor only waiting for a Level
		/// </summary>
		public Chimecho(int level)
		: this( "Chimecho", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chimecho Constructor waiting for no params
		/// </summary>
		/*
		public Chimecho() : this( "Chimecho", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}