using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Cherubi PokemonInstance Class
	#region Cherubi
	public class Cherubi : PokemonInstance
	{
		#region Cherubi Constructors
		/// <summary>
		/// Cherubi Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Cherubi(string nickname, int level)
		: base(
				CherubiSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cherubi Constructor only waiting for a Level
		/// </summary>
		public Cherubi(int level)
		: this( "Cherubi", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cherubi Constructor waiting for no params
		/// </summary>
		/*
		public Cherubi() : this( "Cherubi", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}