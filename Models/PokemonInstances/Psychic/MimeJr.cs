using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Mime-Jr PokemonInstance Class
	#region Mime-Jr
	public class MimeJr : PokemonInstance
	{
		#region Mime-Jr Constructors
		/// <summary>
		/// Mime-Jr Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MimeJr(string nickname, int level)
		: base(
				MimeJrSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mime-Jr Constructor only waiting for a Level
		/// </summary>
		public MimeJr(int level)
		: this( "Mime-Jr", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mime-Jr Constructor waiting for no params
		/// </summary>
		/*
		public MimeJr() : this( "Mime-Jr", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}