using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Exeggutor PokemonInstance Class
	#region Exeggutor
	public class Exeggutor : PokemonInstance
	{
		#region Exeggutor Constructors
		/// <summary>
		/// Exeggutor Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Exeggutor(string nickname, int level)
		: base(
				ExeggutorSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Exeggutor Constructor only waiting for a Level
		/// </summary>
		public Exeggutor(int level)
		: this( "Exeggutor", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Exeggutor Constructor waiting for no params
		/// </summary>
		/*
		public Exeggutor() : this( "Exeggutor", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}