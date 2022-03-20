using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Octillery PokemonInstance Class
	#region Octillery
	public class Octillery : PokemonInstance
	{
		#region Octillery Constructors
		/// <summary>
		/// Octillery Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Octillery(string nickname, int level)
		: base(
				OctillerySpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Octillery Constructor only waiting for a Level
		/// </summary>
		public Octillery(int level)
		: this( "Octillery", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Octillery Constructor waiting for no params
		/// </summary>
		/*
		public Octillery() : this( "Octillery", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}