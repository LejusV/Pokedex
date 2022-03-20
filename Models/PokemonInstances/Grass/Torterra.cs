using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Torterra PokemonInstance Class
	#region Torterra
	public class Torterra : PokemonInstance
	{
		#region Torterra Constructors
		/// <summary>
		/// Torterra Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Torterra(string nickname, int level)
		: base(
				TorterraSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Torterra Constructor only waiting for a Level
		/// </summary>
		public Torterra(int level)
		: this( "Torterra", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Torterra Constructor waiting for no params
		/// </summary>
		/*
		public Torterra() : this( "Torterra", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}