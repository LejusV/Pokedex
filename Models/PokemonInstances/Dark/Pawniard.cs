using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Pawniard PokemonInstance Class
	#region Pawniard
	public class Pawniard : PokemonInstance
	{
		#region Pawniard Constructors
		/// <summary>
		/// Pawniard Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Pawniard(string nickname, int level)
		: base(
				PawniardSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pawniard Constructor only waiting for a Level
		/// </summary>
		public Pawniard(int level)
		: this( "Pawniard", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pawniard Constructor waiting for no params
		/// </summary>
		/*
		public Pawniard() : this( "Pawniard", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}