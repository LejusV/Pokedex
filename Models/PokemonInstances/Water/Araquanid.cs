using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Araquanid PokemonInstance Class
	#region Araquanid
	public class Araquanid : PokemonInstance
	{
		#region Araquanid Constructors
		/// <summary>
		/// Araquanid Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Araquanid(string nickname, int level)
		: base(
				AraquanidSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Araquanid Constructor only waiting for a Level
		/// </summary>
		public Araquanid(int level)
		: this( "Araquanid", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Araquanid Constructor waiting for no params
		/// </summary>
		/*
		public Araquanid() : this( "Araquanid", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}