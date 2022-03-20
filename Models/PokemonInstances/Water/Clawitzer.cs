using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Clawitzer PokemonInstance Class
	#region Clawitzer
	public class Clawitzer : PokemonInstance
	{
		#region Clawitzer Constructors
		/// <summary>
		/// Clawitzer Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Clawitzer(string nickname, int level)
		: base(
				ClawitzerSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Clawitzer Constructor only waiting for a Level
		/// </summary>
		public Clawitzer(int level)
		: this( "Clawitzer", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Clawitzer Constructor waiting for no params
		/// </summary>
		/*
		public Clawitzer() : this( "Clawitzer", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}