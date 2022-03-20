using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Swirlix PokemonInstance Class
	#region Swirlix
	public class Swirlix : PokemonInstance
	{
		#region Swirlix Constructors
		/// <summary>
		/// Swirlix Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Swirlix(string nickname, int level)
		: base(
				SwirlixSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Swirlix Constructor only waiting for a Level
		/// </summary>
		public Swirlix(int level)
		: this( "Swirlix", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Swirlix Constructor waiting for no params
		/// </summary>
		/*
		public Swirlix() : this( "Swirlix", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}