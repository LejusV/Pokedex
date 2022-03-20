using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Golduck PokemonInstance Class
	#region Golduck
	public class Golduck : PokemonInstance
	{
		#region Golduck Constructors
		/// <summary>
		/// Golduck Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Golduck(string nickname, int level)
		: base(
				GolduckSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Golduck Constructor only waiting for a Level
		/// </summary>
		public Golduck(int level)
		: this( "Golduck", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Golduck Constructor waiting for no params
		/// </summary>
		/*
		public Golduck() : this( "Golduck", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}