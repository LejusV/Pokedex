using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Quilladin PokemonInstance Class
	#region Quilladin
	public class Quilladin : PokemonInstance
	{
		#region Quilladin Constructors
		/// <summary>
		/// Quilladin Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Quilladin(string nickname, int level)
		: base(
				QuilladinSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Quilladin Constructor only waiting for a Level
		/// </summary>
		public Quilladin(int level)
		: this( "Quilladin", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Quilladin Constructor waiting for no params
		/// </summary>
		/*
		public Quilladin() : this( "Quilladin", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}