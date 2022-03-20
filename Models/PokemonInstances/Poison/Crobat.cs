using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Crobat PokemonInstance Class
	#region Crobat
	public class Crobat : PokemonInstance
	{
		#region Crobat Constructors
		/// <summary>
		/// Crobat Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Crobat(string nickname, int level)
		: base(
				CrobatSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Crobat Constructor only waiting for a Level
		/// </summary>
		public Crobat(int level)
		: this( "Crobat", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Crobat Constructor waiting for no params
		/// </summary>
		/*
		public Crobat() : this( "Crobat", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}