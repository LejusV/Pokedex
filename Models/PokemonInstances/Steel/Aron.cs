using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Aron PokemonInstance Class
	#region Aron
	public class Aron : PokemonInstance
	{
		#region Aron Constructors
		/// <summary>
		/// Aron Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Aron(string nickname, int level)
		: base(
				AronSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Aron Constructor only waiting for a Level
		/// </summary>
		public Aron(int level)
		: this( "Aron", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Aron Constructor waiting for no params
		/// </summary>
		/*
		public Aron() : this( "Aron", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}