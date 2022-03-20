using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Rampardos PokemonInstance Class
	#region Rampardos
	public class Rampardos : PokemonInstance
	{
		#region Rampardos Constructors
		/// <summary>
		/// Rampardos Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Rampardos(string nickname, int level)
		: base(
				RampardosSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rampardos Constructor only waiting for a Level
		/// </summary>
		public Rampardos(int level)
		: this( "Rampardos", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rampardos Constructor waiting for no params
		/// </summary>
		/*
		public Rampardos() : this( "Rampardos", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}