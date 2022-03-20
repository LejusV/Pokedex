using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Sawsbuck PokemonInstance Class
	#region Sawsbuck
	public class Sawsbuck : PokemonInstance
	{
		#region Sawsbuck Constructors
		/// <summary>
		/// Sawsbuck Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Sawsbuck(string nickname, int level)
		: base(
				SawsbuckSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sawsbuck Constructor only waiting for a Level
		/// </summary>
		public Sawsbuck(int level)
		: this( "Sawsbuck", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sawsbuck Constructor waiting for no params
		/// </summary>
		/*
		public Sawsbuck() : this( "Sawsbuck", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}