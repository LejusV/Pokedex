using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Torracat PokemonInstance Class
	#region Torracat
	public class Torracat : PokemonInstance
	{
		#region Torracat Constructors
		/// <summary>
		/// Torracat Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Torracat(string nickname, int level)
		: base(
				TorracatSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Torracat Constructor only waiting for a Level
		/// </summary>
		public Torracat(int level)
		: this( "Torracat", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Torracat Constructor waiting for no params
		/// </summary>
		/*
		public Torracat() : this( "Torracat", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}