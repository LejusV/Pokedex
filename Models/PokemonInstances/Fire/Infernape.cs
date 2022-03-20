using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Infernape PokemonInstance Class
	#region Infernape
	public class Infernape : PokemonInstance
	{
		#region Infernape Constructors
		/// <summary>
		/// Infernape Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Infernape(string nickname, int level)
		: base(
				InfernapeSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Infernape Constructor only waiting for a Level
		/// </summary>
		public Infernape(int level)
		: this( "Infernape", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Infernape Constructor waiting for no params
		/// </summary>
		/*
		public Infernape() : this( "Infernape", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}