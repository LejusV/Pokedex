using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Ekans PokemonInstance Class
	#region Ekans
	public class Ekans : PokemonInstance
	{
		#region Ekans Constructors
		/// <summary>
		/// Ekans Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Ekans(string nickname, int level)
		: base(
				EkansSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ekans Constructor only waiting for a Level
		/// </summary>
		public Ekans(int level)
		: this( "Ekans", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ekans Constructor waiting for no params
		/// </summary>
		/*
		public Ekans() : this( "Ekans", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}