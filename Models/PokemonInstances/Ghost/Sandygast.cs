using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Sandygast PokemonInstance Class
	#region Sandygast
	public class Sandygast : PokemonInstance
	{
		#region Sandygast Constructors
		/// <summary>
		/// Sandygast Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Sandygast(string nickname, int level)
		: base(
				SandygastSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sandygast Constructor only waiting for a Level
		/// </summary>
		public Sandygast(int level)
		: this( "Sandygast", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sandygast Constructor waiting for no params
		/// </summary>
		/*
		public Sandygast() : this( "Sandygast", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}