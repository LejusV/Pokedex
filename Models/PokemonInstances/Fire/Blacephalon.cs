using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Blacephalon PokemonInstance Class
	#region Blacephalon
	public class Blacephalon : PokemonInstance
	{
		#region Blacephalon Constructors
		/// <summary>
		/// Blacephalon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Blacephalon(string nickname, int level)
		: base(
				BlacephalonSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Blacephalon Constructor only waiting for a Level
		/// </summary>
		public Blacephalon(int level)
		: this( "Blacephalon", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Blacephalon Constructor waiting for no params
		/// </summary>
		/*
		public Blacephalon() : this( "Blacephalon", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}