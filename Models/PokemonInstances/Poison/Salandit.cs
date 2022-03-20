using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Salandit PokemonInstance Class
	#region Salandit
	public class Salandit : PokemonInstance
	{
		#region Salandit Constructors
		/// <summary>
		/// Salandit Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Salandit(string nickname, int level)
		: base(
				SalanditSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Salandit Constructor only waiting for a Level
		/// </summary>
		public Salandit(int level)
		: this( "Salandit", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Salandit Constructor waiting for no params
		/// </summary>
		/*
		public Salandit() : this( "Salandit", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}