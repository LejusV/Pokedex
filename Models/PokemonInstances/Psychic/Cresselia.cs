using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Cresselia PokemonInstance Class
	#region Cresselia
	public class Cresselia : PokemonInstance
	{
		#region Cresselia Constructors
		/// <summary>
		/// Cresselia Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Cresselia(string nickname, int level)
		: base(
				CresseliaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cresselia Constructor only waiting for a Level
		/// </summary>
		public Cresselia(int level)
		: this( "Cresselia", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cresselia Constructor waiting for no params
		/// </summary>
		/*
		public Cresselia() : this( "Cresselia", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}