using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Gorebyss PokemonInstance Class
	#region Gorebyss
	public class Gorebyss : PokemonInstance
	{
		#region Gorebyss Constructors
		/// <summary>
		/// Gorebyss Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Gorebyss(string nickname, int level)
		: base(
				GorebyssSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gorebyss Constructor only waiting for a Level
		/// </summary>
		public Gorebyss(int level)
		: this( "Gorebyss", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gorebyss Constructor waiting for no params
		/// </summary>
		/*
		public Gorebyss() : this( "Gorebyss", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}