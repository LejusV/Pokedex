using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Diglett PokemonInstance Class
	#region Diglett
	public class Diglett : PokemonInstance
	{
		#region Diglett Constructors
		/// <summary>
		/// Diglett Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Diglett(string nickname, int level)
		: base(
				DiglettSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Diglett Constructor only waiting for a Level
		/// </summary>
		public Diglett(int level)
		: this( "Diglett", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Diglett Constructor waiting for no params
		/// </summary>
		/*
		public Diglett() : this( "Diglett", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}