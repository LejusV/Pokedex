using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Delphox PokemonInstance Class
	#region Delphox
	public class Delphox : PokemonInstance
	{
		#region Delphox Constructors
		/// <summary>
		/// Delphox Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Delphox(string nickname, int level)
		: base(
				DelphoxSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Delphox Constructor only waiting for a Level
		/// </summary>
		public Delphox(int level)
		: this( "Delphox", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Delphox Constructor waiting for no params
		/// </summary>
		/*
		public Delphox() : this( "Delphox", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}