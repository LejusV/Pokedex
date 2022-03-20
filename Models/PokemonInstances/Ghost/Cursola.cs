using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Cursola PokemonInstance Class
	#region Cursola
	public class Cursola : PokemonInstance
	{
		#region Cursola Constructors
		/// <summary>
		/// Cursola Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Cursola(string nickname, int level)
		: base(
				CursolaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cursola Constructor only waiting for a Level
		/// </summary>
		public Cursola(int level)
		: this( "Cursola", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cursola Constructor waiting for no params
		/// </summary>
		/*
		public Cursola() : this( "Cursola", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}